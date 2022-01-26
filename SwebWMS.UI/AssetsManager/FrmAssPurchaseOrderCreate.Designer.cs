using Swebui.Controls;
using System;

namespace SwebWMS.UI.AssetsManager
{
    partial class FrmAssPurchaseOrderCreate : Swebui.Controls.SwebUserControl
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
            this.labTitle = new Swebui.Controls.Label();
            this.txtPOID = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtRealID = new Swebui.Controls.TextBox();
            this.txtName = new Swebui.Controls.TextBox();
            this.btnDealMan = new Swebui.Controls.TreeSelect();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.btnVendor = new Swebui.Controls.TreeSelect();
            this.textBox2 = new Swebui.Controls.Label();
            this.textBox3 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.panel8 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.label16 = new Swebui.Controls.Label();
            this.label17 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.listPanel = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.txtPOID});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // labTitle
            // 
            this.labTitle.FontSize = 24F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(0, 26);
            this.labTitle.Text = "新增资产采购订单";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // txtPOID
            // 
            this.txtPOID.FontSize = 20F;
            this.txtPOID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(0, 26);
            this.txtPOID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn,
            this.DeleteBtn});
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
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-floppy-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(0, 26);
            this.SaveBtn.Text = "保存";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Border = new Swebui.Controls.Border(1F);
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.IconName = "fa fa-trash-o";
            this.DeleteBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NumberOfLines = 0;
            this.DeleteBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DeleteBtn.Size = new System.Drawing.Size(0, 26);
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "实际编号";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "名称";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "采购人";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtRealID,
            this.txtName,
            this.btnDealMan});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtRealID
            // 
            this.txtRealID.BackColor = System.Drawing.Color.Transparent;
            this.txtRealID.Border = new Swebui.Controls.Border(1F);
            this.txtRealID.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtRealID.Flex = 1;
            this.txtRealID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtRealID.Name = "txtRealID";
            this.txtRealID.Size = new System.Drawing.Size(100, 35);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            // 
            // btnDealMan
            // 
            this.btnDealMan.Border = new Swebui.Controls.Border(1F);
            this.btnDealMan.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnDealMan.DefaultValue = new string[0];
            this.btnDealMan.DropDownHeight = 280;
            this.btnDealMan.Flex = 1;
            this.btnDealMan.ListBackgroundColor = System.Drawing.Color.White;
            this.btnDealMan.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.btnDealMan.Name = "btnDealMan";
            this.btnDealMan.Size = new System.Drawing.Size(100, 35);
            this.btnDealMan.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnDealMan_Press);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label6,
            this.label7});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "供应商";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnVendor,
            this.textBox2,
            this.textBox3});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // btnVendor
            // 
            this.btnVendor.Border = new Swebui.Controls.Border(1F);
            this.btnVendor.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnVendor.DefaultValue = new string[0];
            this.btnVendor.DropDownHeight = 280;
            this.btnVendor.Flex = 1;
            this.btnVendor.ListBackgroundColor = System.Drawing.Color.White;
            this.btnVendor.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(100, 35);
            this.btnVendor.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnCus_Press);
            // 
            // textBox2
            // 
            this.textBox2.Flex = 1;
            this.textBox2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            // 
            // textBox3
            // 
            this.textBox3.Flex = 1;
            this.textBox3.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.button1});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "订单明细";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "增加行";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.Border = new Swebui.Controls.Border(1F);
            this.panel8.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.label14,
            this.label15,
            this.label16,
            this.label17,
            this.label9});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 30);
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.Text = "物品名称";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 30);
            this.label14.Text = "物品编号";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 30);
            this.label15.Text = "图片";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 30);
            this.label16.Text = "数量";
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Flex = 1;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.Text = "价格";
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "操作";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // listPanel
            // 
            this.listPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.listPanel.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.listPanel.Flex = 1;
            this.listPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // FrmAssPurchaseOrderCreate
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
            this.listPanel});
            this.Load += new System.EventHandler(this.FrmAssPurchaseOrderCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label labTitle;
        private Label txtPOID;
        private Panel panel2;
        private Button BackBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TextBox txtRealID;
        private TextBox txtName;
        private TreeSelect btnDealMan;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private TreeSelect btnVendor;
        private Label textBox2;
        private Label textBox3;
        private Panel panel7;
        private Label label8;
        private Button button1;
        private Panel panel8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label9;
        private Panel listPanel;
    }
}