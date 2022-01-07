using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class AssetsTypeCreateDialog : Swebui.Controls.SwebUserControl
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
            this.FPanel = new Swebui.Controls.Panel();
            this.panel14 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.txtFID = new Swebui.Controls.Label();
            this.txtFName = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel17 = new Swebui.Controls.Panel();
            this.txtFDate = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.SPanel = new Swebui.Controls.Panel();
            this.panel18 = new Swebui.Controls.Panel();
            this.label16 = new Swebui.Controls.Label();
            this.label17 = new Swebui.Controls.Label();
            this.panel19 = new Swebui.Controls.Panel();
            this.txtID = new Swebui.Controls.TextBox();
            this.txtName = new Swebui.Controls.TextBox();
            this.panel20 = new Swebui.Controls.Panel();
            this.label20 = new Swebui.Controls.Label();
            this.label21 = new Swebui.Controls.Label();
            this.panel21 = new Swebui.Controls.Panel();
            this.txtDate = new Swebui.Controls.TextBox();
            this.label23 = new Swebui.Controls.Label();
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
            this.label1.Text = "新增资产分类";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FPanel
            // 
            this.FPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel14,
            this.panel15,
            this.panel16,
            this.panel17});
            this.FPanel.Name = "FPanel";
            this.FPanel.Size = new System.Drawing.Size(0, 130);
            this.FPanel.Visible = false;
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
            this.label4.Text = "父类编码";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "父类名称";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFID,
            this.txtFName});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(0, 35);
            // 
            // txtFID
            // 
            this.txtFID.Flex = 1;
            this.txtFID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtFID.Name = "txtFID";
            this.txtFID.Size = new System.Drawing.Size(100, 35);
            this.txtFID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtFName
            // 
            this.txtFName.Flex = 1;
            this.txtFName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 35);
            this.txtFName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.label12.Text = "父年限（月）";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFDate,
            this.label15});
            this.panel17.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(0, 35);
            // 
            // txtFDate
            // 
            this.txtFDate.Flex = 1;
            this.txtFDate.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.Size = new System.Drawing.Size(100, 35);
            this.txtFDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 35);
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // SPanel
            // 
            this.SPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel18,
            this.panel19,
            this.panel20,
            this.panel21});
            this.SPanel.Flex = 1;
            this.SPanel.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.SPanel.Name = "SPanel";
            this.SPanel.Size = new System.Drawing.Size(0, 130);
            // 
            // panel18
            // 
            this.panel18.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label16,
            this.label17});
            this.panel18.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(0, 30);
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 30);
            this.label16.Text = "类别编码";
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Flex = 1;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.Text = "类别名称";
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel19
            // 
            this.panel19.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtID,
            this.txtName});
            this.panel19.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(0, 35);
            // 
            // txtID
            // 
            this.txtID.Border = new Swebui.Controls.Border(1F);
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtID.Flex = 1;
            this.txtID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 35);
            // 
            // txtName
            // 
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            // 
            // panel20
            // 
            this.panel20.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label20,
            this.label21});
            this.panel20.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(0, 30);
            // 
            // label20
            // 
            this.label20.Flex = 1;
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 30);
            this.label20.Text = "年限（月）";
            this.label20.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Flex = 1;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 30);
            this.label21.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel21
            // 
            this.panel21.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtDate,
            this.label23});
            this.panel21.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(0, 35);
            // 
            // txtDate
            // 
            this.txtDate.Border = new Swebui.Controls.Border(1F);
            this.txtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtDate.Flex = 1;
            this.txtDate.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 35);
            // 
            // label23
            // 
            this.label23.Flex = 1;
            this.label23.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 35);
            this.label23.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // AssetsTypeCreateDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.FPanel,
            this.SPanel,
            this.panel2});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.AssetsTypeCreateDialog_Load);

        }
        #endregion

        private Label label1;
        private Panel FPanel;
        private Panel SPanel;
        private Panel panel18;
        private Label label16;
        private Label label17;
        private Panel panel19;
        private TextBox txtID;
        private TextBox txtName;
        private Panel panel20;
        private Label label20;
        private Label label21;
        private Panel panel21;
        private TextBox txtDate;
        private Label label23;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
        private Panel panel14;
        private Label label4;
        private Label label9;
        private Panel panel15;
        private Label txtFID;
        private Label txtFName;
        private Panel panel16;
        private Label label12;
        private Label label13;
        private Panel panel17;
        private Label txtFDate;
        private Label label15;
    }
}