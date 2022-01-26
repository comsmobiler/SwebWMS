using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class WHTypeCreateDialog : Swebui.Controls.SwebUserControl
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
            this.panel13 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel14 = new Swebui.Controls.Panel();
            this.txtWareID = new Swebui.Controls.TextBox();
            this.txtWareName = new Swebui.Controls.TextBox();
            this.panel15 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.txtSTID = new Swebui.Controls.TextBox();
            this.txtSTName = new Swebui.Controls.TextBox();
            this.panel17 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel18 = new Swebui.Controls.Panel();
            this.switchIsEnable = new Swebui.Controls.Switch();
            this.panel2 = new Swebui.Controls.Panel();
            this.saveBtn = new Swebui.Controls.Button();
            this.cancelBtn = new Swebui.Controls.Button();
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.Text = "新增仓库类别";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label9});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "仓库编码";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "仓库名称";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtWareID,
            this.txtWareName});
            this.panel14.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(0, 35);
            // 
            // txtWareID
            // 
            this.txtWareID.Border = new Swebui.Controls.Border(1F);
            this.txtWareID.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtWareID.Flex = 1;
            this.txtWareID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtWareID.Name = "txtWareID";
            this.txtWareID.ReadOnly = true;
            this.txtWareID.Size = new System.Drawing.Size(100, 35);
            // 
            // txtWareName
            // 
            this.txtWareName.Border = new Swebui.Controls.Border(1F);
            this.txtWareName.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtWareName.Flex = 1;
            this.txtWareName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtWareName.Name = "txtWareName";
            this.txtWareName.ReadOnly = true;
            this.txtWareName.Size = new System.Drawing.Size(100, 35);
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label10,
            this.label11});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(0, 30);
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.Text = "类别编码";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 30);
            this.label11.Text = "类别名称";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSTID,
            this.txtSTName});
            this.panel16.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(0, 35);
            // 
            // txtSTID
            // 
            this.txtSTID.Border = new Swebui.Controls.Border(1F);
            this.txtSTID.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtSTID.Flex = 1;
            this.txtSTID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtSTID.Name = "txtSTID";
            this.txtSTID.Size = new System.Drawing.Size(100, 35);
            // 
            // txtSTName
            // 
            this.txtSTName.Border = new Swebui.Controls.Border(1F);
            this.txtSTName.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtSTName.Flex = 1;
            this.txtSTName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.Size = new System.Drawing.Size(100, 35);
            // 
            // panel17
            // 
            this.panel17.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label12,
            this.label13});
            this.panel17.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(0, 30);
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 30);
            this.label12.Text = "是否启用";
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
            // panel18
            // 
            this.panel18.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.switchIsEnable});
            this.panel18.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel18.Flex = 1;
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(0, 35);
            // 
            // switchIsEnable
            // 
            this.switchIsEnable.BackColor = System.Drawing.Color.Transparent;
            this.switchIsEnable.BorderColor = System.Drawing.Color.Black;
            this.switchIsEnable.BorderRadius = 0;
            this.switchIsEnable.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.switchIsEnable.Name = "switchIsEnable";
            this.switchIsEnable.Size = new System.Drawing.Size(100, 35);
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
            this.panel2.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
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
            // WHTypeCreateDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel13,
            this.panel14,
            this.panel15,
            this.panel16,
            this.panel17,
            this.panel18,
            this.panel2});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.WHTypeCreateDialog_Load);

        }
        #endregion

        private Label label1;
        private Panel panel13;
        private Label label2;
        private Label label9;
        private Panel panel14;
        private TextBox txtWareID;
        private TextBox txtWareName;
        private Panel panel15;
        private Label label10;
        private Label label11;
        private Panel panel16;
        private TextBox txtSTID;
        private TextBox txtSTName;
        private Panel panel17;
        private Label label12;
        private Label label13;
        private Panel panel18;
        private Switch switchIsEnable;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
    }
}