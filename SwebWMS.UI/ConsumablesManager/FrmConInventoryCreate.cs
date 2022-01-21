using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConInventoryCreate : Swebui.Controls.SwebUserControl
    {
        public FrmConInventoryCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID;
        private string UserId;
        #endregion
        private void FrmConInventoryCreate_Load(object sender, EventArgs e)
        {
            try
            {
                ///绑定仓库
                List<WareHouse> WHS = _autofacConfig.wareHouseService.GetAllWareHouse();
                if (WHS != null && WHS.Count > 0)
                {
                    foreach (var ware in WHS)
                    {
                        btnWareHouse.Nodes.Add(new TreeSelectNode(ware.WAREID, ware.NAME));
                    }
                }
                ///绑定盘点人
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                if (users != null && users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        btnManager.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                    }
                }
                UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOWMSAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    String LocationId = user.USER_LOCATIONID;
                    var location = _autofacConfig.wareHouseService.GetByWareID(LocationId);

                    btnWareHouse.Tag = LocationId;
                    btnManager.DefaultValue = new string[] { LocationId };
                    btnWareHouse.Disabled = true;
                }
                ///编辑初始化
                if (string.IsNullOrEmpty(IID) == false)
                {
                    labTitle.Text = "编辑耗材盘点单";
                    DeleteBtn.Visible = true;
                    var assInventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                    txtName.Text = assInventory.NAME;
                    btnManager.Tag = assInventory.HANDLEMAN;
                    btnManager.DefaultValue = new string[] { assInventory.HANDLEMAN };
                    btnWareHouse.Tag = assInventory.WAREID;
                    btnWareHouse.DefaultValue = new string[] { assInventory.WAREID };

                    List<WHStorageType> WHST = _autofacConfig.wareHouseService.GetSTByWareID(btnWareHouse.Tag.ToString());
                    btnST.Nodes.Add(new TreeSelectNode("", "全部"));
                    if (WHST != null && WHST.Count > 0)
                    {
                        foreach (var st in WHST)
                        {
                            btnST.Nodes.Add(new TreeSelectNode(st.STID, st.NAME));
                        }
                    }
                    btnSL.Nodes.Add(new TreeSelectNode("", "全部"));
                    if (string.IsNullOrEmpty(assInventory.STID))
                    {
                        btnST.Tag = "";
                        btnST.DefaultValue = new string[] { "" };
                    }
                    else
                    {
                        btnST.Tag = assInventory.STID;
                        btnST.DefaultValue = new string[] { assInventory.STID };
                        List<WHStorageLocation> WHSL = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(), btnST.Tag.ToString());
                        if (WHSL != null && WHSL.Count > 0)
                        {
                            foreach (WHStorageLocation Row in WHSL)
                            {
                                btnSL.Nodes.Add(new TreeSelectNode(Row.SLID, Row.NAME));
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(assInventory.SLID))
                    {
                        btnSL.Tag = "";
                        btnSL.DefaultValue = new string[] { "" };
                    }
                    else
                    {
                        btnSL.Tag = assInventory.SLID;
                        btnSL.DefaultValue = new string[] { assInventory.SLID };
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConInventory() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("盘点单名称不能为空!");
                if (btnManager.Tag == null) throw new Exception("盘点人不能为空!");
                if (btnWareHouse.Tag == null) throw new Exception("仓库不能为空!");
                if (string.IsNullOrEmpty(IID))//新增
                {
                    ConInventoryInputDto conInventoryInput = new ConInventoryInputDto()
                    {
                        HANDLEMAN = btnManager.Tag.ToString(),
                        CREATEUSER = UserId,
                        WAREID = btnWareHouse.Tag.ToString(),
                        IsEnd = false,
                        MODIFYUSER = UserId,
                        NAME = txtName.Text
                    };
                    if (btnST.Tag != null)
                        conInventoryInput.STID = btnST.Tag.ToString();
                    if (btnSL.Tag != null)
                        conInventoryInput.SLID = btnSL.Tag.ToString();

                    ReturnInfo returnInfo = _autofacConfig.ConInventoryService.AddConInventory(conInventoryInput);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("添加成功");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }
                else //编辑
                {
                    AddCIResultInputDto conInventoryInput = new AddCIResultInputDto()
                    {
                        IID = IID,
                        HANDLEMAN = btnManager.Tag.ToString(),
                        WAREID = btnWareHouse.Tag.ToString(),
                        UserId = Client.Session["UserID"].ToString(),
                        Name = txtName.Text
                    };
                    if (btnST.Tag != null)
                        conInventoryInput.STID = btnST.Tag.ToString();
                    if (btnSL.Tag != null)
                        conInventoryInput.SLID = btnSL.Tag.ToString();

                    ReturnInfo returnInfo = _autofacConfig.ConInventoryService.UpdateInventoryOnly(conInventoryInput);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("修改成功");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo rInfo = _autofacConfig.ConInventoryService.DeleteInventory(IID);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("删除盘点单成功.");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 盘点人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnManager_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnManager.Tag = args.TreeID;
        }
        /// <summary>
        /// 仓库选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnWareHouse_Press_1(object sender, TreeSelectPressEventArgs args)
        {
            btnWareHouse.Tag = args.TreeID;
            btnST.Nodes.Clear();
            btnSL.Nodes.Clear();
            btnST.DefaultValue=btnSL.DefaultValue = new string[0];
            btnSL.Tag = btnST.Tag = null;
            List<WHStorageType> WHST = _autofacConfig.wareHouseService.GetSTByWareID(btnWareHouse.Tag.ToString());
            btnST.Nodes.Add(new TreeSelectNode("", "全部"));
            if (WHST != null && WHST.Count > 0)
            {
                foreach (var st in WHST)
                {
                    btnST.Nodes.Add(new TreeSelectNode(st.STID, st.NAME));
                }
            }
        }
        /// <summary>
        /// 存储类型选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnST_Press_1(object sender, TreeSelectPressEventArgs args)
        {
            btnST.Tag = args.TreeID;
            btnSL.Nodes.Clear();
            btnSL.Tag = null;
            btnSL.DefaultValue = new string[0];
            btnSL.Nodes.Add(new TreeSelectNode("", "全部"));
            List<WHStorageLocation> WHSL = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(), btnST.Tag.ToString());
            if (WHSL != null && WHSL.Count > 0)
            {
                foreach (WHStorageLocation Row in WHSL)
                {
                    btnSL.Nodes.Add(new TreeSelectNode(Row.SLID, Row.NAME));
                }
            }
        }
        /// <summary>
        /// 库位选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnSL_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnSL.Tag = args.TreeID;
        }
    }
}