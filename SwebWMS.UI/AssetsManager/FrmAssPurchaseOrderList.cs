using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssPurchaseOrderList : Swebui.Controls.SwebUserControl
    {
        public FrmAssPurchaseOrderList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        internal int type = 0;   // 0-资产,1-耗材
        internal int orderType = 0;     //0-采购订单,1-销售订单
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssPurchaseOrderCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "采购中")
                    {
                        FrmAssPurchaseOrderCreate frmAssetsSalesOrderCreate = new FrmAssPurchaseOrderCreate();
                        frmAssetsSalesOrderCreate.Flex = 1;
                        frmAssetsSalesOrderCreate.isEdit = true;
                        frmAssetsSalesOrderCreate.POID = args.SelectedRows[0]["POID"].ToString();
                        this.Parent.Controls.Add(frmAssetsSalesOrderCreate);
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
                    FrmAssPurchaseOrderDetail orderDetail = new FrmAssPurchaseOrderDetail();
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
            this.Parent.Controls.Add(new FrmAssPurchaseOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmAssPurchaseOrderList_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable asspoList = autofacConfig.AssPurchaseOrderService.GetOrders("");
                gridView1.DataSource = asspoList;
                gridView1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

    }
}