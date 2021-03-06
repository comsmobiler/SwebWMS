using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    partial class FrmSupplier : Swebui.Controls.SwebUserControl
    {
        public FrmSupplier() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal UnitType unitType;      //单位类别
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCustomerCreate() { Flex = 1, unitType = UnitType.供应商 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows != null && args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> keyValues = (Dictionary<string, object>)args.SelectedRows[0];
                    int id = Convert.ToInt32(keyValues["VID"].ToString());
                    this.Parent.Controls.Add(new FrmCustomerCreate() { vId = id, Flex = 1, unitType = UnitType.供应商 });
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选中行！");
                }
            });
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows != null && args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> keyValues = (Dictionary<string, object>)args.SelectedRows[0];
                    int id = Convert.ToInt32(keyValues["VID"].ToString());
                    this.Parent.Controls.Add(new FrmCustomerDetial() { vId = id, Flex = 1, unitType = UnitType.供应商 });
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选中行！");
                }
            });
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmSupplier() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);

        }

        private void txtNote_SubmitEditing(object sender, EventArgs e)
        {
            Bind();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            List<Vendor> vendorList = new List<Vendor>();
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                vendorList = autofacConfig.vendorService.GetByKeyword(txtName.Text);
            }
            else
            {
                vendorList = autofacConfig.vendorService.GetAll();
            }
            if (vendorList.Count > 0)
            {
                if (gridView1.DataSource != null)
                {
                    gridView1.Reload(vendorList);
                }
                else
                {
                    gridView1.DataSource = vendorList;
                    gridView1.DataBind();
                }
            }
            else
            {
                gridPanel.Visible = false;

            }
        }

    }
}