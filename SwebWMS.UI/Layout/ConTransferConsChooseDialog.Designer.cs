using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ConTransferConsChooseDialog : Swebui.Controls.SwebUserControl
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
            this.panel3 = new Swebui.Controls.Panel();
            this.panel1 = new Swebui.Controls.Panel();
            this.CheckAll = new Swebui.Controls.CheckBox();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.snPanel = new Swebui.Controls.Panel();
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
            this.label1.Text = "耗材选择";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.CheckAll,
            this.label10,
            this.label11,
            this.label7,
            this.label8,
            this.label9});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 30);
            // 
            // CheckAll
            // 
            this.CheckAll.BackColor = System.Drawing.Color.Transparent;
            this.CheckAll.BorderColor = System.Drawing.Color.Black;
            this.CheckAll.BorderRadius = 0;
            this.CheckAll.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(60, 26);
            this.CheckAll.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 30);
            this.label10.Text = "图片";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.Text = "名称";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 30);
            this.label7.Text = "库存位置";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.Text = "可用数量";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 30);
            this.label9.Text = "调拨数量";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // snPanel
            // 
            this.snPanel.Flex = 1;
            this.snPanel.Name = "snPanel";
            this.snPanel.Size = new System.Drawing.Size(0, 100);
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
            // ConTransferConsChooseDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel3,
            this.panel1,
            this.snPanel,
            this.panel2});
            this.Size = new System.Drawing.Size(680, 400);
            this.Load += new System.EventHandler(this.ConTransferConsChooseDialog_Load);

        }
        #endregion

        private Label label1;
        private Panel panel3;
        private Panel panel1;
        private CheckBox CheckAll;
        private Label label10;
        private Label label11;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel snPanel;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
    }
}