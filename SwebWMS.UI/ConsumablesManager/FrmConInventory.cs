using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConInventory : Swebui.Controls.SwebUserControl
    {
        public FrmConInventory() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConInventory_Load(object sender, EventArgs e)
        {
            try
            {
                string LocationId = "";
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOWMSAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.ConInventoryService.GetConInventoryList(Client.Session["Role"].ToString() == "SMOWMSUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                gridView1.DataSource = assInventoryList;
                gridView1.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConInventoryCreate() { Flex=1});
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "未盘点")
                    {
                        FrmConInventoryCreate frm = new FrmConInventoryCreate();
                        frm.Flex = 1;
                        frm.IID = args.SelectedRows[0]["IID"].ToString();
                        this.Parent.Controls.Add(frm);
                        this.Parent.Controls.RemoveAt(0);
                    }
                    else
                    {
                        Toast("当前订单不允许编辑！");
                    }
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 盘点按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmConInventoryResult result = new FrmConInventoryResult { IID = args.SelectedRows[0]["IID"].ToString(),Flex = 1 };
                    this.Parent.Controls.Add(result);
                    this.Parent.Controls.RemoveAt(0);
                }

                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LocationId = "";
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOWMSAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.ConInventoryService.GetConInventoryList(Client.Session["Role"].ToString() == "SMOWMSUser" ? Client.Session["UserID"].ToString() : "", LocationId);
               gridView1.Reload( assInventoryList);
         
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

  
    }
}