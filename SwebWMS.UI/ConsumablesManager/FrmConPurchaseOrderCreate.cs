using SMOWMS.CommLib;
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

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConPurchaseOrderCreate : Swebui.Controls.SwebUserControl
    {
        public FrmConPurchaseOrderCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConPurchaseOrderRowInputDto> Rows = new List<ConPurchaseOrderRowInputDto>();         //选择的耗材编号
        public string POID;        //耗材采购单号
        #endregion
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConPurchaseOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 页面初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConPurchaseOrderCreate_Load(object sender, EventArgs e)
        {
            try
            {
                ///绑定供应商
                List<Vendor> vendorList = autofacConfig.vendorService.GetAll();
                if (vendorList != null)
                {
                    foreach (Vendor vendor in vendorList)
                    {
                        btnVendor.Nodes.Add(new TreeSelectNode(vendor.VID.ToString(), vendor.NAME));
                    }
                }
                ///绑定采购人
                List<coreUser> users = autofacConfig.coreUserService.GetAll();
                if (users != null)
                {
                    foreach (coreUser user in users)
                    {
                        btnDealMan.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                    }
                }
                if (string.IsNullOrEmpty(POID) == false)
                {
                    labTitle.Text = "编辑耗材采购订单";
                    ///表头信息
                    ConPurchaseOrderOutputDto Order = autofacConfig.ConPurchaseOrderService.GetByPOID(POID);
                    txtRealID.Text = Order.REALID;
                    txtName.Text = Order.NAME;
                    btnVendor.Tag = Order.VID;
                    btnVendor.DefaultValue = new string[] { Order.VID.ToString() };
                    btnDealMan.Tag = Order.PURCHASER;
                    btnDealMan.DefaultValue = new string[] { Order.PURCHASER};
                    //耗材行项信息
                    List<ConPurAndSaleCreateInputDto> OrderRows = autofacConfig.ConPurchaseOrderService.GetOrderRows(POID);
                    LoadRows(OrderRows);
                    DeleteBtn.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("采购单名称不能为空!");
                if (btnDealMan.Tag == null) throw new Exception("请选择采购人!");
                if (btnVendor.Tag == null) throw new Exception("请选择供货商!");
                GetRows();
                if (Rows.Count > 0)
                {
                    ConPurchaseOrderInputDto Data = new ConPurchaseOrderInputDto();
                    Data.REALID = txtRealID.Text;
                    Data.NAME = txtName.Text;
                    Data.PURCHASER = btnDealMan.Tag.ToString();
                    Data.VID = Convert.ToInt32(btnVendor.Tag);
                    Data.CREATEUSER = Client.Session["UserID"].ToString();
                    Data.CREATEDATE = DateTime.Now;
                    Data.MODIFYUSER = Client.Session["UserID"].ToString();
                    Data.MODIFYDATE = DateTime.Now;
                    Data.RowData = Rows;
                    ReturnInfo RInfo = new ReturnInfo();

                    if (String.IsNullOrEmpty(POID))     //创建耗材采购单
                    {
                        RInfo = autofacConfig.ConPurchaseOrderService.AddPurchaseOrder(Data);
                        if (RInfo.IsSuccess)     //创建成功
                        {
                            ShowResult = ShowResult.Yes;
                            Toast("采购单" + RInfo.ErrorInfo + "创建成功!");
                            BackBtn_Click(null, null);
                        }
                        else       //创建失败
                        {
                            throw new Exception(RInfo.ErrorInfo);
                        }
                    }
                    else               //更新耗材采购单
                    {
                        Data.POID = POID;
                        RInfo = autofacConfig.ConPurchaseOrderService.UpdatePruchaseOrder(Data);
                        if (RInfo.IsSuccess)     //创建成功
                        {
                            ShowResult = ShowResult.Yes;
                            Toast("采购单" + POID + "编辑成功!");
                            BackBtn_Click(null, null);
                        }
                        else       //创建失败
                        {
                            throw new Exception(RInfo.ErrorInfo);
                        }
                    }
                }
                else throw new Exception("请添加订单行项");

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 编辑时加载明细
        /// </summary>
        public void LoadRows(List<ConPurAndSaleCreateInputDto> orderRows)
        {
            if (orderRows.Count > 0)
            {
                List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
                foreach (ConPurAndSaleCreateInputDto dto in orderRows)
                {
                    listPanel.Controls.Add(new ConSOAndPOChooseLayout(cons) { TemplateID = dto.CID, NumQuant = dto.QUANTPURCHASED.ToString(), NumPrice = dto.REALPRICE.ToString(), Img = dto.IMAGE });
                }
            }
        }
        /// <summary>
        /// 得到行项数据
        /// </summary>
        public void GetRows()
        {
            Rows.Clear();
            //获取行项数据
            foreach (ConSOAndPOChooseLayout Layout in listPanel.Controls)
            {
                if (Rows.Find(a => a.CID == Layout.TemplateID) != null)
                {
                    throw new Exception("请将编号重复的项合并！");
                }
                ConPurchaseOrderRowInputDto row = new ConPurchaseOrderRowInputDto();
                row.CID = Layout.TemplateID;
                row.IMAGE = Layout.Img;
                row.QUANTPURCHASED = Convert.ToDecimal(Layout.NumQuant);
                row.REALPRICE = Convert.ToDecimal(Layout.NumPrice);
                if (row.QUANTPURCHASED == 0)
                {
                    throw new Exception("采购数量不能为0");
                }
                if (row.REALPRICE == 0)
                {
                    throw new Exception("采购价格不能为0");
                }
                Rows.Add(row);
            }
        }
        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你确定要删除该订单吗?", "系统提醒", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)     //删除该采购单
                        {
                        if (string.IsNullOrEmpty(POID))
                            throw new Exception("缺少编号");
                        ReturnInfo rInfo = autofacConfig.ConPurchaseOrderService.DeletePurchaseOrder(POID);
                        Toast("删除采购单成功");
                        BackBtn_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            });

        }
        /// <summary>
        /// 采购人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealMan.Tag = args.TreeID;
        }
        /// <summary>
        /// 供应商选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnCus_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnVendor.Tag = args.TreeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
            listPanel.Controls.Add(new ConSOAndPOChooseLayout(cons));
        }


    }
}