using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
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
    partial class FrmConTransferDeal : Swebui.Controls.SwebUserControl
    {
        public FrmConTransferDeal() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        public PROCESSMODE Type;   //操作类型
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConTransferDeal_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                if (Type == PROCESSMODE.调拨确认) title1.Text = "调拨单确认";
                if (Type == PROCESSMODE.调拨取消) title1.Text = "调拨单取消";
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                WHStorageLocationOutputDto whLoc = autofacConfig.wareHouseService.GetSLByID(TOData.WAREID, TOData.STID, TOData.DESSLID);
                lblLocation.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                lblDatePicker.Text = TOData.TRANSFERDATE.ToString();
                if (String.IsNullOrEmpty(TOData.NOTE)) lblNote.Text = TOData.NOTE;

                //DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                //tableAssets.Columns.Add("TOROWID");           //报修单行项编号
                //tableAssets.Columns.Add("LOCATIONID");         //区域编号
                //tableAssets.Columns.Add("LOCATIONNAME");       //区域名称
                //tableAssets.Columns.Add("CID");              //资产编号
                //tableAssets.Columns.Add("NAME");               //资产名称
                //tableAssets.Columns.Add("IMAGE");              //图片编号
                //tableAssets.Columns.Add("INTRANSFERQTY");      //调拨中数量
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Consumables cons = autofacConfig.consumablesService.GetConsById(Row.CID);
                    WareHouse Location = autofacConfig.wareHouseService.GetByWareID(Row.SLID);
                    if (Row.STATUS == 0)
                    {
                        snPanel.Controls.Add(new ConTDLayout() { TOROWID = Row.TOROWID, LOCATIONID = Row.SLID, LOCATIONNAME = Location.NAME, CID = Row.CID, NAME = cons.NAME, Image = Row.IMAGE, INTRANSFERQTY = Row.INTRANSFERQTY.ToString() });
                    }
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
            this.Parent.Controls.Add(new FrmConTransferDetail() { TOID = TOID, Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 提交按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TOInputDto BasicData = new TOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.TOID = TOID;

                List<AssTransferOrderRow> DataList = new List<AssTransferOrderRow>();
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    if (Row.IsChecked)
                    {
                        if (Convert.ToDecimal(Row.Num) > Convert.ToDecimal(Row.INTRANSFERQTY))
                        {
                            if (Type == PROCESSMODE.调拨确认)
                                throw new Exception("确认数量不能超过调拨数量!");
                            else
                                throw new Exception("取消数量不能超过调拨数量!");
                        }
                        AssTransferOrderRow Data = new AssTransferOrderRow();
                        Data.TOROWID = Row.TOROWID;
                        Data.IMAGE = Row.Image;
                        Data.CID = Row.CID;
                        if (Type == PROCESSMODE.调拨确认)
                        {
                            if (Convert.ToDecimal(Row.Num) == 0 || Convert.ToDecimal(Row.Num) == Convert.ToDecimal(Convert.ToDecimal(Row.INTRANSFERQTY)))
                            {
                                Data.STATUS = 1;
                                Data.TRANSFEREDQTY = Convert.ToDecimal(Row.INTRANSFERQTY);
                            }
                            else
                            {
                                Data.TRANSFEREDQTY = Convert.ToDecimal(Row.Num);
                                Data.STATUS = 0;
                            }
                        }
                        else
                        {
                            if (Convert.ToDecimal(Row.Num) == 0 || Convert.ToDecimal(Row.Num) == Convert.ToDecimal(Row.INTRANSFERQTY))
                            {
                                Data.STATUS = 2;
                                Data.TRANSFERCANCELQTY = Convert.ToDecimal(Row.INTRANSFERQTY);
                            }
                            else
                            {
                                Data.TRANSFERCANCELQTY = Convert.ToDecimal(Row.Num);
                                Data.STATUS = 0;
                            }
                        }
                        Data.SLID = Row.LOCATIONID;
                        DataList.Add(Data);
                    }
                }
                if (DataList.Count == 0) throw new Exception("请选择确认行项!");
                BasicData.Rows = DataList;
                ReturnInfo r = autofacConfig.assTransferOrderService.UpdateAssTransferOrder(BasicData, Type, OperateType.耗材);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    if (Type == PROCESSMODE.调拨确认)
                    {
                        Toast("确认调拨成功!");
                    }
                    else
                    {
                        Toast("取消调拨成功!");
                    }
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 全选按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    Row.IsChecked = checkAll.Checked;
                }
            }
        }
    }
}