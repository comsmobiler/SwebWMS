using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class WHLCreateDialog : Swebui.Controls.SwebUserControl
    {
        public WHLCreateDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        public String WareID;    //仓库编号
        public Boolean isCreate;     //页面是否为创建状态
        public Boolean isEdit;       //页面是否为编辑状态
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public string STID;
        public string SLID;
        #endregion
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSLID.Text)) throw new Exception("库位编号不能为空");
                if (String.IsNullOrEmpty(txtSLName.Text)) throw new Exception("库位名称不能为空");
                if (btnManager.Tag == null) throw new Exception("负责人不能为空");

                WHStorageLocationInputDto inputDto = new WHStorageLocationInputDto
                {
                    SLID = txtSLID.Text,
                    WAREID = txtWareID.Text,
                    STID = txtSTID.Text,
                    NAME = txtSLName.Text,
                    MANAGER = btnManager.Tag.ToString(),
                    MAXVOLUME = txtMAXVOLUME.Text,
                    MAXCAPACITY = txtMAXCAPACITY.Text,
                    MODIFYUSER = Client.Session["UserID"].ToString()
                };
                if (isCreate)
                {
                    inputDto.CREATEUSER = Client.Session["UserID"].ToString();
                    inputDto.STATUS = 0;
                    //添加
                    ReturnInfo rInfo = autofacConfig.wareHouseService.AddWhStorageLocation(inputDto);
                    if (rInfo.IsSuccess)
                    {

                        Toast("创建库位成功");
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }
                else if (isEdit)
                {
                    //编辑
                    ReturnInfo rInfo = autofacConfig.wareHouseService.UpdateWhStorageLocation(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        Toast("编辑库位成功");
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
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
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }

        private void WHLCreateDialog_Load(object sender, EventArgs e)
        {
            try
            {
                List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
                foreach (coreUser Row in users)
                {
                    btnManager.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
                }
                WHStorageTypeOutputDto whStorageType = autofacConfig.wareHouseService.GetSTByWareIDandSTID(WareID, STID);
                txtWareID.Text = whStorageType.WAREID;
                txtWareName.Text = whStorageType.WARENAME;
                txtSTID.Text = whStorageType.STID;
                txtSTName.Text = whStorageType.NAME;
                if (isEdit)
                {
                    label1.Text = "编辑库位";
                    WHStorageLocationOutputDto whStorageLocation = autofacConfig.wareHouseService.GetSLByID(WareID, STID, SLID);
                    txtSLID.Text = whStorageLocation.SLID;
                    txtSLID.ReadOnly = true;
                    txtSLName.Text = whStorageLocation.SLNAME;
                    btnManager.Tag = whStorageLocation.MANAGER;
                    btnManager.DefaultValue = new string[] { whStorageLocation.MANAGER };
                    txtMAXCAPACITY.Text = whStorageLocation.MAXCAPACITY;
                    txtMAXVOLUME.Text = whStorageLocation.MAXVOLUME;
                }

            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }

        private void btnManager_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnManager.Tag = args.TreeID;
        }
    }
}