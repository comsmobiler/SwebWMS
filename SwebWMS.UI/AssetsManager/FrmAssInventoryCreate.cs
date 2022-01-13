using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssInventoryCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAssInventoryCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID;//盘点编号
        #endregion
        private void FrmAssInventoryCreate_Load(object sender, EventArgs e)
        {
            try
            {
                #region 获取盘点人
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                if (users != null && users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        btnManager.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                    }
                }
                #endregion

                #region 获取仓库

                var whlist = _autofacConfig.wareHouseService.GetAllWareHouse();
                if (whlist != null && whlist.Count > 0)
                {
                    foreach (var ware in whlist)
                    {
                        btnWareHouse.Nodes.Add(new TreeSelectNode(ware.WAREID, ware.NAME));
                    }
                }
                #endregion

                #region"获取类别"
                List<AssetsType> Data = _autofacConfig.assTypeService.GetAll();
                if (Data != null && Data.Count > 0)
                {
                    foreach (var type in Data)
                    {
                        if (type.TLEVEL == 1)
                        {
                            TreeSelectNode firstNode = new TreeSelectNode(type.TYPEID, type.NAME);
                            foreach (var type1 in Data)
                            {
                                if (string.IsNullOrEmpty(type1.PARENTTYPEID) == false && type1.PARENTTYPEID == type.TYPEID.ToString())
                                {
                                    TreeSelectNode secondNode = new TreeSelectNode(type1.TYPEID, type1.NAME);
                                    foreach (var type2 in Data)
                                    {
                                        if (string.IsNullOrEmpty(type2.PARENTTYPEID) == false && type2.PARENTTYPEID == type1.TYPEID.ToString())
                                        {
                                            TreeSelectNode Node = new TreeSelectNode(type2.TYPEID, type2.NAME);
                                            secondNode.Nodes.Add(Node);
                                        }
                                    }
                                    firstNode.Nodes.Add(secondNode);
                                }
                            }
                            btnType.Nodes.Add(firstNode);
                        }
                    }
                }
                #endregion

                #region 编辑初始
                if (string.IsNullOrEmpty(IID) == false)
                {
                    labTitle.Text = "编辑资产盘点单";
                    DeleteBtn.Visible = true;
                    lblIID.Text = IID;
                    var assInventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                    txtName.Text = assInventory.NAME;
                    btnManager.DefaultValue = new string[] { assInventory.HANDLEMAN };
                    btnWareHouse.DefaultValue = new string[] { assInventory.WAREID };
                    btnManager.Tag = assInventory.HANDLEMAN;
                    btnWareHouse.Tag = assInventory.WAREID;
                    btnType.Tag = assInventory.TYPEID;
                    btnST.Tag = assInventory.STID;
                    btnSL.Tag = assInventory.SLID;
                    //  获取存储类型
                    var stlist = _autofacConfig.wareHouseService.GetSTByWareID(btnWareHouse.Tag.ToString());
                    if (stlist != null && stlist.Count > 0)
                    {
                        btnST.Nodes.Add(new TreeSelectNode("", "全部"));
                        foreach (var st in stlist)
                        {
                            btnST.Nodes.Add(new TreeSelectNode(st.STID, st.NAME));
                        }
                    }
                    if (string.IsNullOrEmpty(assInventory.STID))
                    {
                        btnSL.Nodes.Add(new TreeSelectNode("", "全部"));
                        btnST.DefaultValue = new string[] { "" };
                    }
                    else
                    {
                        btnST.DefaultValue = new string[] { assInventory.STID };
                        //获取库位
                        var sllist = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(), btnST.Tag.ToString());
                        btnSL.Nodes.Add(new TreeSelectNode("", "全部"));
                        if (sllist != null && sllist.Count > 0)
                        {

                            foreach (var sl in sllist)
                            {
                                btnSL.Nodes.Add(new TreeSelectNode(sl.SLID, sl.NAME));
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(assInventory.SLID))
                    {
                        btnSL.DefaultValue = new string[] { "" };
                    }
                    else
                    {
                        btnSL.DefaultValue = new string[] { assInventory.SLID };
                    }
                    if (string.IsNullOrEmpty(assInventory.TYPEID))
                    {
                        btnType.DefaultValue = new string[] { "" };
                    }
                    else
                    {
                        btnType.DefaultValue = new string[] { assInventory.TYPEID };
                    }
                

                }
                #endregion
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
            this.Parent.Controls.Add(new FrmAssInventory() { Flex = 1 });
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
                if (btnManager.Tag == null) throw new Exception("请选择盘点人！");
                if (btnWareHouse.Tag == null) throw new Exception("请选择仓库！");
                if (btnType.Tag == null) throw new Exception("请选择资产类型！");
                string typeId = "";
                string stId = "";
                string slId = "";
                if (btnType.Tag != null)
                {
                    typeId = btnType.Tag.ToString();
                }
                if (btnST.Tag != null)
                {
                    stId = btnST.Tag.ToString();
                }
                if (btnSL.Tag != null)
                {
                    slId = btnSL.Tag.ToString();
                }
                if (string.IsNullOrEmpty(IID))
                {
                    AssInventoryInputDto assInventoryInput = new AssInventoryInputDto()
                    {
                        HANDLEMAN = btnManager.Tag.ToString(),
                        CREATEUSER = Client.Session["UserId"].ToString(),
                        //                    LOCATIONID = LocationId,
                        TYPEID = typeId,
                        //                    DEPARTMENTID = DepId,
                        IsEnd = false,
                        MODIFYUSER = Client.Session["UserId"].ToString(),
                        WAREID = btnWareHouse.Tag.ToString(),
                        STID = stId,
                        SLID = slId,
                        NAME = txtName.Text
                    };
                    ReturnInfo returnInfo = _autofacConfig.AssInventoryService.AddAssInventory(assInventoryInput);
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
                else
                {
                    AddAIResultInputDto assInventoryInput = new AddAIResultInputDto()
                    {
                        IID = IID,
                        HANDLEMAN = btnManager.Tag.ToString(),
                        typeId = typeId,
                        WAREID = btnWareHouse.Tag.ToString(),
                        STID = stId,
                        SLID = slId,
                        UserId = Client.Session["UserId"].ToString(),
                        Name = txtName.Text
                    };
                    ReturnInfo returnInfo = _autofacConfig.AssInventoryService.UpdateInventoryOnly(assInventoryInput);
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
       /// <summary>
       /// 删除按钮事件
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo rInfo = _autofacConfig.AssInventoryService.DeleteInventory(IID);
                if (rInfo.IsSuccess)
                {
                    Toast("删除盘点单成功.");
                    BackBtn_Click(null,null);
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

        private void btnWareHouse_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                btnWareHouse.Tag = args.TreeID;
                btnST.Nodes.Clear();
                if (btnWareHouse.Tag == null)
                {
                    throw new Exception("请先选择仓库！");
                }
                var stlist = _autofacConfig.wareHouseService.GetSTByWareID(btnWareHouse.Tag.ToString());
                if (stlist != null && stlist.Count > 0)
                {
                    btnST.Nodes.Add(new TreeSelectNode("", "全部"));
                    foreach (var st in stlist)
                    {
                        btnST.Nodes.Add(new TreeSelectNode(st.STID, st.NAME));
                    }
                }
                btnST.Tag = null;
                btnST.DefaultValue = new string[] { };
                btnSL.Nodes.Clear();
                btnSL.Tag = null;
                btnSL.DefaultValue = new string[] { };
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnST_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                btnST.Tag = args.TreeID;
                btnSL.Nodes.Clear();
                if (btnWareHouse.Tag == null)
                {
                    throw new Exception("请先选择仓库！");
                }
                if (btnST.Tag == null)
                {
                    throw new Exception("请先选择存储类型！");
                }
                var sllist = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(), btnST.Tag.ToString());
                btnSL.Nodes.Add(new TreeSelectNode("", "全部"));
                if (sllist != null && sllist.Count > 0)
                {

                    foreach (var sl in sllist)
                    {
                        btnSL.Nodes.Add(new TreeSelectNode(sl.SLID, sl.NAME));
                    }
                }
                if (args.TreeID == "")
                {
                    btnSL.Tag = "";
                    btnSL.DefaultValue = new string[] { "" };
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnSL_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnSL.Tag = args.TreeID;
        }

        private void btnManager_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnManager.Tag = args.TreeID;
        }

        private void btnType_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnType.Tag = args.TreeID;
        }
    }
}