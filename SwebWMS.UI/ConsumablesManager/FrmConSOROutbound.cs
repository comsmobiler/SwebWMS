using SMOWMS.CommLib;
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
    partial class FrmConSOROutbound : Swebui.Controls.SwebUserControl
    {
        public FrmConSOROutbound() : base()
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
        private void FrmConSOROutbound_Load(object sender, EventArgs e)
        {
            try
            {
                var salesOrders = autofacConfig.ConSalesOrderService.GetIncompleteOrders();
                if (salesOrders != null && salesOrders.Count > 0)
                {
                    foreach (var order in salesOrders)
                    {
                        txtOrder.Nodes.Add(new TreeSelectNode(order.SOID, order.SOID + order.NAME));
                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 出库提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                List<ConSalesOrderRowInputDto> Rows = new List<ConSalesOrderRowInputDto>();
                foreach (ConSOROutboundLayout row in snPanel.Controls)
                {
                    if (row.IsChecked)
                    {
                        ConSalesOrderRowInputDto conRow = new ConSalesOrderRowInputDto();
                        conRow.CID = row.CID;
                        conRow.SOROWID = Convert.ToInt32(row.SOROWID);
                        if (string.IsNullOrEmpty(row.NumIn) || Convert.ToDecimal(row.NumIn) == 0)
                        {
                            conRow.QUANTOUT = Convert.ToDecimal(row.QUANTSALED);
                        }
                        else
                        {
                            if (Convert.ToDecimal(row.NumIn) > Convert.ToDecimal(row.QUANTSALED))
                            {
                                throw new Exception("实际出库数量不可大于需出库数量!");
                            }
                            conRow.QUANTOUT = Convert.ToDecimal(row.NumIn);
                        }
                        Rows.Add(conRow);   //添加入库信息
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择出库耗材!");
                ConSOOutboundInputDto outInputDto = new ConSOOutboundInputDto();
                outInputDto.SOID = SOID;
                outInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                outInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConSalesOrderService.OutboundConSalesOrder(outInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConSalesOrderOutboundOutputDto> rows = autofacConfig.ConSalesOrderService.GetOutRowsBySOID(SOID);
                    if (rows.Count == 0)
                    {
                        Toast("该销售单出库完成!");
                        RefreshBtn_Click(null, null);
                    }
                    else
                    {
                        Toast("出库成功!");
                        snPanel.Controls.Clear();
                        Bind();         //刷新当前页面入库数据
                        Checkall.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                List<ConSalesOrderOutboundOutputDto> rows = autofacConfig.ConSalesOrderService.GetOutRowsBySOID(SOID);
                if (rows != null && rows.Count > 0)
                {
                    foreach (var row in rows)
                    {
                        snPanel.Controls.Add(new ConSOROutboundLayout()
                        {
                            Image = row.IMAGE,
                            ConName = row.NAME,
                            CID = row.CID,
                            SOROWID = row.SOROWID.ToString(),
                            QUANTSALED = row.QUANTSALED.ToString()
                        });
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
            try
            {
                txtOrder.Nodes.Clear();
                txtOrder.DefaultValue = new string[0];
                snPanel.Controls.Clear();
                Checkall.Checked = false;
                var salesOrders = autofacConfig.ConSalesOrderService.GetIncompleteOrders();
                if (salesOrders != null && salesOrders.Count > 0)
                {
                    foreach (var order in salesOrders)
                    {
                        txtOrder.Nodes.Add(new TreeSelectNode(order.SOID, order.SOID + order.NAME));
                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 订单选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void txtPOID_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                ConSalesOrderOutputDto conSales = autofacConfig.ConSalesOrderService.GetBySOID(args.TreeID);
                if (conSales != null)
                {
                    SOID = args.TreeID;
                    snPanel.Controls.Clear();
                    Bind();
                }
                else
                {
                    throw new Exception("该订单号不存在");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (ConSOROutboundLayout row in snPanel.Controls)
                {
                    row.IsChecked = Checkall.Checked;
                }
            }
        }


    }
}