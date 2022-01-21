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
    partial class FrmAssetsSalesOrderDetail : Swebui.Controls.SwebUserControl
    {
        public FrmAssetsSalesOrderDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
                                                                   //        private string UserId;  //用户编号
        public List<string> PORowIds = new List<string>();
        public string SOID;
        public List<int> selectRowList = new List<int>();
        public int Status;
        #endregion
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssetsSalesOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        private void FrmAssetsSalesOrderDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var po = _autofacConfig.AssSalesOrderService.GetById(SOID);
                lblName.Text = po.NAME;
                lblPMan.Text = po.SALESPERSONNAME;
                lblRealId.Text =po.REALID;
                lblStatus.Tag = po.STATUS;
                lblCustomer.Text = po.CUSNAME;
                lblTID.Text = SOID;
                Status = po.STATUS;
                switch (po.STATUS)
                {
                    case 1:
                        lblStatus.Text = "出库中";
                        break;
                    case 2:
                        lblStatus.Text = "已完成";
                        break;
                    case 0:
                        lblStatus.Text = "销售中";
                        break;
                }
                var row = _autofacConfig.AssSalesOrderService.GetRows(SOID);
                if (row.Rows.Count > 0)
                {
                    foreach (DataRow dr in row.Rows)
                    {
                        listPanel.Controls.Add(new AssetSaleOrderDetialLayout()
                        {
                            NAME = dr["NAME"].ToString(),
                            Img = dr["IMAGE"].ToString(),
                            SaleNum = dr["QUANTSALED"].ToString(),
                            Price = dr["REALPRICE"].ToString(),
                            AlreadyOut = dr["QUANTOUT"].ToString(),
                            AlreadBack = dr["QUANTRETREATED"].ToString(),
                            Status = dr["STATUSNAME"].ToString(),
                            ID = dr["SOROWID"].ToString()
                        }) ;
                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}