using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConPurchaseOrderDetail : Swebui.Controls.SwebUserControl
    {
        public FrmConPurchaseOrderDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public string POID;        //耗材采购单号
        #endregion
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConPurchaseOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        private void FrmConPurchaseOrderDetail_Load(object sender, EventArgs e)
        {
            try
            { 
                ///表头信息
                ConPurchaseOrderOutputDto Order = autofacConfig.ConPurchaseOrderService.GetByPOID(POID);
                lblOrder.Text = POID;
                lblRealID.Text = Order.REALID;
                lblName.Text = Order.NAME;
                lblVendor.Text = Order.VENDORNAME;
                lblDealMan.Text = Order.PURCHASERNAME;
          //      lblStatus.Text = Order.STATUSNAME;
                //耗材行项信息
                List<ConPurAndSaleCreateInputDto> OrderRows = autofacConfig.ConPurchaseOrderService.GetOrderRows(POID);
                LoadRows(OrderRows);
       
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 编辑时加载明细
        /// </summary>
        public void LoadRows(List<ConPurAndSaleCreateInputDto> orderRows)
        {
            if (orderRows.Count > 0)
            {
                foreach (ConPurAndSaleCreateInputDto dto in orderRows)
                {
                    listPanel.Controls.Add(new ConSOAndPODetailLayout() {
                        NAME=dto.NAME,
                        ID = dto.CID, 
                        SaleNum = dto.QUANTPURCHASED.ToString(), 
                        Price = dto.REALPRICE.ToString(), 
                        Img = dto.IMAGE ,
                        AlreadyInOROut=dto.QUANTSTORED.ToString() ,
                        AlreadBack=dto.QUANTRETREATED.ToString(),
                        Status=((PurchaseOrderStatus)dto.STATUS).ToString()});
                }
            }
        }
    }
}