using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCustomerDetial : Swebui.Controls.SwebUserControl
    {
        public FrmCustomerDetial() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal int cusId;        //客户编号
        internal int vId;      //供货商编号
        internal UnitType unitType;      //用户类型
        #endregion
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (unitType == UnitType.客户)
            {
                this.Parent.Controls.Add(new FrmCustomer() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
            }
            else
            {
                this.Parent.Controls.Add(new FrmSupplier() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
            }


        }

        private void FrmCustomerDetial_Load(object sender, EventArgs e)
        {
            switch (unitType)
            {
                case UnitType.客户:
                    lblTitle.Text = "客户详情";
                    Customer customer = autofacConfig.customerService.GetById(cusId);
                    if (customer != null)
                    {
                        txtName.Text = customer.NAME;
                        txtContacts.Text = customer.CONTACTS;
                        txtPhone.Text = customer.PHONE;
                        txtAddress.Text = customer.ADDRESS;
                        txtFax.Text = customer.FAX;
                        txtEmail.Text = customer.EMAIL;
                        txtTaxNumber.Text = customer.TAXNUMBER;
                        txtBank.Text = customer.BANK;
                        txtAccount.Text = customer.ACCOUNT;
                        txtNote.Text = customer.NOTE;
                    }
                    break;
                case UnitType.供应商:
                    lblTitle.Text = "供货商详情";
                    Vendor vendor = autofacConfig.vendorService.GetById(vId);
                    if (vendor != null)
                    {
                        txtName.Text = vendor.NAME;
                        txtContacts.Text = vendor.CONTACTS;
                        txtPhone.Text = vendor.PHONE;
                        txtAddress.Text = vendor.ADDRESS;
                        txtFax.Text = vendor.FAX;
                        txtEmail.Text = vendor.EMAIL;
                        txtTaxNumber.Text = vendor.TAXNUMBER;
                        txtBank.Text = vendor.BANK;
                        txtAccount.Text = vendor.ACCOUNT;
                        txtNote.Text = vendor.NOTE;
                    }
                    break;
            }
        }
    }
}