using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    partial class FrmAssetsType : Swebui.Controls.SwebUserControl
    {
        public FrmAssetsType() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        private string SelectID;
        #endregion

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssetsType_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                treeView1.DefaultValue = new string[] { treeView1.Nodes[0].TreeID };
                SelectID = treeView1.Nodes[0].TreeID;
                GetContent(treeView1.Nodes[0].TreeID);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定treeview
        /// </summary>
        private void Bind()
        {
            treeView1.Nodes.Clear();
            List<AssetsType> assetsTypeList = autofacConfig.assTypeService.GetAllFirstLevel();
            if (assetsTypeList != null)
            {
                foreach (AssetsType firstType in assetsTypeList)
                {
                    TreeViewNode firstNode = new TreeViewNode(firstType.TYPEID, firstType.NAME);
                    List<AssetsType> assetsTypeListSecond = autofacConfig.assTypeService.GetByLevelAndParentId(2, firstType.TYPEID);
                    if (assetsTypeListSecond != null)
                    {
                        foreach (AssetsType secondType in assetsTypeListSecond)
                        {
                            TreeViewNode secondNode = new TreeViewNode(secondType.TYPEID, secondType.NAME);
                            List<AssetsType> assetsTypeListThird = autofacConfig.assTypeService.GetByLevelAndParentId(3, secondType.TYPEID);
                            if (assetsTypeListThird != null)
                            {
                                foreach (AssetsType thirdType in assetsTypeListThird)
                                {
                                    TreeViewNode thirdNode = new TreeViewNode(thirdType.TYPEID, thirdType.NAME);
                                    secondNode.Nodes.Add(thirdNode);
                                }
                            }
                            firstNode.Nodes.Add(secondNode);
                        }
                    }
                    treeView1.Nodes.Add(firstNode);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_Press(object sender, TreeViewOnPressEventArgs e)
        {
            GetContent(e.TreeID);
            SelectID = e.TreeID;
        }
        private void GetContent(string typeid)
        {
            AssetsType assetsType = autofacConfig.assTypeService.GetByID(typeid);
            if (assetsType.TLEVEL == 1)
            {
                Fpanel.Visible = true;
                SPanel.Visible = false;
                txtID.Text = assetsType.TYPEID;
                txtName.Text = assetsType.NAME;
                txtDate.Text = assetsType.EXPIRYDATE.ToString();
                switchIsEnable.Checked = assetsType.ISENABLE == 1 ? true : false;
                editBtn.Text = "编辑父类";
                addTypeBtn.Visible = true;
            }
            else
            {
                if (assetsType.TLEVEL >= 3)
                    addTypeBtn.Visible = false;
                else
                    addTypeBtn.Visible = true;
                editBtn.Text = "编辑子类";
                Fpanel.Visible = false;
                SPanel.Visible = true;
                txtID1.Text = assetsType.TYPEID;
                txtName1.Text = assetsType.NAME;
                txtDate1.Text = assetsType.EXPIRYDATE.ToString();
                switchIsEnable1.Checked = assetsType.ISENABLE == 1 ? true : false;
                AssetsType fType = autofacConfig.assTypeService.GetByID(assetsType.PARENTTYPEID);
                txtFID.Text = fType.TYPEID;
                txtFName.Text = fType.NAME;
                txtFDate.Text = fType.EXPIRYDATE.ToString();
            }
        }
       /// <summary>
       /// 编辑按钮
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            AssetsTypeCreateDialog dialog = new AssetsTypeCreateDialog();
            dialog.isCreateSon = false;
            dialog.isEdit = true;
            if (editBtn.Text == "编辑父类")
                dialog.ID = txtID.Text;
            else
                dialog.ID = txtID1.Text;
            this.ShowDialog(dialog, (obj, args) =>
            {
                if (dialog.ShowResult == ShowResult.Yes)
                {
                    //Bind();
                    GetContent(dialog.ID);
                    treeView1.DefaultValue = new string[] { dialog.ID };
                }
            });
        }
        /// <summary>
        /// 新增父类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AssetsTypeCreateDialog dialog = new AssetsTypeCreateDialog();
            dialog.isCreateSon = false;
            dialog.isCreate = true;
            this.ShowDialog(dialog, (obj, args) =>
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
        /// 新增子类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTypeBtn_Click(object sender, EventArgs e)
        {
            AssetsTypeCreateDialog dialog = new AssetsTypeCreateDialog();
            dialog.isCreateSon = true;
            dialog.isCreate = true;
            dialog.ID =SelectID;
            this.ShowDialog(dialog, (obj, args) =>
            {

                if (dialog.ShowResult == ShowResult.Yes)
                {
                    Bind();
                    GetContent(dialog.ID);
                    treeView1.DefaultValue = new string[] { dialog.ID };
                }
            });
        }
        /// <summary>
        /// 启用/禁用父级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchIsEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIsEnable.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID.Text, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用分类成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID.Text, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用分类成功");
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
        /// 启用/禁用子级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchIsEnable1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIsEnable1.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID1.Text, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用分类成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID1.Text, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用分类成功");
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