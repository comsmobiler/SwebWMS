using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssPurchaseOrderDetail : Swebui.Controls.SwebUserControl
    {
        public FrmAssPurchaseOrderDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public List<string> PORowIds = new List<string>();
        public string POID;
        public List<int> selectRowList = new List<int>();
        public int Status;
        #endregion
        private void FrmAssPurchaseOrderDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var po = _autofacConfig.AssPurchaseOrderService.GetById(POID);
                lblName.Text =  po.NAME;
                lblPMan.Text =  po.PURCHASERNAME;
                lblRealId.Text = po.REALID;
                lblStatus.Tag = po.STATUS;
                lblVendor.Text =  po.VNAME;
                lblTID.Text = POID;
                Status = po.STATUS;
                switch (po.STATUS)
                {
                    case 1:
                        lblStatus.Text = "入库中";
                        break;
                    case 2:
                        lblStatus.Text = "已完成";
                        break;
                    case 0:
                        lblStatus.Text = "采购中";
                        break;
                }
                var row = _autofacConfig.AssPurchaseOrderService.GetRows(POID);
                if (row.Rows.Count > 0)
                {
                    foreach (DataRow dr in row.Rows)
                    {
                        listPanel.Controls.Add(new AssetSaleOrderDetialLayout()
                        {
                            NAME = dr["NAME"].ToString(),
                            Img = dr["IMAGE"].ToString(),
                            SaleNum = dr["QUANTPURCHASED"].ToString(),
                            Price = dr["REALPRICE"].ToString(),
                            AlreadyOut = dr["QUANTSTORED"].ToString(),
                            AlreadBack = dr["QUANTRETREATED"].ToString(),
                            Status = dr["STATUSNAME"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssPurchaseOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        
    }
}