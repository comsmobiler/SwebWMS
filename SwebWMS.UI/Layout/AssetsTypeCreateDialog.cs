using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class AssetsTypeCreateDialog : Swebui.Controls.SwebUserControl
    {
        public AssetsTypeCreateDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        public String ID;    //分类编号
        public Boolean isCreate;     //页面是否为创建状态
        public Boolean isEdit;       //页面是否为编辑状态
        public Boolean isCreateSon;  //页面是否为创建子分类 
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        private void switchIsEnable1_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text)) throw new Exception("分类编号不能为空");
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("分类名称不能为空");
                if (String.IsNullOrEmpty(txtDate.Text)) throw new Exception("年限不能为空");

                if (System.Text.RegularExpressions.Regex.IsMatch(txtDate.Text.Trim(), "^\\d+$") == false)
                {
                    throw new Exception("年限必须为数字");
                }
                AssetsType at = new AssetsType();
                if (isCreate == true || isCreateSon == true)        //新建分类
                {
                    AssetsType type = autofacConfig.assTypeService.GetByID(txtID.Text);
                    if (type != null) throw new Exception("该编号已存在");
                    at.TYPEID = txtID.Text;       //分类编号
                    at.NAME = txtName.Text;       //分类名称
                    at.EXPIRYDATE = Convert.ToInt32(txtDate.Text);   //分类有效日期
                    at.PARENTTYPEID = txtFID.Text;      //父分类编号
                    at.EXPIRYDATEUNIT = 1;              //默认为月
                    at.ISENABLE = 1;                    //启用
                    at.CREATEUSER = Client.Session["UserID"].ToString();
                    if (isCreate == true) at.TLEVEL = 1;       //分类级别
                    if (isCreateSon == true) at.TLEVEL = autofacConfig.assTypeService.GetByID(txtFID.Text).TLEVEL + 1;

                    ReturnInfo r = autofacConfig.assTypeService.AddAssetsType(at);
                    if (r.IsSuccess == true)
                    {
                        this.ShowResult = ShowResult.Yes;
                        this.Close();      //关闭创建弹出框
                        this.Form.Toast("创建资产分类成功");
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
                else if (isEdit == true)      //修改分类
                {
                    at.TYPEID = txtID.Text;           //分类编号
                    at.NAME = txtName.Text;          //分类名称
                    at.EXPIRYDATE = Convert.ToInt32(txtDate.Text);     //分类有效日期
                    at.PARENTTYPEID = txtFID.Text;              //父分类编号

                    ReturnInfo r = autofacConfig.assTypeService.UpdateAssetsType(at);
                    if (r.IsSuccess == true)
                    {
                        this.ShowResult = ShowResult.Yes;
                        this.Close();      //关闭创建弹出框
                        this.Form.Toast("资产分类信息修改成功");
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
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

        private void AssetsTypeCreateDialog_Load(object sender, EventArgs e)
        {
            try
            {
                AssetsType at = autofacConfig.assTypeService.GetByID(ID);
                if (isEdit == true)    //编辑此分类
                {
                    label1.Text = "编辑资产分类";
                    txtID.ReadOnly = true;
                    txtID.Text = at.TYPEID;             //分类编号
                    txtName.Text = at.NAME;             //分类名称
                    txtDate.Text = at.EXPIRYDATE.ToString();    //分类有效日期
                    if (String.IsNullOrEmpty(at.PARENTTYPEID) == false)        //如果有父类，则显示父类信息
                    {
                        FPanel.Visible = true;
                        AssetsType parentAt = autofacConfig.assTypeService.GetByID(at.PARENTTYPEID);
                        txtFID.Text = parentAt.TYPEID;       //父分类编号
                        txtFName.Text = parentAt.NAME;       //父分类名称
                        txtFDate.Text = parentAt.EXPIRYDATE.ToString();       //父分类有效日期
                    }
                }
                else if (isCreateSon == true)     //创建子分类
                {
                    FPanel.Visible = true;
                    txtFID.Text = at.TYPEID;    //父分类编号
                    txtFName.Text = at.NAME;    //父分类名称
                    txtFDate.Text = at.EXPIRYDATE.ToString();    //父分类有效日期
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}