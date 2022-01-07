using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    partial class FrmWarehouse : Swebui.Controls.SwebUserControl
    {
        public FrmWarehouse() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion


        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            Bind();

            GetContent(treeView1.Nodes[0].TreeID);
            treeView1.DefaultValue = new string[] { treeView1.Nodes[0].TreeID };
        }
        /// <summary>
        /// treeview数据绑定
        /// </summary>
        internal void Bind()
        {
            treeView1.Nodes.Clear();
            List<WareHouse> wareHousList = autofacConfig.wareHouseService.GetAllWareHouse();
            foreach (WareHouse wareHouse in wareHousList)
            {
                TreeViewNode firstNode = new TreeViewNode("F" + wareHouse.WAREID, wareHouse.NAME);
                List<WHStorageType> WHSTlist = autofacConfig.wareHouseService.GetSTByWareID(wareHouse.WAREID);
                foreach (WHStorageType wHStorageType in WHSTlist)
                {
                    TreeViewNode secondNode = new TreeViewNode("S" + wHStorageType.STID + "FID " + wareHouse.WAREID, wHStorageType.NAME);
                    firstNode.Nodes.Add(secondNode);
                }
                treeView1.Nodes.Add(firstNode);
            }

        }


        /// <summary>
        /// treeview 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_Press(object sender, TreeViewOnPressEventArgs e)
        {
            GetContent(e.TreeID);
        }

        private void GetContent(string treeid)
        {//仓库
            if (treeid.Substring(0, 1) == "F")
            {
                panel4.Visible = true;
                WHSLPanel.Visible = labPanel.Visible = panel5.Visible = false;
                string whid = treeid.Substring(1);
                WareHouse wareHouse = autofacConfig.wareHouseService.GetByWareID(whid);
                txtWareID.Text = wareHouse.WAREID;
                txtWareName.Text = wareHouse.NAME;
                btnManager.Tag = wareHouse.MANAGER;
                coreUser user = autofacConfig.coreUserService.GetUserByID(wareHouse.MANAGER);
                btnManager.Text = user.USER_NAME;
                //   btnManager.
                txtPlace.Text = wareHouse.PLACE;
                switchIsEnable.Checked = wareHouse.ISENABLE == 1 ? true : false;
                editBtn.Text = "编辑仓库";
                addTypeBtn.Visible = true;
                labTitle.Text = "仓库信息";
            }
           //存储分类
            else 
            {
                panel4.Visible = false;
                WHSLPanel.Visible = labPanel.Visible = panel5.Visible = true;
                addTypeBtn.Visible = false;
                labTitle.Text = "存储类别信息";
                editBtn.Text = "编辑分类";
                int index = treeid.LastIndexOf("FID ");
                string WareID = treeid.Substring(index + 4);
                string stid = treeid.Substring(1, index - 1);
                WareHouse wareHouse = autofacConfig.wareHouseService.GetByWareID(WareID);
                if (wareHouse != null)
                {
                    txtWareID1.Text = wareHouse.WAREID;
                    txtWareName1.Text = wareHouse.NAME;
                }
                WHStorageTypeOutputDto whStorageType = autofacConfig.wareHouseService.GetSTByWareIDandSTID(WareID, stid);
                if (whStorageType != null)
                {
                    txtSTID.Text = whStorageType.STID;
                    txtSTName.Text = whStorageType.NAME;
                    tpSswitchIsEnable.Checked = whStorageType.ISENABLE == 1 ? true : false;
                }
                WHSLPanel.Controls.Clear();
                List<WHStorageLocation> whslList = autofacConfig.wareHouseService.GetSLByWareIDAndSTID(WareID, stid);
                if (whslList != null)
                {

                    foreach (WHStorageLocation wHStorage in whslList)
                    {
                        WHSLPanel.Controls.Add(new WHLLayout(wHStorage.WAREID, wHStorage.STID, wHStorage.SLID, wHStorage.NAME, wHStorage.ISENABLE));
                    }
                }
            }
        }
        /// <summary>
        /// 新增库位按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            WHLCreateDialog dialog = new WHLCreateDialog();
            dialog.isCreate = true;
            dialog.WareID = txtWareID1.Text;
            dialog.STID = txtSTID.Text;
            this.ShowDialog(dialog, (obj, args) =>
            {
                if (dialog.ShowResult == ShowResult.Yes)
                {
                    #region"刷新库位列表"
                    WHSLPanel.Controls.Clear();
                    List<WHStorageLocation> whslList = autofacConfig.wareHouseService.GetSLByWareIDAndSTID(txtWareID1.Text, txtSTID.Text);
                    if (whslList != null)
                    {
                        foreach (WHStorageLocation wHStorage in whslList)
                        {
                            WHSLPanel.Controls.Add(new WHLLayout(wHStorage.WAREID, wHStorage.STID, wHStorage.SLID, wHStorage.NAME, wHStorage.ISENABLE));
                        }
                    }
                    #endregion
                }
            });
        }
        /// <summary>
        /// 新增类别 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTypeBtn_Click(object sender, EventArgs e)
        {
            WHTypeCreateDialog dialog = new WHTypeCreateDialog();
            dialog.isCreate = true;
            dialog.WareID = txtWareID.Text;
            ShowDialog(dialog, (obj, args) =>
            {
                if (dialog.ShowResult == ShowResult.Yes)
                {
                    Bind();
                    GetContent("F" + dialog.WareID);
                    treeView1.DefaultValue = new string[] { "F" + dialog.WareID };
                }
            });
        }

        /// <summary>
        /// 仓库/分类编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Text == "编辑仓库")
            {
                WarehouseCreateDialog dialog = new WarehouseCreateDialog();
                dialog.isEdit = true;
                dialog.WareID = txtWareID.Text;
                ShowDialog(dialog, (obj, args) =>
                {
                    if (dialog.ShowResult == ShowResult.Yes)
                    {
                        Bind();
                        GetContent("F" + dialog.WareID);
                        treeView1.DefaultValue = new string[] { "F" + dialog.WareID };
                    }
                });
            }
            else
            {
                WHTypeCreateDialog dialog = new WHTypeCreateDialog();
                dialog.isEdit = true;
                dialog.WareID = txtWareID1.Text;
                dialog.STID = txtSTID.Text;
                ShowDialog(dialog, (obj, args) =>
                {
                    if (dialog.ShowResult == ShowResult.Yes)
                    {
                        Bind();
                        GetContent("S" + dialog.STID + "FID " + dialog.WareID);
                        treeView1.DefaultValue = new string[] { "S" + dialog.STID + "FID " + dialog.WareID };
                    }
                });
            }
        }
        /// <summary>
        /// 新增仓库 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            WarehouseCreateDialog dialog = new WarehouseCreateDialog();
            dialog.isCreate = true;
            ShowDialog(dialog, (obj, args) =>
            {
                if (dialog.ShowResult == ShowResult.Yes)
                {
                    Bind();
                    GetContent(treeView1.Nodes[0].TreeID);
                    treeView1.DefaultValue = new string[] { treeView1.Nodes[0].TreeID };
                }
            });
        }
        /// <summary>
        /// 仓库启用/禁用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchIsEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIsEnable.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(txtWareID.Text, null, null, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用仓库成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(txtWareID.Text, null, null, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用仓库成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 存储类型启用/禁用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpSswitchIsEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (tpSswitchIsEnable.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(txtWareID1.Text,txtSTID.Text,null, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用存储类型成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(txtWareID1.Text, txtSTID.Text, null, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用存储类型成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}