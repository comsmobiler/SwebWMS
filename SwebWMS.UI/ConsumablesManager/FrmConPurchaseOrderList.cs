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
    partial class FrmConPurchaseOrderList : Swebui.Controls.SwebUserControl
    {
        public FrmConPurchaseOrderList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConPurchaseOrderCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "采购中")
                    {
                        FrmConPurchaseOrderCreate orderCreate = new FrmConPurchaseOrderCreate();
                        orderCreate.Flex = 1;
                        orderCreate.POID = args.SelectedRows[0]["POID"].ToString();
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

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmConPurchaseOrderDetail orderDetail = new FrmConPurchaseOrderDetail();
                    orderDetail.Flex = 1;
                    orderDetail.POID = args.SelectedRows[0]["POID"].ToString();
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
            this.Parent.Controls.Add(new FrmConPurchaseOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmConPurchaseOrderList_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable salesOrders = autofacConfig.ConPurchaseOrderService.GetOrders();
                gridView1.DataSource = salesOrders;
                gridView1.DataBind();

            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}