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
    partial class FrmContransferCreate : Swebui.Controls.SwebUserControl
    {
        public FrmContransferCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConsumablesOrderRow> RowData = new List<ConsumablesOrderRow>();    //未开启SN行项
        public String CID;               //耗材编号
        #endregion
        private void FrmContransferCreate_Load(object sender, EventArgs e)
        {
            ///调入管理员数据绑定
            List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
            if (users != null && users.Count > 0)
            {
                foreach (var user in users)
                {
                    btnDealInMan.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                }
            }

            ///    处理人数据绑定
            List<coreUser> admins = autofacConfig.coreUserService.GetAdmin();
            if (admins != null && admins.Count > 0)
            {
                foreach (var user in admins)
                {
                    btnDealMan.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
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
            this.Parent.Controls.Add(new FrmConTransfer() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TOInputDto TransferData = new TOInputDto();        //维修单信息
                if (btnDealInMan.Tag == null)
                    throw new Exception("调入管理员不能为空");
                else
                    TransferData.MANAGER = btnDealInMan.Tag.ToString();     //调入管理员

                if (lblLocation.Text == null)
                    throw new Exception("调入库位不能为空");
                else
                {
                    string[] Datas = lblLocation.Text.Split('/');
                    TransferData.WAREID = Datas[0];     //调入仓库
                    TransferData.STID = Datas[1];       //调入类型
                    TransferData.DESSLID = Datas[2];    //调入库位
                }


                if (btnDealMan.Tag == null)
                    throw new Exception("处理人不能为空");
                else
                    TransferData.HANDLEMAN = btnDealMan.Tag.ToString();     //处理人

                TransferData.TRANSFERDATE = datepicker.Value;   //维修花费
                TransferData.NOTE = txtNote.Text;                           //备注
                TransferData.STATUS = 0;                                    //维修单状态
                TransferData.CREATEUSER = Client.Session["UserID"].ToString();      //创建用户
                TransferData.CREATEDATE = DateTime.Now;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    if (Row.IsChecked)
                    {
                        AssTransferOrderRow assRow = new AssTransferOrderRow();
                        assRow.IMAGE = Row.Image;
                        assRow.CID = Row.CID;
                        assRow.INTRANSFERQTY = Convert.ToDecimal(Row.Num);
                        string[] datas = Row.LOCATIONID.Split('/');
                        assRow.WAREID = datas[0];
                        assRow.STID = datas[1];
                        assRow.SLID = datas[2];
                        assRow.STATUS = 0;
                        assRow.CREATEDATE = DateTime.Now;
                        Data.Add(assRow);
                    }
                }
                if (Data.Count == 0) throw new Exception("调拨行项不能为空!");
                TransferData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.AddAssTransferOrder(TransferData, OperateType.耗材);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("创建调拨单成功!");
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
        /// 调入管理员选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealInMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealInMan.Tag = args.TreeID;
        }
        /// <summary>
        /// 处理人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealMan.Tag = args.TreeID;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///选择耗材按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  if (string.IsNullOrEmpty(lblLocation.Text)) throw new Exception("请输入调入库位!");
                ConTransferConsChooseDialog dialog = new ConTransferConsChooseDialog();
                dialog.LocInID = lblLocation.Text;
                ShowDialog(dialog, (obj, args) =>
                {
                    if (dialog.ShowResult == ShowResult.Yes)
                        this.RowData = dialog.RowData;
                    Bind();
                });
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
                if (RowData.Count > 0)
                {
                    foreach (ConsumablesOrderRow Row in RowData)
                    {
                        ConQuant conQuant = autofacConfig.orderCommonService.GetUnUseConByCID(Row.CID, Row.WAREID, Row.STID, Row.SLID);
                        Consumables con = autofacConfig.consumablesService.GetConsById(Row.CID);
                        WHStorageLocationOutputDto WHLoc = autofacConfig.wareHouseService.GetSLByID(Row.WAREID, Row.STID, Row.SLID);
                        bool isExist = false  ;
                        foreach (ConTDLayout layout in snPanel.Controls)
                        {
                            if (Row.CID == layout.CID && Row.WAREID + "/" + Row.STID + "/" + Row.SLID== layout.LOCATIONID)
                            {
                                layout.Num = (Convert.ToDecimal(layout.Num)+Row.QTY).ToString();
                                isExist = true;
                                break;
                            }
                        }
                        if(isExist==false)
                        snPanel.Controls.Add(new ConTDLayout() {IsChecked=true,CID= Row.CID, NAME=con.NAME,LOCATIONID= Row.WAREID + "/" + Row.STID + "/" + Row.SLID, LOCATIONNAME=WHLoc.WARENAME + "/" + WHLoc.STNAME + "/" + WHLoc.SLNAME, Image=con.IMAGE,INTRANSFERQTY= conQuant.QUANTITY.ToString(), Num=Row.QTY.ToString() });
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