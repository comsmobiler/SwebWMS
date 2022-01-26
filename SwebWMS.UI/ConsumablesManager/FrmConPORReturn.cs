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
    partial class FrmConPORReturn : Swebui.Controls.SwebUserControl
    {
        public FrmConPORReturn() : base()
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
        private void FrmConPORReturn_Load(object sender, EventArgs e)
        {
            try
            {
                txtPOID.Text = POID;
                List<ConPurchaseOrderReturnOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
                LoadRows(rows);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 编辑时加载明细
        /// </summary>
        public void LoadRows(List<ConPurchaseOrderReturnOutputDto> orderRows)
        {
            if (orderRows.Count > 0)
            {
                foreach (ConPurchaseOrderReturnOutputDto dto in orderRows)
                {
                    listPanel.Controls.Add(new ConPORReturnLayout()
                    {
                        NAME = dto.NAME,
                        POROWID = dto.POROWID.ToString(),
                        Image = dto.IMAGE,
                        QUANTSTORED = dto.QUANTSTORED.ToString(),
                        LOCID = dto.LOCID,
                        LOCNAME = dto.LOCNAME,
                        CID = dto.CID
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
            this.Parent.Controls.Add(new FrmConPurchaseOrderDetail() { Flex = 1, POID = POID });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 提交退库操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<ConPurchaseOrderRowInputDto> Rows = new List<ConPurchaseOrderRowInputDto>();
                foreach (ConPORReturnLayout layout in listPanel.Controls)
                {
                    if (layout.IsChecked)
                    {
                        string[] locDatas = layout.LOCID.Split('/');
                        ConPurchaseOrderRowInputDto conPOW = new ConPurchaseOrderRowInputDto();
                        conPOW.CID = layout.CID;
                        conPOW.POROWID = Convert.ToInt32(layout.POROWID);
                        conPOW.WAREID = locDatas[0];
                        conPOW.STID = locDatas[1];
                        conPOW.SLID = locDatas[2];
                        if (Convert.ToDecimal(layout.Num) == 0)
                        {
                            conPOW.QUANTRETREATED = Convert.ToDecimal(layout.QUANTSTORED);
                        }
                        else
                        {
                            if (Convert.ToDecimal(Convert.ToDecimal(layout.Num)) > Convert.ToDecimal(layout.QUANTSTORED))
                            {
                                throw new Exception("实际退库数量不可大于可退库数量!");
                            }
                            conPOW.QUANTRETREATED = Convert.ToDecimal(layout.Num);
                        }
                        Rows.Add(conPOW);
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择退库耗材!");
                ConPOInStoInputDto stoInputDto = new ConPOInStoInputDto();
                stoInputDto.POID = POID;
                stoInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                stoInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConPurchaseOrderService.ReturnConPurchaseOrder(stoInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConPurchaseOrderReturnOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
                    if (rows.Count == 0)
                    {
                        Toast("该采购单退库完成!");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        Toast("退库成功!");
                        Bind();         //刷新当前页面入库数据

                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void Bind()
        {
            checkAll.Checked = false;
            List<ConPurchaseOrderReturnOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
            listPanel.Controls.Clear();
            LoadRows(rows);
        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Bind();
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
                foreach (ConPORReturnLayout layout in listPanel.Controls)
                {
                    layout.IsChecked = checkAll.Checked;
                }
            }
        }
    }
}