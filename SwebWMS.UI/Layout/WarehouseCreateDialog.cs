using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class WarehouseCreateDialog : Swebui.Controls.SwebUserControl
    {
        public WarehouseCreateDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        public String WareID;    //仓库编号
        public Boolean isCreate;     //页面是否为创建状态
        public Boolean isEdit;       //页面是否为编辑状态
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        private void btnManager_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnManager.Tag = args.TreeID;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtWareID.Text)) throw new Exception("仓库编号不能为空");
                if (String.IsNullOrEmpty(txtWareName.Text)) throw new Exception("仓库名称不能为空");
                if (btnManager.Tag == null) throw new Exception("负责人不能为空");

                WareHouseInputDto inputDto = new WareHouseInputDto
                {
                    WAREID = txtWareID.Text,
                    ISENABLE = switchIsEnable.Checked ? 1 : 0,
                    NAME = txtWareName.Text,
                    MANAGER = btnManager.Tag.ToString(),
                    PLACE = txtPlace.Text,
                    MODIFYUSER = Client.Session["UserID"].ToString()
                };
                if (isCreate)
                {
                    inputDto.CREATEUSER = Client.Session["UserID"].ToString();
                    //添加
                    ReturnInfo rInfo = autofacConfig.wareHouseService.AddWareHouse(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
                        Toast("创建仓库成功");
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }
                else if (isEdit)
                {
                    //编辑
                    ReturnInfo rInfo = autofacConfig.wareHouseService.UpdateWareHouse(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
                        Toast("编辑仓库成功");
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }

            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }

        private void WarehouseCreateDialog_Load(object sender, EventArgs e)
        {

            try
            {
                List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
                foreach (coreUser Row in users)
                {
                    btnManager.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
                }
                if (isEdit)
                {
                    label1.Text = "编辑仓库";
                    WareHouse wareHouse = autofacConfig.wareHouseService.GetByWareID(WareID);
                    txtWareID.Text = wareHouse.WAREID;
                    txtWareID.ReadOnly = true;
                    txtWareName.Text = wareHouse.NAME;
                    btnManager.Tag = wareHouse.MANAGER;
                    txtPlace.Text = wareHouse.PLACE;
                    switchIsEnable.Checked = wareHouse.ISENABLE == 1 ? true : false;
                    coreUser user = autofacConfig.coreUserService.GetUserByID(wareHouse.MANAGER);
                    btnManager.DefaultValue = new string[] { wareHouse.MANAGER };
                }
                else if (isCreate)
                {
                   //btnManager.Text = "   > ";
                    switchIsEnable.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}