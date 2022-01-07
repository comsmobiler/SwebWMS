using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConSaleOrderList : Swebui.Controls.SwebUserControl
    {
        public FrmConSaleOrderList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        /// <summary>
        /// 新增按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConSaleOrderCreate() { Flex = 1 });
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
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "销售中")
                    {
                        FrmConSaleOrderCreate orderCreate = new FrmConSaleOrderCreate();
                        orderCreate.Flex = 1;
                        orderCreate.SOID = args.SelectedRows[0]["SOID"].ToString();
                        this.Parent.Controls.Add(orderCreate);
                        this.Parent.Controls.RemoveAt(0);
                    }
                    else
                    {
                        Toast("当前订单不允许编辑！");
                    }
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
                    FrmConSaleOrderDetail orderDetail = new FrmConSaleOrderDetail();
                    orderDetail.Flex = 1;
                    orderDetail.SOID = args.SelectedRows[0]["SOID"].ToString();
                    this.Parent.Controls.Add(orderDetail);
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
            this.Parent.Controls.Add(new FrmConSaleOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConSaleOrderList_Load(object sender, EventArgs e)
        {
            try {
                DataTable salesOrders = autofacConfig.ConSalesOrderService.GetOrders();
                gridView1.DataSource = salesOrders;
                gridView1.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}