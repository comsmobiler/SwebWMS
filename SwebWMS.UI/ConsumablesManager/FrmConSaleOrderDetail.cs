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
    partial class FrmConSaleOrderDetail : Swebui.Controls.SwebUserControl
    {
        public FrmConSaleOrderDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public string SOID;
        #endregion
        private void FrmConSaleOrderDetail_Load(object sender, EventArgs e)
        {
            try
            {
                ///表头信息
                ConSalesOrderOutputDto Order = autofacConfig.ConSalesOrderService.GetBySOID(SOID);
                lblOrder.Text = SOID;
                lblRealID.Text = Order.REALID;
                lblName.Text = Order.NAME;
                lblCustomer.Text = Order.CUSTOMERNAME;
                lblDealMan.Text = Order.SALESPERSONNAME;
                List<ConPurAndSaleCreateInputDto> AlRows = autofacConfig.ConSalesOrderService.GetOrderRows(SOID);
                LoadRows(AlRows);


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
                    listPanel.Controls.Add(new ConSOAndPODetailLayout()
                    {
                        ID = dto.CID,
                        NAME = dto.NAME,
                        SaleNum = dto.QUANTSALED.ToString(),
                        Price = dto.REALPRICE.ToString(),
                        Img = dto.IMAGE,
                        AlreadyInOROut = dto.QUANTOUT.ToString(),
                        AlreadBack = dto.QUANTRETREATED.ToString(),
                    });
                }
            }
        }
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConSaleOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<ConSalesOrderRowInputDto> retRows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                if (retRows.Count == 0)
                    throw new Exception("该消耗单下目前无可退库耗材!");
                this.Parent.Controls.Add(new FrmConSORRetiring() { Flex = 1, SOID = SOID });
                this.Parent.Controls.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}