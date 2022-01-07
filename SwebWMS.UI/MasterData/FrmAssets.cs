using SMOWMS.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssets : Swebui.Controls.SwebUserControl
    {
        public FrmAssets() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectAssId;  //当前选择的资产
        private string Type;        //资产大类
        private string UserId;
        internal String wareId;    //所选仓库编号
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssetsCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void FrmAssets_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                Bind();
                ///
                tpSearch.Nodes.Add(new  TreeSelectNode("all", "全部"));
                List<AssetsType> types = _autofacConfig.assTypeService.GetAllFirstLevel();
                foreach (AssetsType Row in types)
                {
                    tpSearch.Nodes.Add(new  TreeSelectNode (Row.TYPEID, Row.NAME));
                }
                if (Type != null)   //如果已有选中项，则显示选中效果
                {
                    tpSearch.DefaultValue = new string[] { Type};
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.GetAllAss(wareId);
               
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridView1.DataSource = table;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

    
        private void SearchData()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.QueryAssets(txtNote.Text, Type);
              
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridPanel.Visible = true;
                    lblinfo.Visible = false;
                    gridView1.DataSource = table;
                    gridView1.DataBind();

                }
                else
                {
                    gridPanel.Visible = false;
                    lblinfo.Visible = true;
                }
            }

            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void txtNote_SubmitEditing(object sender, EventArgs e)
        {
            SearchData();
        }

        private void tpSearch_Press(object sender, TreeSelectPressEventArgs args)
        {
            Type = args.TreeID;
            SearchData();
        }
    }
}