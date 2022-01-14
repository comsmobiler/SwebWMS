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
    partial class FrmConsumables : Swebui.Controls.SwebUserControl
    {
        public FrmConsumables() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion
        /// <summary>
        /// 页面初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConsumables_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable conTable = _autofacConfig.consumablesService.GetConList();
                gridView1.DataSource = conTable;
                gridView1.DataBind();
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 新增按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConsumablesCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 编辑按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmConsumablesDetailEdit assetsEdit = new FrmConsumablesDetailEdit();
                    assetsEdit.Flex = 1;
                    assetsEdit.CID = args.SelectedRows[0]["CID"].ToString();
                    this.Parent.Controls.Add(assetsEdit);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 查看按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmConsumablesDetail assetsEdit = new FrmConsumablesDetail();
                    assetsEdit.Flex = 1;
                    assetsEdit.CID = args.SelectedRows[0]["CID"].ToString();
                    this.Parent.Controls.Add(assetsEdit);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable conTable = _autofacConfig.consumablesService.GetConList();
                gridView1.Reload(conTable);
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }

    }
}