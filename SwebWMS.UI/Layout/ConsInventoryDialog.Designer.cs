using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ConsInventoryDialog : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.panel1 = new Swebui.Controls.Panel();
            this.panel14 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.lblName = new Swebui.Controls.TextBox();
            this.addBtn = new Swebui.Controls.Button();
            this.lblSL = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel17 = new Swebui.Controls.Panel();
            this.lblNumber = new Swebui.Controls.Label();
            this.txtRealAmount = new Swebui.Controls.TextBox();
            this.panel2 = new Swebui.Controls.Panel();
            this.saveBtn = new Swebui.Controls.Button();
            this.cancelBtn = new Swebui.Controls.Button();
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.Text = "耗材盘点";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel14,
            this.panel15,
            this.panel16,
            this.panel17});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel14
            // 
            this.panel14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label9});
            this.panel14.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(0, 30);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "判断耗材";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "盘点库位";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.lblSL});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(0, 35);
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblName,
            this.addBtn});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // lblName
            // 
            this.lblName.Flex = 1;
            this.lblName.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 35);
            this.lblName.SubmitEditing += new System.EventHandler(this.addBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.ForeColor = System.Drawing.Color.DimGray;
            this.addBtn.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.addBtn.Name = "addBtn";
            this.addBtn.NumberOfLines = 0;
            this.addBtn.Size = new System.Drawing.Size(0, 35);
            this.addBtn.Text = "搜索";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // lblSL
            // 
            this.lblSL.Flex = 1;
            this.lblSL.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(100, 35);
            this.lblSL.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label12,
            this.label13});
            this.panel16.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(0, 30);
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 30);
            this.label12.Text = "应盘数量";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.Text = "实盘数量";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblNumber,
            this.txtRealAmount});
            this.panel17.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(0, 35);
            // 
            // lblNumber
            // 
            this.lblNumber.Flex = 1;
            this.lblNumber.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 35);
            this.lblNumber.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtRealAmount
            // 
            this.txtRealAmount.Border = new Swebui.Controls.Border(1F);
            this.txtRealAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtRealAmount.Flex = 1;
            this.txtRealAmount.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtRealAmount.Name = "txtRealAmount";
            this.txtRealAmount.Size = new System.Drawing.Size(100, 35);
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.saveBtn,
            this.cancelBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 50);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Border = new Swebui.Controls.Border(1F);
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.saveBtn.BorderRadius = 8;
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.saveBtn.Margin = new Swebui.Controls.Margin(170F, 8F, 5F, 8F);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.NumberOfLines = 0;
            this.saveBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.saveBtn.Size = new System.Drawing.Size(100, 35);
            this.saveBtn.Text = "保存";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Border = new Swebui.Controls.Border(1F);
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.cancelBtn.BorderRadius = 8;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.cancelBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 10F, 8F);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.NumberOfLines = 0;
            this.cancelBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.cancelBtn.Size = new System.Drawing.Size(100, 35);
            this.cancelBtn.Text = "取消";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ConsInventoryDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel1,
            this.panel2});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.ConsInventoryDialog_Load);

        }
        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel14;
        private Label label4;
        private Label label9;
        private Panel panel15;
        private Panel panel16;
        private Label label12;
        private Label label13;
        private Panel panel17;
        private Label lblNumber;
        private TextBox txtRealAmount;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
        private Panel panel3;
        private TextBox lblName;
        private Label lblSL;
        private Button addBtn;
    }
}