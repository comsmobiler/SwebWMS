using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
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
    partial class FrmAssTransferCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAssTransferCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public TOInputDto TransferData = new TOInputDto();         //调拨单信息
        #endregion
        private void FrmAssTransferCreate_Load(object sender, EventArgs e)
        { 
            ///绑定调入管理员
            List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
            if (users != null&& users.Count > 0)
            {
                foreach( var user in users)
                {
                    btnDealInMan.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                }
            }
            ///绑定处理人选择
            List<coreUser> users1 = autofacConfig.coreUserService.GetAdmin();
            if (users1 != null && users1.Count > 0)
            {
                foreach (var user in users1)
                {
                    btnDealMan.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                }
            }
        }
        /// <summary>
        /// 返回键按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssTransfer() { Flex=1});
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
                if (btnDealInMan.Tag == null)
                    throw new Exception("调入管理员不能为空");
                else
                    TransferData.MANAGER = btnDealInMan.Tag.ToString();     //调入管理员

                if (lblLocation.Text == null)
                    throw new Exception("调入库位不能为空");
                else
                {
                    string[] Datas = lblLocation.Text.ToString().Split('/');
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
                TransferData.ISSNCONTROL = (Int32)ISSNCONTROL.启用;         //是否属于SN
                TransferData.CREATEUSER = Client.Session["UserID"].ToString();      //创建用户
                TransferData.CREATEDATE = DateTime.Now;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                if (snPanel.Controls.Count == 0) throw new Exception("调拨行项不能为空!");
                foreach (OrderCreateSNLayout Row in snPanel.Controls)
                {
                    AssTransferOrderRow assRow = new AssTransferOrderRow();
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);

                    assRow.IMAGE = Row.Image;
                    assRow.ASSID = Row.ASSID;
                    assRow.INTRANSFERQTY = 1;
                    assRow.SN = Row.SN;
                    assRow.STATUS = 0;
                    assRow.WAREID = assets.WAREID;
                    assRow.STID = assets.STID;
                    assRow.SLID = assets.SLID;
                    assRow.CREATEDATE = DateTime.Now;
                    Data.Add(assRow);
                }
                TransferData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.AddAssTransferOrder(TransferData, OperateType.资产);
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSN.Text))
                {
                   
                    throw new Exception("请输入SN号");
                }
                Assets assets = autofacConfig.orderCommonService.GetUnusedAssetsBySN(txtSN.Text);
                if (assets == null) throw new Exception("不存在序列号为" + txtSN.Text + "的闲置资产");
                if (assets.WAREID + "/" + assets.STID + "/" + assets.SLID == lblLocation.Text) throw new Exception("该资产已在目的库位!");
                if (snPanel.Controls.Count !=0)
                {
                    foreach (OrderCreateSNLayout Row in snPanel.Controls)
                    {
                        if (assets.ASSID == Row.ASSID && assets.SN == Row.SN)
                            throw new Exception("该资产已添加，请勿重复添加!");
                    }
                    snPanel.Controls.Add(new OrderCreateSNLayout() { Image = assets.IMAGE, ASSID = assets.ASSID, SN = txtSN.Text, ASSName = assets.NAME });
                }
                else
                {
                    snPanel.Controls.Add(new OrderCreateSNLayout() { Image = assets.IMAGE, ASSID = assets.ASSID, SN = txtSN.Text, ASSName = assets.NAME });
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
        /// <summary>
        /// 调入管理员选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealInMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealInMan.Tag = args.TreeID;
        }
    }
}