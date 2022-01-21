using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConTransfer : Swebui.Controls.SwebUserControl
    {
        public FrmConTransfer() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                List<AssTransferOrderOutputDto> Data = new List<AssTransferOrderOutputDto>();
                if (Client.Session["Role"].ToString() == "SMOWMSUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(), OperateType.耗材);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null, OperateType.耗材);
                }
                if (Data.Count > 0)
                {
                    gridView1.DataSource = Data;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 新增按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmContransferCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmConTransferDetail orderDetail = new FrmConTransferDetail();
                    orderDetail.Flex = 1;
                    orderDetail.TOID = args.SelectedRows[0]["TOID"].ToString();
                    this.Parent.Controls.Add(orderDetail);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });

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
                List<AssTransferOrderOutputDto> Data = new List<AssTransferOrderOutputDto>();
                if (Client.Session["Role"].ToString() == "SMOWMSUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(), OperateType.耗材);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null, OperateType.耗材);
                }

                gridView1.Reload(Data);            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}