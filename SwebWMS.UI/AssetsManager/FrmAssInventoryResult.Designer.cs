using Swebui.Controls;
using System;

namespace SwebWMS.UI.AssetsManager
{
    partial class FrmAssInventoryResult : Swebui.Controls.SwebUserControl
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
            this.lblIID = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.StartBtn = new Swebui.Controls.Button();
            this.endBtn = new Swebui.Controls.Button();
            this.upBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.Label();
            this.txtHandleMan = new Swebui.Controls.Label();
            this.txtType = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtWare = new Swebui.Controls.Label();
            this.txtST = new Swebui.Controls.Label();
            this.txtSL = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.lbSN = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtCount = new Swebui.Controls.Label();
            this.snPanel = new Swebui.Controls.Panel();
            this.txtSN = new Swebui.Controls.TextBox();
            this.addBtn = new Swebui.Controls.Button();
            this.label12 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.waitBtn = new Swebui.Controls.Button();
            this.alBtn = new Swebui.Controls.Button();
            this.panel10 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.label16 = new Swebui.Controls.Label();
            this.label17 = new Swebui.Controls.Label();
            this.label18 = new Swebui.Controls.Label();
            this.label19 = new Swebui.Controls.Label();
            this.waitPanel = new Swebui.Controls.Panel();
            this.alPanel = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.lblIID});
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
            this.labTitle.Text = "资产盘点";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // lblIID
            // 
            this.lblIID.FontSize = 20F;
            this.lblIID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblIID.Name = "lblIID";
            this.lblIID.Size = new System.Drawing.Size(0, 26);
            this.lblIID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.StartBtn,
            this.endBtn,
            this.upBtn});
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
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.White;
            this.StartBtn.Border = new Swebui.Controls.Border(1F);
            this.StartBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.StartBtn.ForeColor = System.Drawing.Color.DimGray;
            this.StartBtn.IconName = "fa fa-floppy-o";
            this.StartBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.NumberOfLines = 0;
            this.StartBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.StartBtn.Size = new System.Drawing.Size(0, 26);
            this.StartBtn.Text = "开始盘点";
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.BackColor = System.Drawing.Color.White;
            this.endBtn.Border = new Swebui.Controls.Border(1F);
            this.endBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.endBtn.ForeColor = System.Drawing.Color.DimGray;
            this.endBtn.IconName = "fa fa-trash-o";
            this.endBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.endBtn.Name = "endBtn";
            this.endBtn.NumberOfLines = 0;
            this.endBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.endBtn.Size = new System.Drawing.Size(0, 26);
            this.endBtn.Text = "结束盘点";
            this.endBtn.Visible = false;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.White;
            this.upBtn.Border = new Swebui.Controls.Border(1F);
            this.upBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.upBtn.ForeColor = System.Drawing.Color.DimGray;
            this.upBtn.IconName = "fa fa-floppy-o";
            this.upBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.upBtn.Name = "upBtn";
            this.upBtn.NumberOfLines = 0;
            this.upBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.upBtn.Size = new System.Drawing.Size(0, 26);
            this.upBtn.Text = "上传结果";
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
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
            this.label2.Text = "盘点单名";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "盘点人";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "资产类型";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.txtHandleMan,
            this.txtType});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            this.txtName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtHandleMan
            // 
            this.txtHandleMan.Flex = 1;
            this.txtHandleMan.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtHandleMan.Name = "txtHandleMan";
            this.txtHandleMan.Size = new System.Drawing.Size(100, 35);
            this.txtHandleMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtType
            // 
            this.txtType.Flex = 1;
            this.txtType.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 35);
            this.txtType.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label5,
            this.label6});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "仓库";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "存储类型";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "库位";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtWare,
            this.txtST,
            this.txtSL});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtWare
            // 
            this.txtWare.Flex = 1;
            this.txtWare.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtWare.Name = "txtWare";
            this.txtWare.Size = new System.Drawing.Size(100, 35);
            this.txtWare.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtST
            // 
            this.txtST.Flex = 1;
            this.txtST.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(100, 35);
            this.txtST.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtSL
            // 
            this.txtSL.Flex = 1;
            this.txtSL.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 35);
            this.txtSL.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.lbSN,
            this.label9});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "需要盘点数";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lbSN
            // 
            this.lbSN.Flex = 1;
            this.lbSN.ForeColor = System.Drawing.Color.DimGray;
            this.lbSN.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(100, 30);
            this.lbSN.Text = "SN号";
            this.lbSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtCount,
            this.snPanel,
            this.label12});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtCount
            // 
            this.txtCount.Flex = 1;
            this.txtCount.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 35);
            this.txtCount.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // snPanel
            // 
            this.snPanel.Border = new Swebui.Controls.Border(1F);
            this.snPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.snPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSN,
            this.addBtn});
            this.snPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.snPanel.Flex = 1;
            this.snPanel.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.snPanel.Name = "snPanel";
            this.snPanel.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.snPanel.Size = new System.Drawing.Size(100, 35);
            // 
            // txtSN
            // 
            this.txtSN.BackColor = System.Drawing.Color.Transparent;
            this.txtSN.Flex = 1;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 35);
            this.txtSN.SubmitEditing += new System.EventHandler(this.addBtn_Click);
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
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 35);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.waitBtn,
            this.alBtn});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // waitBtn
            // 
            this.waitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.waitBtn.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.waitBtn.Name = "waitBtn";
            this.waitBtn.NumberOfLines = 0;
            this.waitBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.waitBtn.Size = new System.Drawing.Size(0, 0);
            this.waitBtn.Click += new System.EventHandler(this.waitBtn_Click);
            // 
            // alBtn
            // 
            this.alBtn.BackColor = System.Drawing.Color.White;
            this.alBtn.ForeColor = System.Drawing.Color.Black;
            this.alBtn.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.alBtn.Name = "alBtn";
            this.alBtn.NumberOfLines = 0;
            this.alBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.alBtn.Size = new System.Drawing.Size(0, 0);
            this.alBtn.Click += new System.EventHandler(this.alBtn_Click);
            // 
            // panel10
            // 
            this.panel10.Border = new Swebui.Controls.Border(1F);
            this.panel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label10,
            this.label11,
            this.label13,
            this.label14,
            this.label15,
            this.label16,
            this.label17,
            this.label18,
            this.label19});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel10.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel10.Size = new System.Drawing.Size(0, 30);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.Text = "图片";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.Text = "名称";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.Text = "SN";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.Text = "条形码";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.Text = "资产分类";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.Text = "规格型号";
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 20);
            this.label17.Text = "价格";
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label18
            // 
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 20);
            this.label18.Text = "库位";
            this.label18.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label19
            // 
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 20);
            this.label19.Text = "状态";
            this.label19.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // waitPanel
            // 
            this.waitPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.waitPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.waitPanel.Flex = 1;
            this.waitPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // alPanel
            // 
            this.alPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.alPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.alPanel.Flex = 1;
            this.alPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.alPanel.Name = "alPanel";
            this.alPanel.Size = new System.Drawing.Size(0, 100);
            this.alPanel.Visible = false;
            // 
            // FrmAssInventoryResult
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
            this.panel10,
            this.waitPanel,
            this.alPanel});
            this.Load += new System.EventHandler(this.FrmAssInventoryResult_Load);

        }
        #endregion

        private Panel panel1;
        private Label labTitle;
        private Label lblIID;
        private Panel panel2;
        private Button BackBtn;
        private Button StartBtn;
        private Button endBtn;
        private Button upBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label txtName;
        private Label txtHandleMan;
        private Label txtType;
        private Panel panel5;
        private Label label1;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Label txtWare;
        private Label txtST;
        private Label txtSL;
        private Panel panel7;
        private Label label7;
        private Label lbSN;
        private Label label9;
        private Panel panel8;
        private Label txtCount;
        private Panel snPanel;
        private Label label12;
        private TextBox txtSN;
        private Button addBtn;
        private Panel panel9;
        private Button waitBtn;
        private Button alBtn;
        private Panel panel10;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Panel waitPanel;
        private Panel alPanel;
    }
}