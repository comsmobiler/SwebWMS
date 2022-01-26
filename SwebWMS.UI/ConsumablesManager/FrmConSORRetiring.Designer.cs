using Swebui.Controls;
using System;

namespace SwebWMS.UI.ConsumablesManager
{
    partial class FrmConSORRetiring : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.saveBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtSOID = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.lblQuant = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.checkAll = new Swebui.Controls.CheckBox();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.listPanel = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.FontSize = 24F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.Text = "耗材销售退库";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.saveBtn,
            this.RefreshBtn});
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
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.Border = new Swebui.Controls.Border(1F);
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.saveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.saveBtn.IconName = "fa fa-upload";
            this.saveBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.NumberOfLines = 0;
            this.saveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.saveBtn.Size = new System.Drawing.Size(0, 26);
            this.saveBtn.Text = "退库";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Border = new Swebui.Controls.Border(1F);
            this.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DimGray;
            this.RefreshBtn.IconName = "fa fa-refresh";
            this.RefreshBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.NumberOfLines = 0;
            this.RefreshBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.RefreshBtn.Size = new System.Drawing.Size(0, 26);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            this.label2.Text = "采购单号";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSOID,
            this.panel9,
            this.lblQuant});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtSOID
            // 
            this.txtSOID.Flex = 1;
            this.txtSOID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtSOID.Name = "txtSOID";
            this.txtSOID.Size = new System.Drawing.Size(100, 35);
            this.txtSOID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 35);
            // 
            // lblQuant
            // 
            this.lblQuant.Flex = 1;
            this.lblQuant.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(100, 0);
            // 
            // panel8
            // 
            this.panel8.Border = new Swebui.Controls.Border(1F);
            this.panel8.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkAll,
            this.label5,
            this.label6,
            this.label8,
            this.label9});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 30);
            // 
            // checkAll
            // 
            this.checkAll.BackColor = System.Drawing.Color.Transparent;
            this.checkAll.BorderColor = System.Drawing.Color.Black;
            this.checkAll.BorderRadius = 0;
            this.checkAll.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(22, 26);
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 26);
            this.label5.Text = "图片";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.Text = "名称";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.Text = "可退库数量";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.Text = "退库数量";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // listPanel
            // 
            this.listPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.listPanel.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.listPanel.Flex = 1;
            this.listPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // FrmConSORRetiring
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel8,
            this.listPanel});
            this.Load += new System.EventHandler(this.FrmConSORRetiring_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BackBtn;
        private Button saveBtn;
        private Button RefreshBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label txtSOID;
        private Panel panel9;
        private Label lblQuant;
        private Panel panel8;
        private CheckBox checkAll;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Panel listPanel;
    }
}