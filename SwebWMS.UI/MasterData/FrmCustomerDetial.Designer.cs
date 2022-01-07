using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmCustomerDetial : Swebui.Controls.SwebUserControl
    {
        #region "SwebUserControl generated code "

        //SwebUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SwebUserControl
        //It can be modified using the SwebUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Swebui.Controls.Panel();
            this.lblTitle = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.Label();
            this.txtContacts = new Swebui.Controls.Label();
            this.txtPhone = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtAddress = new Swebui.Controls.Label();
            this.txtFax = new Swebui.Controls.Label();
            this.txtEmail = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtTaxNumber = new Swebui.Controls.Label();
            this.txtBank = new Swebui.Controls.Label();
            this.txtAccount = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.txtNote = new Swebui.Controls.Label();
            this.textBox11 = new Swebui.Controls.Label();
            this.textBox12 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblTitle});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // lblTitle
            // 
            this.lblTitle.Flex = 1;
            this.lblTitle.FontSize = 24F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 26);
            this.lblTitle.Text = "客户详情";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(0, 26);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.label3});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "单位名称";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "联系人";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "电话";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.txtContacts,
            this.txtPhone});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            // 
            // txtContacts
            // 
            this.txtContacts.BackColor = System.Drawing.Color.Transparent;
            this.txtContacts.Flex = 1;
            this.txtContacts.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(100, 35);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.Flex = 1;
            this.txtPhone.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 35);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label5,
            this.label6});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "地址";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "传真";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "邮箱";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtAddress,
            this.txtFax,
            this.txtEmail});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.Flex = 1;
            this.txtAddress.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 35);
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.Transparent;
            this.txtFax.Flex = 1;
            this.txtFax.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 35);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Flex = 1;
            this.txtEmail.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 35);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8,
            this.label9});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "税号";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "开户银行";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "账户";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtTaxNumber,
            this.txtBank,
            this.txtAccount});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtTaxNumber.Flex = 1;
            this.txtTaxNumber.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Size = new System.Drawing.Size(100, 35);
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.Transparent;
            this.txtBank.Flex = 1;
            this.txtBank.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(100, 35);
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtAccount.Flex = 1;
            this.txtAccount.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 35);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label10,
            this.label11,
            this.label12});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.Text = "备注";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 30);
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 30);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtNote,
            this.textBox11,
            this.textBox12});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 35);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Transparent;
            this.textBox11.Flex = 1;
            this.textBox11.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 35);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Transparent;
            this.textBox12.Flex = 1;
            this.textBox12.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 35);
            // 
            // FrmCustomerDetial
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10});
            this.Load += new System.EventHandler(this.FrmCustomerDetial_Load);

        }
        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Button BackBtn;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label txtName;
        private Label txtContacts;
        private Label txtPhone;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Label txtAddress;
        private Label txtFax;
        private Label txtEmail;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private Label txtTaxNumber;
        private Label txtBank;
        private Label txtAccount;
        private Panel panel9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel10;
        private Label txtNote;
        private Label textBox11;
        private Label textBox12;
    }
}