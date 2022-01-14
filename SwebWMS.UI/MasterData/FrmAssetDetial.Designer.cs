using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmAssetDetial : Swebui.Controls.SwebUserControl
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
            this.txtAssId1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName1 = new Swebui.Controls.Label();
            this.panel = new Swebui.Controls.Panel();
            this.ImgPicture = new Swebui.Controls.Image();
            this.txtType = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtSN = new Swebui.Controls.Label();
            this.DatePickerBuy = new Swebui.Controls.Label();
            this.DatePickerExpiry = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtPrice1 = new Swebui.Controls.Label();
            this.txtUnit1 = new Swebui.Controls.Label();
            this.txtSPE1 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.txtPlace1 = new Swebui.Controls.Label();
            this.txtSL = new Swebui.Controls.Label();
            this.txtATID = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label19 = new Swebui.Controls.Label();
            this.label20 = new Swebui.Controls.Label();
            this.label21 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.txtManager = new Swebui.Controls.Label();
            this.txtVendor1 = new Swebui.Controls.Label();
            this.txtNote1 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.txtAssId1});
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
            this.labTitle.Text = "资产详情";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // txtAssId1
            // 
            this.txtAssId1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.txtAssId1.Name = "txtAssId1";
            this.txtAssId1.Size = new System.Drawing.Size(0, 26);
            this.txtAssId1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.ViewBtn});
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
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.White;
            this.ViewBtn.Border = new Swebui.Controls.Border(1F);
            this.ViewBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.ViewBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ViewBtn.IconName = "fa fa-bookmark";
            this.ViewBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.NumberOfLines = 0;
            this.ViewBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.ViewBtn.Size = new System.Drawing.Size(0, 26);
            this.ViewBtn.Text = "处理记录";
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
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
            this.label1.Text = "名称";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "图片";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "类别";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName1,
            this.panel,
            this.txtType});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 55);
            // 
            // txtName1
            // 
            this.txtName1.Flex = 1;
            this.txtName1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 35);
            this.txtName1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel
            // 
            this.panel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ImgPicture});
            this.panel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel.Flex = 1;
            this.panel.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(0, 55);
            // 
            // ImgPicture
            // 
            this.ImgPicture.Border = new Swebui.Controls.Border(1F);
            this.ImgPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ImgPicture.Name = "ImgPicture";
            this.ImgPicture.ResourceID = "";
            this.ImgPicture.Size = new System.Drawing.Size(45, 45);
            this.ImgPicture.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
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
            this.label4.Text = "SN";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "购入时间";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "过期时间";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSN,
            this.DatePickerBuy,
            this.DatePickerExpiry});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtSN
            // 
            this.txtSN.Flex = 1;
            this.txtSN.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 0);
            this.txtSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DatePickerBuy
            // 
            this.DatePickerBuy.Flex = 1;
            this.DatePickerBuy.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.DatePickerBuy.Name = "DatePickerBuy";
            this.DatePickerBuy.Size = new System.Drawing.Size(100, 0);
            this.DatePickerBuy.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DatePickerExpiry
            // 
            this.DatePickerExpiry.Flex = 1;
            this.DatePickerExpiry.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.DatePickerExpiry.Name = "DatePickerExpiry";
            this.DatePickerExpiry.Size = new System.Drawing.Size(100, 0);
            this.DatePickerExpiry.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.label7.Text = "金额";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "单位";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "规格型号";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtPrice1,
            this.txtUnit1,
            this.txtSPE1});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Flex = 1;
            this.txtPrice1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 35);
            this.txtPrice1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtUnit1
            // 
            this.txtUnit1.Flex = 1;
            this.txtUnit1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Size = new System.Drawing.Size(100, 35);
            this.txtUnit1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtSPE1
            // 
            this.txtSPE1.Flex = 1;
            this.txtSPE1.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSPE1.Name = "txtSPE1";
            this.txtSPE1.Size = new System.Drawing.Size(100, 35);
            this.txtSPE1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.label14,
            this.label15});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.Text = "地点";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 30);
            this.label14.Text = "库位";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 30);
            this.label15.Text = "模板编号";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtPlace1,
            this.txtSL,
            this.txtATID});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPlace1
            // 
            this.txtPlace1.Flex = 1;
            this.txtPlace1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtPlace1.Name = "txtPlace1";
            this.txtPlace1.Size = new System.Drawing.Size(100, 35);
            this.txtPlace1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtSL
            // 
            this.txtSL.Flex = 1;
            this.txtSL.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 35);
            this.txtSL.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtATID
            // 
            this.txtATID.Flex = 1;
            this.txtATID.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtATID.Name = "txtATID";
            this.txtATID.Size = new System.Drawing.Size(100, 35);
            this.txtATID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label19,
            this.label20,
            this.label21});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // label19
            // 
            this.label19.Flex = 1;
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 30);
            this.label19.Text = "管理者";
            this.label19.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Flex = 1;
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 30);
            this.label20.Text = "供应者";
            this.label20.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Flex = 1;
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 30);
            this.label21.Text = "备注";
            this.label21.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtManager,
            this.txtVendor1,
            this.txtNote1});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 35);
            // 
            // txtManager
            // 
            this.txtManager.Flex = 1;
            this.txtManager.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(100, 35);
            this.txtManager.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtVendor1
            // 
            this.txtVendor1.Flex = 1;
            this.txtVendor1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtVendor1.Name = "txtVendor1";
            this.txtVendor1.Size = new System.Drawing.Size(100, 35);
            this.txtVendor1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtNote1
            // 
            this.txtNote1.Flex = 1;
            this.txtNote1.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(100, 35);
            this.txtNote1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmAssetDetial
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
            this.panel11,
            this.panel12});
            this.Load += new System.EventHandler(this.FrmAssetDetial_Load);

        }
        #endregion

        private Panel panel1;
        private Label labTitle;
        private Label txtAssId1;
        private Panel panel2;
        private Button BackBtn;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label txtName1;
        private Panel panel;
        private Image ImgPicture;
        private Label txtType;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Label txtSN;
        private Label DatePickerBuy;
        private Label DatePickerExpiry;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private Label txtPrice1;
        private Label txtUnit1;
        private Label txtSPE1;
        private Panel panel9;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel10;
        private Label txtPlace1;
        private Label txtSL;
        private Label txtATID;
        private Panel panel11;
        private Label label19;
        private Label label20;
        private Label label21;
        private Panel panel12;
        private Label txtManager;
        private Label txtVendor1;
        private Label txtNote1;
        private Button ViewBtn;
    }
}