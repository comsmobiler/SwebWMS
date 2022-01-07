using Swebui;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmWarehouse : Swebui.Controls.SwebUserControl
    {
        #region "SwebForm generated code "

        //SwebForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SwebForm
        //It can be modified using the SwebForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Swebui.Controls.Panel();
            this.lblTitle = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.treeView1 = new Swebui.Controls.TreeView();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.labTitle = new Swebui.Controls.Label();
            this.editBtn = new Swebui.Controls.Button();
            this.addTypeBtn = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtWareID = new Swebui.Controls.Label();
            this.txtWareName = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.btnManager = new Swebui.Controls.Label();
            this.txtPlace = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.switchIsEnable = new Swebui.Controls.Switch();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel13 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel14 = new Swebui.Controls.Panel();
            this.txtWareID1 = new Swebui.Controls.Label();
            this.txtWareName1 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.txtSTID = new Swebui.Controls.Label();
            this.txtSTName = new Swebui.Controls.Label();
            this.panel17 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel18 = new Swebui.Controls.Panel();
            this.tpSswitchIsEnable = new Swebui.Controls.Switch();
            this.labPanel = new Swebui.Controls.Panel();
            this.label15 = new Swebui.Controls.Label();
            this.addBtn = new Swebui.Controls.Button();
            this.WHSLPanel = new Swebui.Controls.Panel();
            this.panel19 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
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
            this.lblTitle.Text = "仓库管理";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeView1,
            this.panel3});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // treeView1
            // 
            this.treeView1.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.treeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.treeView1.DefaultValue = new string[0];
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.treeView1.Size = new System.Drawing.Size(240, 0);
            this.treeView1.Press += new Swebui.Controls.TreeView.TreeViewOnPressEventHandler(this.treeView1_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel6,
            this.panel4,
            this.panel5,
            this.labPanel,
            this.WHSLPanel});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.editBtn,
            this.addTypeBtn});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel6.Size = new System.Drawing.Size(0, 44);
            // 
            // labTitle
            // 
            this.labTitle.Flex = 1;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(0, 0);
            this.labTitle.Text = "仓库信息";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Border = new Swebui.Controls.Border(1F);
            this.editBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.editBtn.BorderRadius = 8;
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.editBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.editBtn.Name = "editBtn";
            this.editBtn.NumberOfLines = 0;
            this.editBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.editBtn.Size = new System.Drawing.Size(0, 0);
            this.editBtn.Text = "编辑仓库";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addTypeBtn
            // 
            this.addTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.addTypeBtn.Border = new Swebui.Controls.Border(1F);
            this.addTypeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addTypeBtn.BorderRadius = 8;
            this.addTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addTypeBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.addTypeBtn.Name = "addTypeBtn";
            this.addTypeBtn.NumberOfLines = 0;
            this.addTypeBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.addTypeBtn.Size = new System.Drawing.Size(0, 0);
            this.addTypeBtn.Text = "新增分类";
            this.addTypeBtn.Click += new System.EventHandler(this.addTypeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12});
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label5});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "仓库编码";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "仓库名称";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtWareID,
            this.txtWareName});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtWareID
            // 
            this.txtWareID.Flex = 1;
            this.txtWareID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtWareID.Name = "txtWareID";
            this.txtWareID.Size = new System.Drawing.Size(100, 35);
            this.txtWareID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtWareName
            // 
            this.txtWareName.Flex = 1;
            this.txtWareName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtWareName.Name = "txtWareName";
            this.txtWareName.Size = new System.Drawing.Size(100, 35);
            this.txtWareName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label6});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "负责人";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "地点";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnManager,
            this.txtPlace});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // btnManager
            // 
            this.btnManager.Flex = 1;
            this.btnManager.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(100, 35);
            this.btnManager.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPlace
            // 
            this.txtPlace.Flex = 1;
            this.txtPlace.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 35);
            this.txtPlace.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "是否启用";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.switchIsEnable});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 35);
            // 
            // switchIsEnable
            // 
            this.switchIsEnable.BackColor = System.Drawing.Color.Transparent;
            this.switchIsEnable.BorderColor = System.Drawing.Color.Black;
            this.switchIsEnable.BorderRadius = 0;
            this.switchIsEnable.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.switchIsEnable.Name = "switchIsEnable";
            this.switchIsEnable.Size = new System.Drawing.Size(100, 35);
            this.switchIsEnable.CheckedChanged += new System.EventHandler(this.switchIsEnable_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel13,
            this.panel14,
            this.panel15,
            this.panel16,
            this.panel17,
            this.panel18});
            this.panel5.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label9});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 30);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "仓库编码";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.txtWareID1,
            this.txtWareName1});
            this.panel14.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(0, 35);
            // 
            // txtWareID1
            // 
            this.txtWareID1.Flex = 1;
            this.txtWareID1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtWareID1.Name = "txtWareID1";
            this.txtWareID1.Size = new System.Drawing.Size(100, 35);
            this.txtWareID1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtWareName1
            // 
            this.txtWareName1.Flex = 1;
            this.txtWareName1.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtWareName1.Name = "txtWareName1";
            this.txtWareName1.Size = new System.Drawing.Size(100, 35);
            this.txtWareName1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.txtSTID.Flex = 1;
            this.txtSTID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtSTID.Name = "txtSTID";
            this.txtSTID.Size = new System.Drawing.Size(100, 35);
            this.txtSTID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtSTName
            // 
            this.txtSTName.Flex = 1;
            this.txtSTName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.Size = new System.Drawing.Size(100, 35);
            this.txtSTName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.tpSswitchIsEnable});
            this.panel18.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(0, 35);
            // 
            // tpSswitchIsEnable
            // 
            this.tpSswitchIsEnable.BackColor = System.Drawing.Color.Transparent;
            this.tpSswitchIsEnable.BorderColor = System.Drawing.Color.Black;
            this.tpSswitchIsEnable.BorderRadius = 0;
            this.tpSswitchIsEnable.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.tpSswitchIsEnable.Name = "tpSswitchIsEnable";
            this.tpSswitchIsEnable.Size = new System.Drawing.Size(100, 35);
            this.tpSswitchIsEnable.CheckedChanged += new System.EventHandler(this.tpSswitchIsEnable_CheckedChanged);
            // 
            // labPanel
            // 
            this.labPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.labPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label15,
            this.addBtn});
            this.labPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.labPanel.Name = "labPanel";
            this.labPanel.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.labPanel.Size = new System.Drawing.Size(0, 44);
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 0);
            this.label15.Text = "库位管理";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Border = new Swebui.Controls.Border(1F);
            this.addBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addBtn.BorderRadius = 8;
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.addBtn.Name = "addBtn";
            this.addBtn.NumberOfLines = 0;
            this.addBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.addBtn.Size = new System.Drawing.Size(0, 0);
            this.addBtn.Text = "新增库位";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // WHSLPanel
            // 
            this.WHSLPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.WHSLPanel.Flex = 1;
            this.WHSLPanel.Name = "WHSLPanel";
            this.WHSLPanel.Size = new System.Drawing.Size(0, 135);
            this.WHSLPanel.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel19.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1});
            this.panel19.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel19.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel19.Name = "panel19";
            this.panel19.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel19.Size = new System.Drawing.Size(0, 46);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.IconName = "fa fa-plus";
            this.button1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button1.Size = new System.Drawing.Size(0, 26);
            this.button1.Text = "新增仓库";
            this.button1.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FrmWarehouse
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel19,
            this.panel2});
            this.Load += new System.EventHandler(this.FrmWarehouse_Load);

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Label lblTitle;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.TreeView treeView1;
        private Swebui.Controls.Panel panel3;
        private Swebui.Controls.Panel panel6;
        private Swebui.Controls.Label labTitle;
        private Swebui.Controls.Button editBtn;
        private Swebui.Controls.Panel panel4;
        private Swebui.Controls.Panel panel7;
        private Swebui.Controls.Label label3;
        private Swebui.Controls.Label label5;
        private Swebui.Controls.Panel panel8;
        private Swebui.Controls.Label txtWareID;
        private Swebui.Controls.Label txtWareName;
        private Swebui.Controls.Panel panel9;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.Label label6;
        private Swebui.Controls.Panel panel10;
        private Swebui.Controls.Label btnManager;
        private Swebui.Controls.Label txtPlace;
        private Swebui.Controls.Panel panel11;
        private Swebui.Controls.Label label7;
        private Swebui.Controls.Label label8;
        private Swebui.Controls.Panel panel12;
        private Swebui.Controls.Switch  switchIsEnable;
        private Swebui.Controls.Panel panel5;
        private Swebui.Controls.Panel panel13;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.Label label9;
        private Swebui.Controls.Panel panel14;
        private Swebui.Controls.Label  txtWareID1;
        private Swebui.Controls.Label  txtWareName1;
        private Swebui.Controls.Panel panel15;
        private Swebui.Controls.Label label10;
        private Swebui.Controls.Label label11;
        private Swebui.Controls.Panel panel16;
        private Swebui.Controls.Label  txtSTID;
        private Swebui.Controls.Label txtSTName;
        private Swebui.Controls.Panel panel17;
        private Swebui.Controls.Label label12;
        private Swebui.Controls.Label label13;
        private Swebui.Controls.Panel panel18;
        private Swebui.Controls.Switch tpSswitchIsEnable;
        private Swebui.Controls.Panel labPanel;
        private Swebui.Controls.Label label15;
        private Swebui.Controls.Button addBtn;
        private Swebui.Controls.Panel WHSLPanel;
        private Swebui.Controls.Button addTypeBtn;
        private Swebui.Controls.Panel panel19;
        private Swebui.Controls.Button button1;
    }
}