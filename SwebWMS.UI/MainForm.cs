
using SMOWMS.Domain.Entity;
using Swebui.Controls;
using SwebWMS.UI.Analyze;
using SwebWMS.UI.AssetsManager;
using SwebWMS.UI.ConsumablesManager;
using SwebWMS.UI.MasterData;
using SwebWMS.UI.Menu;
using SwebWMS.UI.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI
{
    partial class MainForm : Swebui.Controls.SwebForm
    {
        public MainForm() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Client.ReStart();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region 添加MenuView 子项
            MenuItem menuItem = new MenuItem("Home", "主页", "");

            MenuItem menuItem2 = new MenuItem("assets", "资产");
            MenuItem menuItem3 = new MenuItem("Assets", "资产管理");
            MenuItem menuItem4 = new MenuItem("AssTemplate", "资产模板");
            MenuItem menuItem30 = new MenuItem("AssIn", "资产入库");
            MenuItem menuItem31 = new MenuItem("AssOut", "资产出库");
            MenuItem menuItem32 = new MenuItem("AssTransfer","资产调拨");
            MenuItem menuItem33 = new MenuItem("AssInventory", "资产盘点");
            menuItem2.Items.AddRange(new MenuItem[] { menuItem3, menuItem4, menuItem30, menuItem31,menuItem32,menuItem33 });

            MenuItem menuItem34 = new MenuItem("consumales", "耗材");
            MenuItem menuItem35 = new MenuItem("Consumables", "耗材管理");
            MenuItem menuItem36 = new MenuItem("ConIn", "耗材入库");
            MenuItem menuItem37= new MenuItem("ConOut", "耗材出库");
            MenuItem menuItem38 = new MenuItem("ConTransfer", "耗材调拨");
            MenuItem menuItem39 = new MenuItem("ConInventory", "耗材盘点");
            menuItem34.Items.AddRange(new MenuItem[] { menuItem35, menuItem36, menuItem37, menuItem38, menuItem39 });

            MenuItem menuItem11 = new MenuItem("Orders", "订单");
            MenuItem menuItem12 = new MenuItem("AssetsSaleOrder", "资产销售");
            MenuItem menuItem13 = new MenuItem("AssetsPurchaseOrder", "资产采购");
            MenuItem menuItem14 = new MenuItem("ConSaleOrder", "耗材销售");
            MenuItem menuItem15 = new MenuItem("ConPurchaseOrder", "耗材采购");
            menuItem11.Items.AddRange(new MenuItem[] { menuItem12, menuItem13, menuItem14, menuItem15 });

            MenuItem menuItem6 = new MenuItem("masterData", "主数据");
            MenuItem menuItem7 = new MenuItem("AssetsType", "资产分类");
            MenuItem menuItem8 = new MenuItem("WareHouse", "仓库管理");
            MenuItem menuItem9 = new MenuItem("Clients", "客户管理");
            MenuItem menuItem10 = new MenuItem("Suppliers", "供应商管理");
            menuItem6.Items.AddRange(new MenuItem[] { menuItem7, menuItem8, menuItem9, menuItem10 });

            MenuItem menuItem16 = new MenuItem("Analyze", "资产分析统计");
            MenuItem menuItem17 = new MenuItem("AssQuantAnalysis", "资产库存分析");
            MenuItem menuItem18 = new MenuItem("ImminentExpiryAss", "资产有效期分析");
            MenuItem menuItem19 = new MenuItem("AssPOAnalysis", "资产采购报表");
            MenuItem menuItem20 = new MenuItem("AssVenAnalysis", "供应商统计");
            MenuItem menuItem21 = new MenuItem("AssSOAnalysis", "资产销售单报表");
            MenuItem menuItem22 = new MenuItem("AssCusAnalysis", "客户统计");
            menuItem16.Items.AddRange(new MenuItem[] { menuItem17, menuItem18, menuItem19, menuItem20, menuItem21, menuItem22 });

            MenuItem menuItem23 = new MenuItem("Analyze1", "耗材分析统计");
            MenuItem menuItem25 = new MenuItem("QuantAnalyze", "耗材库存分析");
            MenuItem menuItem26 = new MenuItem("SafeQuantAnalyze", "安全库存分析");
            MenuItem menuItem27 = new MenuItem("PurchaseAnalyze", "采购报表分析");
            MenuItem menuItem28 = new MenuItem("VendorAnalyze", "供货商统计");
            MenuItem menuItem29 = new MenuItem("SaleAnalyze", "销售报表分析");
            MenuItem menuItem24 = new MenuItem("CustomerAnalyze", "客户统计");

            menuItem23.Items.AddRange(new MenuItem[] { menuItem25, menuItem26, menuItem27, menuItem28, menuItem29, menuItem24 });
            MenuItem menuItem5 = new MenuItem("Setting", "设置");

            menuView1.Items.AddRange(new MenuItem[] { menuItem, menuItem2, menuItem34, menuItem11,menuItem6, menuItem16, menuItem23, menuItem5 });

            //  menuView1.DefaultSelectedItem(menuView1.Items[0]);
            MenuValueChanged(menuView1.Items[0]);
            #endregion

           string UserID = Client.Session["UserID"].ToString();
            AutofacConfig autofacConfig = new AutofacConfig();
          coreUser  UserData = autofacConfig.coreUserService.GetUserByID(UserID);
            useBtn.Text = UserData.USER_NAME;
        }
        /// <summary>
        /// menuview 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuView1_MenuItemClick(object sender, MenuViewItemClickEventArgs e)
        {
            MenuValueChanged(e.Item);
        }
        public void MenuValueChanged(MenuItem menuItem)
        {
            switch (menuItem.Id)
            {
                case "Home":
                    FrmMenu frmMenu = new FrmMenu();
                    AddTabPage(menuItem, frmMenu);
                    break;
                case "Assets":
                    FrmAssets frmAssets = new FrmAssets();
                    AddTabPage(menuItem, frmAssets);
                    break;
                case "AssTemplate":
                    FrmAssTemplate frmAssTemplate = new FrmAssTemplate();
                    AddTabPage(menuItem, frmAssTemplate);
                    break;
                case "AssIn":
                    FrmAssIn frmAssIn = new FrmAssIn();
                    AddTabPage(menuItem, frmAssIn);
                    break;
                case "AssOut":
                    FrmAssOut frmAssOut = new FrmAssOut();
                    AddTabPage(menuItem, frmAssOut);
                    break;
                case "AssTransfer":
                    FrmAssTransfer frmAssTransfer = new FrmAssTransfer();
                    AddTabPage(menuItem, frmAssTransfer);
                    break;
                case "AssInventory":
                    FrmAssInventory frmAssInventory = new FrmAssInventory();
                    AddTabPage(menuItem, frmAssInventory);
                    break;
                case "Consumables":
                    FrmConsumables frmConsumables = new FrmConsumables();
                    AddTabPage(menuItem, frmConsumables);
                    break;
                case "ConIn":
                    FrmConPORInSto frmConPORInSto = new FrmConPORInSto();
                    AddTabPage(menuItem, frmConPORInSto);
                    break;
                case "ConOut":
                    FrmConSOROutbound frmConSOROutbound = new FrmConSOROutbound();
                    AddTabPage(menuItem, frmConSOROutbound);
                    break;
                case "ConTransfer":
                    FrmConTransfer frmConTransfer = new FrmConTransfer();
                    AddTabPage(menuItem, frmConTransfer);
                    break;
                case "ConInventory":
                    FrmConInventory frmConInventory = new FrmConInventory();
                    AddTabPage(menuItem, frmConInventory);
                    break;

                case "Setting":
                    FrmUserInfo frmUserInfo = new FrmUserInfo();
                    AddTabPage(menuItem, frmUserInfo);
                    break;

                case "AssetsType":
                    FrmAssetsType frmAssetsType = new FrmAssetsType();
                    AddTabPage(menuItem, frmAssetsType);
                    break;
                case "WareHouse":
                    FrmWarehouse frmWarehouse = new FrmWarehouse();
                    AddTabPage(menuItem, frmWarehouse);
                    break;
                case "Clients":
                    FrmCustomer frmCustomer = new FrmCustomer();
                    AddTabPage(menuItem, frmCustomer);
                    break;
                case "Suppliers":
                    FrmSupplier frmSupplier = new FrmSupplier();
                    AddTabPage(menuItem, frmSupplier);
                    break;
                case "AssetsSaleOrder":
                    FrmAssetsSalesOrderList frmAssetsSalesOrderList = new FrmAssetsSalesOrderList();
                    AddTabPage(menuItem, frmAssetsSalesOrderList);
                    break;
                case "AssetsPurchaseOrder":
                    FrmAssPurchaseOrderList purchaseOrderList = new FrmAssPurchaseOrderList();
                    AddTabPage(menuItem, purchaseOrderList);
                    break;

                case "ConPurchaseOrder":
                    FrmConPurchaseOrderList frmConPurchase = new FrmConPurchaseOrderList();
                    AddTabPage(menuItem, frmConPurchase);
                    break;
                case "ConSaleOrder":
                    FrmConSaleOrderList saleOrderList = new FrmConSaleOrderList();
                    AddTabPage(menuItem, saleOrderList);
                    break;
                case "AssQuantAnalysis":
                    FrmAssQuantAnalysis frmAssQuantAnalysis = new FrmAssQuantAnalysis();
                    AddTabPage(menuItem, frmAssQuantAnalysis);
                    break;
                case "ImminentExpiryAss":
                    FrmImminentExpiryAss frmImminentExpiryAss = new FrmImminentExpiryAss();
                    AddTabPage(menuItem, frmImminentExpiryAss);
                    break;
                case "AssPOAnalysis":
                    FrmAssPOAnalysis frmAssPOAnalysis = new FrmAssPOAnalysis();
                    AddTabPage(menuItem, frmAssPOAnalysis);
                    break;
                case "AssVenAnalysis":
                    FrmAssVenAnalysis frmAssVenAnalysis = new FrmAssVenAnalysis();
                    AddTabPage(menuItem, frmAssVenAnalysis);
                    break;
                case "AssSOAnalysis":
                    FrmAssSOAnalysis frmAssSOAnalysis = new FrmAssSOAnalysis();
                    AddTabPage(menuItem, frmAssSOAnalysis);
                    break;
                case "AssCusAnalysis":
                    FrmAssCusAnalysis frmAssCusAnalysis = new FrmAssCusAnalysis();
                    AddTabPage(menuItem, frmAssCusAnalysis);
                    break;
                case "CustomerAnalyze":
                    FrmCustomerAnalyze frmCustomerAnalyze = new FrmCustomerAnalyze();
                    AddTabPage(menuItem, frmCustomerAnalyze);
                    break;
                case "PurchaseAnalyze":
                    FrmPurchaseAnalyze frmPurchaseAnalyze = new FrmPurchaseAnalyze();
                    AddTabPage(menuItem, frmPurchaseAnalyze);
                    break;
                case "QuantAnalyze":
                    FrmQuantAnalyze frmQuantAnalyze = new FrmQuantAnalyze();
                    AddTabPage(menuItem, frmQuantAnalyze);
                    break;
                case "SafeQuantAnalyze":
                    FrmSafeQuantAnalyze frmSafeQuantAnalyze = new FrmSafeQuantAnalyze();
                    AddTabPage(menuItem, frmSafeQuantAnalyze);
                    break;
                case "SaleAnalyze":
                    FrmSaleAnalyze frmSaleAnalyze = new FrmSaleAnalyze();
                    AddTabPage(menuItem, frmSaleAnalyze);
                    break;
                case "VendorAnalyze":
                    FrmVendorAnalyze frmVendorAnalyze = new FrmVendorAnalyze();
                    AddTabPage(menuItem, frmVendorAnalyze);
                    break;

            }
        }
       /// <summary>
       ///  tabpageview 中添加子项
       /// </summary>
       /// <param name="menuItem"></param>
       /// <param name="menuControl"></param>
        private void AddTabPage(MenuItem menuItem, SwebControl menuControl)
        {
            TabPageControl existTagControl = (TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id);
            //判断是否存在tab,存在就跳转，不存在就添加
            if (existTagControl != null)
            {
                if (existTagControl.Controls[0].GetType() != menuControl.GetType())
                {
                    menuControl.Flex = 1;
                    ((TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id)).Controls.Add(menuControl);
                    ((TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id)).Controls.RemoveAt(0);
                }
                this.tabPageView1.PageIndex = this.tabPageView1.Controls.IndexOf(existTagControl);
            }
            else
            {
                TabPageControl tagControl = new TabPageControl();
                tagControl.Name = menuItem.Id;
                menuControl.Flex = 1;
                tagControl.Controls.Add(menuControl);
                this.tabPageView1.Controls.Add(tagControl);
                this.tabPageView1.PageIndex = this.tabPageView1.Controls.Count - 1;
            }

        }
        /// <summary>
        /// 用户名称按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useBtn_Click(object sender, EventArgs e)
        {
            MenuValueChanged(new MenuItem("Setting", "设置"));
        }
    }
}