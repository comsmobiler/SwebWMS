using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssInventory : Swebui.Controls.SwebUserControl
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        public FrmAssInventory() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private void FrmAssInventory_Load(object sender, EventArgs e)
        {
            try
            {
                string UserId = Client.Session["UserID"].ToString();
                DataTable assInventoryList = _autofacConfig.AssInventoryService.GetAssInventoryList("");
                if (assInventoryList.Rows.Count > 0)
                {
                    gridView1.DataSource = assInventoryList;
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
            this.Parent.Controls.Add(new FrmAssInventoryCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 编辑按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "未盘点")
                    {
                        FrmAssInventoryCreate frm = new FrmAssInventoryCreate();
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
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string UserId = Client.Session["UserID"].ToString();
                DataTable assInventoryList = _autofacConfig.AssInventoryService.GetAssInventoryList("");
                gridView1.Reload(assInventoryList);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void panBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(args.SelectedRows[0]["IID"].ToString());
                   FrmAssInventoryResult result = new FrmAssInventoryResult { IID = args.SelectedRows[0]["IID"].ToString(), WAREID = inventory.WAREID, DepartmentId = inventory.SLID, typeId = inventory.TYPEID ,Flex=1};
                    this.Parent.Controls.Add(result);
                    this.Parent.Controls.RemoveAt(0);
                }

                else
                {
                    Toast("未选择行！");
                }
            });
        }
    }
}