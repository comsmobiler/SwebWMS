using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    partial class FrmCustomerCreate : Swebui.Controls.SwebUserControl
    {
        public FrmCustomerCreate() : base()
        {
            //This call is required by the SwebForm.
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
                this.Parent.Controls.Add(new FrmCustomer() { Flex=1});
                this.Parent.Controls.RemoveAt(0);
            }
            else
            {
                this.Parent.Controls.Add(new FrmSupplier() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
            }

        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (unitType)
                {
                    case UnitType.客户:
                        if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("单位名称不能为空");
                        Customer customer = new Customer
                        {
                            NAME = txtName.Text,
                            CONTACTS = txtContacts.Text,
                            PHONE = txtPhone.Text,
                            ADDRESS = txtAddress.Text,
                            FAX = txtFax.Text,
                            EMAIL = txtEmail.Text,
                            TAXNUMBER = txtTaxNumber.Text,
                            BANK = txtBank.Text,
                            ACCOUNT = txtAccount.Text,
                            NOTE = txtNote.Text
                        };
                        if (cusId != 0)
                        {
                            customer.CUSID = cusId;
                            ReturnInfo rInfo = autofacConfig.customerService.UpdateCustomer(customer);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("修改客户成功");
                                BackBtn_Click(null,null) ;
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        else
                        {
                            ReturnInfo rInfo = autofacConfig.customerService.AddCustomer(customer);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("新增客户成功");
                                BackBtn_Click(null, null);
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        break;
                    case UnitType.供应商:
                        if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("单位名称不能为空");
                        Vendor vendor = new Vendor
                        {
                            NAME = txtName.Text,
                            CONTACTS = txtContacts.Text,
                            PHONE = txtPhone.Text,
                            ADDRESS = txtAddress.Text,
                            FAX = txtFax.Text,
                            EMAIL = txtEmail.Text,
                            TAXNUMBER = txtTaxNumber.Text,
                            BANK = txtBank.Text,
                            ACCOUNT = txtAccount.Text,
                            NOTE = txtNote.Text
                        };
                        if (vId != 0)
                        {
                            vendor.VID = vId;
                            ReturnInfo rInfo = autofacConfig.vendorService.UpdateVendor(vendor);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("修改供货商成功");
                                BackBtn_Click(null, null);
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        else
                        {
                            ReturnInfo rInfo = autofacConfig.vendorService.AddVendor(vendor);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("新增供货商成功");
                                BackBtn_Click(null, null);
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (unitType)
            {
                case UnitType.客户:
                    MessageBox.Show("你确定要删除该客户吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //启用该仓库
                            {
                                ReturnInfo rInfo = autofacConfig.customerService.DeleteCustomer(cusId);
                                if (rInfo.IsSuccess)
                                {
                                    Toast("删除客户成功");
                                    BackBtn_Click(null, null);
                                }
                                else
                                {
                                    throw new Exception(rInfo.ErrorInfo);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
                case UnitType.供应商:
                    MessageBox.Show("你确定要删除该供应商吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //启用该仓库
                            {
                                ReturnInfo rInfo = autofacConfig.vendorService.DeleteVendor(vId);
                                if (rInfo.IsSuccess)
                                {
                                    Toast("删除供应商成功");
                                    BackBtn_Click(null, null);
                                }
                                else
                                {
                                    throw new Exception(rInfo.ErrorInfo);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
            }
        }

        private void FrmCustomerCreate_Load(object sender, EventArgs e)
        {
            switch (unitType)
            {
                case UnitType.客户:
                    if (cusId != 0)
                    {
                        lblTitle.Text = "客户编辑";
                        Customer customer = autofacConfig.customerService.GetById(cusId);
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
                        DeleteBtn.Visible = true;
                    }
                    break;
                case UnitType.供应商:
                    if (vId != 0)
                    {
                        lblTitle.Text = "供货商编辑";
                        Vendor vendor = autofacConfig.vendorService.GetById(vId);
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
                        DeleteBtn.Visible = true;
                    }
                    else
                    {
                        lblTitle.Text = "供货商新增";
                    }
                    break;
            }
        }
    }
}