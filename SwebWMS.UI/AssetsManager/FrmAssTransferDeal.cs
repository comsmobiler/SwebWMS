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

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssTransferDeal : Swebui.Controls.SwebUserControl
    {
        public FrmAssTransferDeal() : base()
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
        private void FrmAssTransferDeal_Load(object sender, EventArgs e)
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
                if (String.IsNullOrEmpty(TOData.NOTE) == false) lblNote.Text = TOData.NOTE;
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        snPanel.Controls.Add(new OrderCheckSNLayout() { TOROWID = Row.TOROWID, ASSID = Row.ASSID, ASSName = assets.NAME, Image = Row.IMAGE, SN = Row.SN });
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
            this.Parent.Controls.Add(new FrmAssTransferDetail() { Flex = 1, TOID = TOID });
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
                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                foreach (OrderCheckSNLayout Row in snPanel.Controls)
                {
                    if (Row.Checked)
                    {
                        if (Type == PROCESSMODE.调拨确认)
                            Data.Add(new AssTransferOrderRow()
                            {
                                TOROWID = Row.TOROWID,
                                IMAGE = Row.Image,
                                ASSID = Row.ASSID,
                                SN = Row.SN,
                                TRANSFEREDQTY = 1,
                                STATUS = 1
                            });
                        else
                        {
                            Data.Add(new AssTransferOrderRow()
                            {
                                TOROWID = Row.TOROWID,
                                IMAGE = Row.Image,
                                ASSID = Row.ASSID,
                                SN = Row.SN,
                                TRANSFERCANCELQTY = 1,
                                STATUS = 2
                            });
                        }
                    }
                }
                if (Data.Count == 0) throw new Exception("请选择确认行项!");
                TOInputDto BasicData = new TOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.TOID = TOID;
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.UpdateAssTransferOrder(BasicData, Type, OperateType.资产);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("调拨操作成功!");
                    BackBtn_Click(null,null);
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

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (OrderCheckSNLayout Row in snPanel.Controls)
                {
                    Row.Checked = checkAll.Checked;
                }
            }
        }
    }
}