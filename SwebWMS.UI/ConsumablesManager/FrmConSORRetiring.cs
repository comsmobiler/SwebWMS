using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
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
    partial class FrmConSORRetiring : Swebui.Controls.SwebUserControl
    {
        public FrmConSORRetiring() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String SOID;               //耗材销售单编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConSORRetiring_Load(object sender, EventArgs e)
        {
            txtSOID.Text = SOID;
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                List<ConSalesOrderRowInputDto> rows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                foreach (var row in rows)
                {
                    listPanel.Controls.Add(new ConSORRetiringLayout()
                    {
                        CID = row.CID,
                        Image = row.IMAGE,
                        NAME = row.NAME,
                        QUANTOUT = row.QUANTOUT.ToString(),
                        SOROWID = row.SOROWID.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConSaleOrderDetail() { Flex = 1, SOID = SOID });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<ConSalesOrderRowInputDto> Rows = new List<ConSalesOrderRowInputDto>();
                foreach (ConSORRetiringLayout layout in listPanel.Controls)
                {
                    if (layout.IsChecked)
                    {
                        ConSalesOrderRowInputDto conSales = new ConSalesOrderRowInputDto();
                        conSales.CID = layout.CID;
                        conSales.SOROWID = Convert.ToInt32(layout.SOROWID);
                        if (Convert.ToDecimal(layout.Num) == 0)
                        {
                            conSales.QUANTRETREATED = Convert.ToDecimal(layout.QUANTOUT);
                        }
                        else
                        {
                            if (Convert.ToDecimal(layout.Num) > Convert.ToDecimal(layout.QUANTOUT))
                            {
                                throw new Exception("实际出库数量不可大于需出库数量!");
                            }
                            conSales.QUANTRETREATED = Convert.ToDecimal(layout.Num);
                        }

                        Rows.Add(conSales);   //添加入库信息

                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择退货耗材!");
                ConSOOutboundInputDto outInputDto = new ConSOOutboundInputDto();
                outInputDto.SOID = SOID;
                outInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                outInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConSalesOrderService.RetConSalesOrder(outInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConSalesOrderRowInputDto> rows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                    if (rows.Count == 0)
                    {
                        Toast("该销售单退货完成!");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        Toast("退货成功!");
                        RefreshBtn_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            listPanel.Controls.Clear();
            Bind();         //刷新当前页面入库数据
            checkAll.Checked = false;

        }
        /// <summary>
        /// 全选按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (listPanel.Controls.Count > 0)
            {
                foreach (ConSORRetiringLayout layout in listPanel.Controls)
                {
                    layout.IsChecked = checkAll.Checked;
                }
            }
        }


    }
}