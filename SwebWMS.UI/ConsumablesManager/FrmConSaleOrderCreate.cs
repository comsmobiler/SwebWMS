using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
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
    partial class FrmConSaleOrderCreate : Swebui.Controls.SwebUserControl
    {
        public FrmConSaleOrderCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConSalesOrderRowInputDto> Rows = new List<ConSalesOrderRowInputDto>();         //选择的耗材编号
        public string SOID;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConSaleOrderCreate_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定客户
                List<Customer> customerList = autofacConfig.customerService.GetAll();
                if (customerList != null)
                {
                    foreach (Customer customer in customerList)
                    {
                        btnCustomer.Nodes.Add(new TreeSelectNode(customer.CUSID.ToString(), customer.NAME));
                    }
                }
                // 绑定销售人员
                List<coreUser> users = autofacConfig.coreUserService.GetAll();
                if (users != null)
                {
                    foreach (coreUser user in users)
                    {
                        btnDealMan.Nodes.Add(new TreeSelectNode(user.USER_ID, user.USER_NAME));
                    }
                }

                if (!String.IsNullOrEmpty(SOID))   //SOID不为空,说明是销售单修改
                {
                    this.labTitle.Text = "耗材销售单编辑";
                    ///表头信息
                    ConSalesOrderOutputDto Order = autofacConfig.ConSalesOrderService.GetBySOID(SOID);
                    txtRealID.Text = Order.REALID;
                    txtName.Text = Order.NAME;
                    btnCustomer.Tag = Order.CUSID;
                    btnCustomer.DefaultValue = new string[] { Order.CUSID.ToString() };
                    btnDealMan.Tag = Order.SALESPERSON;
                    btnCustomer.DefaultValue = new string[] { Order.SALESPERSON };

                    //耗材行项信息
                    List<ConPurAndSaleCreateInputDto> OrderRows = autofacConfig.ConSalesOrderService.GetOrderRows(SOID);
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
        /// 编辑时加载明细
        /// </summary>
        public void LoadRows(List<ConPurAndSaleCreateInputDto> orderRows)
        {
            if (orderRows.Count > 0)
            {
                List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
                foreach (ConPurAndSaleCreateInputDto dto in orderRows)
                {
                    listPanel.Controls.Add(new ConSOAndPOChooseLayout(cons) { TemplateID = dto.CID, NumQuant = dto.QUANTSALED.ToString(), NumPrice = dto.REALPRICE.ToString(), Img = dto.IMAGE });
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
                ConSalesOrderRowInputDto row = new ConSalesOrderRowInputDto();
                row.CID = Layout.TemplateID;
                row.IMAGE = Layout.Img;
                row.QUANTSALED = Convert.ToDecimal(Layout.NumQuant);
                row.REALPRICE = Convert.ToDecimal(Layout.NumPrice);
                if (row.QUANTSALED == 0)
                {
                    throw new Exception("数量不能为0");
                }
                if (row.REALPRICE == 0)
                {
                    throw new Exception("价格不能为0");
                }
                Rows.Add(row);
            }
        }
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConSaleOrderList() { Flex = 1 });
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
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("销售单名称不能为空!");
                if (btnDealMan.Tag == null) throw new Exception("请选择销售人!");
                GetRows();
                if (Rows.Count > 0)
                {
                    ConSalesOrderInputDto Data = new ConSalesOrderInputDto();
                    Data.REALID = txtRealID.Text;
                    Data.NAME = txtName.Text;
                    Data.CUSID = Convert.ToInt32(btnCustomer.Tag);
                    Data.SALESPERSON = btnDealMan.Tag.ToString();
                    Data.CREATEUSER = Client.Session["UserID"].ToString();
                    Data.CREATEDATE = DateTime.Now;
                    Data.MODIFYUSER = Client.Session["UserID"].ToString();
                    Data.MODIFYDATE = DateTime.Now;
                    Data.RowData = Rows;
                    ReturnInfo RInfo = new ReturnInfo();

                    if (String.IsNullOrEmpty(SOID))     //创建耗材采购单
                    {
                        RInfo = autofacConfig.ConSalesOrderService.AddSalesOrder(Data);
                        if (RInfo.IsSuccess)     //创建成功
                        {
                            ShowResult = ShowResult.Yes;
                            Toast("销售单" + RInfo.ErrorInfo + "创建成功!");
                            BackBtn_Click(null, null);
                        }
                        else       //创建失败
                        {
                            throw new Exception(RInfo.ErrorInfo);
                        }
                    }
                    else               //更新耗材采购单
                    {
                        Data.SOID = SOID;
                        RInfo = autofacConfig.ConSalesOrderService.UpdateSalesOrder(Data);
                        if (RInfo.IsSuccess)     //创建成功
                        {
                            ShowResult = ShowResult.Yes;
                            Toast("销售单" + SOID + "编辑成功!");
                            BackBtn_Click(null, null);
                        }
                        else       //创建失败
                        {
                            throw new Exception(RInfo.ErrorInfo);
                        }
                    }
                }
                else
                {
                    throw new Exception("请添加订单行项");

                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 选择客户事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnCustomer_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnCustomer.Tag = args.TreeID;
        }
        /// <summary>
        /// 选择销售人员事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press_1(object sender, TreeSelectPressEventArgs args)
        {
            btnDealMan.Tag = args.TreeID;
        }
        /// <summary>
        /// 增加行项按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
            listPanel.Controls.Add(new ConSOAndPOChooseLayout(cons));
        }


    }
}