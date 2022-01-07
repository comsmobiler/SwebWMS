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
    partial class FrmAssTemplate : Swebui.Controls.SwebUserControl
    {
        public FrmAssTemplate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectTemplateId;  //当前选择的模板
        private string Type;        //资产大类
        #endregion

        private void FrmAssTemplate_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.GetAllTemplate();
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
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {

                DataTable table = _autofacConfig.SettingService.GetAllTemplate();
                if (table.Rows.Count > 0)
                {
                       gridView1.Reload( table);
               
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssTemplateCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                        FrmAssTemplateCreate orderCreate = new FrmAssTemplateCreate();
                        orderCreate.Flex = 1;
                        orderCreate.TempId = args.SelectedRows[0]["TEMPLATEID"].ToString();
                        this.Parent.Controls.Add(orderCreate);
                        this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmAssTemplateDetial orderDetail = new FrmAssTemplateDetial();
                    orderDetail.Flex = 1;
                    orderDetail.TempId = args.SelectedRows[0]["TEMPLATEID"].ToString();
                    this.Parent.Controls.Add(orderDetail);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssTemplate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }
        private void SearchData()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.QueryAssTemplates(txtNote.Text, Type);
               
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["TEMPLATEID"].ToString() == SelectTemplateId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                 gridView1.Reload(table);
            }

            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}