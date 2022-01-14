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
    partial class FrmConPORInSto : Swebui.Controls.SwebUserControl
    {

        public FrmConPORInSto() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String POID;               //耗材采购单编号
        #endregion  
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConPORInSto_Load(object sender, EventArgs e)
        {
            try
            {
                /// 绑定耗材采购单 
                var salesOrders = autofacConfig.ConPurchaseOrderService.GetIncompleteOrders();
                if (salesOrders != null && salesOrders.Count > 0)
                {
                    foreach (var order in salesOrders)
                    {
                        txtOrder.Nodes.Add(new TreeSelectNode(order.POID, order.POID + order.NAME));
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 采购单选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void txtPOID_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                ConPurchaseOrderOutputDto conPurchaseOrder = autofacConfig.ConPurchaseOrderService.GetByPOID(args.TreeID);
                if (conPurchaseOrder != null)
                {
                    POID = args.TreeID;
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
        /// 加载数据
        /// </summary>
        private void Bind()
        {
            try
            {
                List<ConPORInstorageOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetInStoRowsByPOID(POID);
                if (rows != null && rows.Count > 0)
                {
                    foreach (var row in rows)
                    {
                        snPanel.Controls.Add(new ConPORInStoLayout()
                        {
                            Image = row.IMAGE,
                            ConName = row.NAME,
                            QUANTPURCHASED = row.QUANTPURCHASED.ToString(),
                            POROWID = row.POROWID.ToString(),
                            CID = row.CID
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
        /// 提交事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtLocation.Text)) throw new Exception("请输入调入库位!");
                List<ConPurchaseOrderRowInputDto> Rows = new List<ConPurchaseOrderRowInputDto>();
                foreach (ConPORInStoLayout row in snPanel.Controls)
                {
                    if (row.IsChecked)
                    {
                        ConPurchaseOrderRowInputDto conPOW = new ConPurchaseOrderRowInputDto();
                        conPOW.CID = row.CID;
                        conPOW.POROWID = Convert.ToInt32(row.POROWID);
                        if (string.IsNullOrEmpty(row.NumIn))
                        {
                            throw new Exception("请填写正确的出库数量!");
                        }
                        else
                        {
                            if (Convert.ToDecimal(row.NumIn) < 0)
                                throw new Exception("请填写正确的出库数量!");
                            if (Convert.ToDecimal(row.NumIn) > Convert.ToDecimal(row.QUANTPURCHASED))
                            {
                                throw new Exception("实际入库数量不可大于可入库数量!");
                            }
                            conPOW.QUANTSTORED = Convert.ToDecimal(row.NumIn);
                        }
                        Rows.Add(conPOW);   //添加入库信息
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择入库耗材!");
                String[] locDatas = txtLocation.Text.ToString().Split('/');
                ConPOInStoInputDto stoInputDto = new ConPOInStoInputDto();
                stoInputDto.POID = POID;
                stoInputDto.WAREID = locDatas[0];
                stoInputDto.STID = locDatas[1];
                stoInputDto.SLID = locDatas[2];
                stoInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                stoInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConPurchaseOrderService.InStoConPurhcaseOrder(stoInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConPORInstorageOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetInStoRowsByPOID(POID);
                    if (rows.Count == 0)
                    {
                        Toast("该采购单入库完成!");
                        RefreshBtn_Click(null, null);
                    }
                    else
                    {
                        Toast("入库成功!");
                        snPanel.Controls.Clear();
                        Bind();         //刷新当前页面入库数据
                        txtLocation.Text = "";
                        Checkall.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrder.Nodes.Clear();
                txtOrder.DefaultValue = new string[] { };
                /// 绑定耗材采购单 
                var salesOrders = autofacConfig.ConPurchaseOrderService.GetIncompleteOrders();
                if (salesOrders != null && salesOrders.Count > 0)
                {
                    foreach (var order in salesOrders)
                    {
                        txtOrder.Nodes.Add(new TreeSelectNode(order.POID, order.POID + order.NAME));
                    }
                }
                txtLocation.Text = "";
                POID = "";
                snPanel.Controls.Clear();
                Checkall.Checked = false;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (ConPORInStoLayout row in snPanel.Controls)
                {
                    row.IsChecked = Checkall.Checked;
                }
            }
        }
    }
}