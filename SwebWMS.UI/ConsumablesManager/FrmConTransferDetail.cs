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
    partial class FrmConTransferDetail : Swebui.Controls.SwebUserControl
    {
        public FrmConTransferDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        #endregion
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConTransfer() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        ///页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConTransferDetail_Load(object sender, EventArgs e)
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
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                WHStorageLocationOutputDto whLoc = autofacConfig.wareHouseService.GetSLByID(TOData.WAREID, TOData.STID, TOData.DESSLID);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                lblLocation.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                lblDatePicker.Text = TOData.TRANSFERDATE.ToString();
                if (String.IsNullOrEmpty(TOData.NOTE) == false) lblNote.Text = TOData.NOTE;

                //DataTable tableAssets = new DataTable();      //未开启SN的资产列表
                //tableAssets.Columns.Add("CID");               //耗材编号
                //tableAssets.Columns.Add("NAME");              //耗材名称
                //tableAssets.Columns.Add("IMAGE");             //耗材图片
                //tableAssets.Columns.Add("WAITREPAIRQTY");     //待确认数量
                //tableAssets.Columns.Add("STATUS");            //行项状态
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Consumables cons = autofacConfig.consumablesService.GetConsById(Row.CID);
                    if (Row.STATUS == 0)
                    {
                        snPanel.Controls.Add(new OrderDetailSNLayout() { ASSID = Row.ASSID, ASSName = cons.NAME, Image = cons.IMAGE, SN = Row.INTRANSFERQTY.ToString(), Status = "调拨中" });
                    }
                    else if (Row.STATUS == 1)
                    {
                        snPanel.Controls.Add(new OrderDetailSNLayout() { ASSID = Row.ASSID, ASSName = cons.NAME, Image = cons.IMAGE, SN = Row.INTRANSFERQTY.ToString(), Status = "已完成" });
                    }
                    else
                    {
                        snPanel.Controls.Add(new OrderDetailSNLayout() { ASSID = Row.ASSID, ASSName = cons.NAME, Image = cons.IMAGE, SN = Row.INTRANSFERQTY.ToString(), Status = "已取消" });

                    }
                }
                if (Client.Session["Role"].ToString() == "SMOWMSUSER")
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
        /// 调拨确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void INBtn_Click(object sender, EventArgs e)
        {
            FrmConTransferDeal frm = new FrmConTransferDeal();
            frm.TOID = TOID;
            frm.Flex = 1;
            frm.Type = PROCESSMODE.调拨确认;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutBtn_Click(object sender, EventArgs e)
        {
            FrmConTransferDeal frm = new FrmConTransferDeal();
            frm.TOID = TOID;
            frm.Flex = 1;
            frm.Type = PROCESSMODE.调拨取消;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);

        }


    }
}