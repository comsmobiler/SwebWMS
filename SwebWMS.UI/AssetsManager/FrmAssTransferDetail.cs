using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
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
    partial class FrmAssTransferDetail : Swebui.Controls.SwebUserControl
    {
        public FrmAssTransferDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        #endregion

        private void FrmAssTransferDetail_Load(object sender, EventArgs e)
        {
            try
            {
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                WHStorageLocationOutputDto whLoc = autofacConfig.wareHouseService.GetSLByID(TOData.WAREID, TOData.STID, TOData.DESSLID);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                lblLocation.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                lblDatePicker.Text = TOData.TRANSFERDATE.ToString();
                if (String.IsNullOrEmpty(TOData.NOTE) == false) lblNote.Text = TOData.NOTE;
                if (TOData.Rows != null && TOData.Rows.Count > 0)
                {
                    foreach (AssTransferOrderRow Row in TOData.Rows)
                    {
                        Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                        if (Row.STATUS == 0)
                        {
                            snPanel.Controls.Add(new OrderDetailSNLayout() { ASSID = Row.ASSID, ASSName = assets.NAME, Image = assets.IMAGE, SN = Row.SN, Status = "调拨中" });
                        }
                        else if (Row.STATUS == 1)
                        {
                            snPanel.Controls.Add(new OrderDetailSNLayout() { ASSID = Row.ASSID, ASSName = assets.NAME, Image = assets.IMAGE, SN = Row.SN, Status = "调拨完成" });
                        }
                        else
                        {
                            snPanel.Controls.Add(new OrderDetailSNLayout() { ASSID = Row.ASSID, ASSName = assets.NAME, Image = assets.IMAGE, SN = Row.SN, Status = "调拨取消" });
                        }
                    }
                }

                if (Client.Session["Role"].ToString() == "SMOWMSUser")
                {
                    INBtn.Visible = OutBtn.Visible = false;
                }
                //如果维修单已完成，则隐藏维修单处理按钮
                if (TOData.STATUS == 1 || TOData.STATUS == 2)
                {
                    INBtn.Visible = OutBtn.Visible = false;
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
            this.Parent.Controls.Add(new FrmAssTransfer() { Flex=1});
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutBtn_Click(object sender, EventArgs e)
        {
            FrmAssTransferDeal frm = new FrmAssTransferDeal();
            frm.TOID = TOID;
            frm.Type = PROCESSMODE.调拨取消;
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨入库按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void INBtn_Click(object sender, EventArgs e)
        {
            FrmAssTransferDeal frm = new FrmAssTransferDeal();
            frm.TOID = TOID;
            frm.Type = PROCESSMODE.调拨确认;
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
        }


    }
}