using Swebui.Controls;
using System;

namespace SwebWMS.UI.AssetsManager
{
    partial class FrmAssIn : Swebui.Controls.SwebUserControl
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
            this.saveBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtPOID = new Swebui.Controls.TreeSelect();
            this.btnTemplate = new Swebui.Controls.TreeSelect();
            this.txtSLID = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel9 = new Swebui.Controls.Panel();
            this.txtSN = new Swebui.Controls.TextBox();
            this.addBtn = new Swebui.Controls.Button();
            this.lblQuant = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.snPanel = new Swebui.Controls.Panel();
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
            this.label1.Text = "资产销售订单列表";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.saveBtn,
            this.RefreshBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
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
            this.saveBtn.Text = "入库";
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
            this.label3.Text = "模板编号";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "库位（仓库号/分类号/库位号，例如03/01/01）";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtPOID,
            this.btnTemplate,
            this.txtSLID});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPOID
            // 
            this.txtPOID.Border = new Swebui.Controls.Border(1F);
            this.txtPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPOID.DefaultValue = new string[0];
            this.txtPOID.Flex = 1;
            this.txtPOID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(100, 35);
            this.txtPOID.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.txtPOID_Press);
            // 
            // btnTemplate
            // 
            this.btnTemplate.Border = new Swebui.Controls.Border(1F);
            this.btnTemplate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnTemplate.DefaultValue = new string[0];
            this.btnTemplate.Flex = 1;
            this.btnTemplate.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(100, 35);
            this.btnTemplate.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnTemplate_Press);
            // 
            // txtSLID
            // 
            this.txtSLID.Border = new Swebui.Controls.Border(1F);
            this.txtSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSLID.Flex = 1;
            this.txtSLID.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSLID.Name = "txtSLID";
            this.txtSLID.Size = new System.Drawing.Size(100, 0);
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
            this.label5.Text = "资产SN号";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "需入库数";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel9,
            this.lblQuant,
            this.label9});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // panel9
            // 
            this.panel9.Border = new Swebui.Controls.Border(1F);
            this.panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSN,
            this.addBtn});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 35);
            // 
            // txtSN
            // 
            this.txtSN.BackColor = System.Drawing.Color.Transparent;
            this.txtSN.Flex = 1;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 35);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.ForeColor = System.Drawing.Color.DimGray;
            this.addBtn.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.addBtn.Name = "addBtn";
            this.addBtn.NumberOfLines = 0;
            this.addBtn.Size = new System.Drawing.Size(0, 35);
            this.addBtn.Text = "添加";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // lblQuant
            // 
            this.lblQuant.Flex = 1;
            this.lblQuant.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(100, 0);
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            // 
            // panel7
            // 
            this.panel7.Border = new Swebui.Controls.Border(1F);
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.label10,
            this.label11});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 33);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.Text = "操作";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.label11.Size = new System.Drawing.Size(0, 30);
            this.label11.Text = "SN";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // snPanel
            // 
            this.snPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.snPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.snPanel.Flex = 1;
            this.snPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.snPanel.Name = "snPanel";
            this.snPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // FrmAssIn
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
            this.snPanel});
            this.Load += new System.EventHandler(this.FrmAssIn_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button saveBtn;
        private Button RefreshBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TreeSelect txtPOID;
        private TreeSelect btnTemplate;
        private TextBox txtSLID;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
        private Panel snPanel;
        private Panel panel9;
        private TextBox txtSN;
        private Button addBtn;
        private Label lblQuant;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
    }
}