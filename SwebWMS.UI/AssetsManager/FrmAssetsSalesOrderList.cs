using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssetsSalesOrderList : Swebui.Controls.SwebUserControl
    {
        public FrmAssetsSalesOrderList() : base()
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
            this.Parent.Controls.Add(new FrmAssetsSalesOrderCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "销售中")
                    {
                        FrmAssetsSalesOrderCreate frmAssetsSalesOrderCreate = new FrmAssetsSalesOrderCreate();
                        frmAssetsSalesOrderCreate.Flex = 1;
                        frmAssetsSalesOrderCreate.isEdit = true;
                        frmAssetsSalesOrderCreate.SOID = args.SelectedRows[0]["SOID"].ToString();
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
                    FrmAssetsSalesOrderDetail orderDetail = new FrmAssetsSalesOrderDetail();
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssetsSalesOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmAssetsSalesOrderList_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            DataTable asssoList = autofacConfig.AssSalesOrderService.GetOrders("");
            gridView1.DataSource = asssoList;
            gridView1.DataBind();


        }
    }
}