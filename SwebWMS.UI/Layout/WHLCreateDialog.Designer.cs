using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class WHLCreateDialog : Swebui.Controls.SwebUserControl
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
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtWareID = new Swebui.Controls.Label();
            this.txtWareName = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.txtSTID = new Swebui.Controls.Label();
            this.txtSTName = new Swebui.Controls.Label();
            this.panel1 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.txtSLID = new Swebui.Controls.TextBox();
            this.txtSLName = new Swebui.Controls.TextBox();
            this.panel4 = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.btnManager = new Swebui.Controls.TreeSelect();
            this.txtMAXVOLUME = new Swebui.Controls.TextBox();
            this.panel6 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.txtMAXCAPACITY = new Swebui.Controls.TextBox();
            this.textBox6 = new Swebui.Controls.Label();
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
            this.label1.Text = "新增库位";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label4});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "* 库位编号";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "* 库位名称";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSLID,
            this.txtSLName});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // txtSLID
            // 
            this.txtSLID.Border = new Swebui.Controls.Border(1F);
            this.txtSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSLID.Flex = 1;
            this.txtSLID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtSLID.Name = "txtSLID";
            this.txtSLID.Size = new System.Drawing.Size(100, 35);
            // 
            // txtSLName
            // 
            this.txtSLName.Border = new Swebui.Controls.Border(1F);
            this.txtSLName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSLName.Flex = 1;
            this.txtSLName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSLName.Name = "txtSLName";
            this.txtSLName.Size = new System.Drawing.Size(100, 35);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6,
            this.label7});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 30);
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "* 负责人";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "最大体积";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnManager,
            this.txtMAXVOLUME});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 35);
            // 
            // btnManager
            // 
            this.btnManager.Border = new Swebui.Controls.Border(1F);
            this.btnManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnManager.DefaultValue = new string[0];
            this.btnManager.DropDownHeight = 280;
            this.btnManager.Flex = 1;
            this.btnManager.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(100, 35);
            this.btnManager.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnManager_Press);
            // 
            // txtMAXVOLUME
            // 
            this.txtMAXVOLUME.Border = new Swebui.Controls.Border(1F);
            this.txtMAXVOLUME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtMAXVOLUME.Flex = 1;
            this.txtMAXVOLUME.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtMAXVOLUME.Name = "txtMAXVOLUME";
            this.txtMAXVOLUME.Size = new System.Drawing.Size(100, 35);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.label9});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "最大承重";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtMAXCAPACITY,
            this.textBox6});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 35);
            // 
            // txtMAXCAPACITY
            // 
            this.txtMAXCAPACITY.Border = new Swebui.Controls.Border(1F);
            this.txtMAXCAPACITY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtMAXCAPACITY.Flex = 1;
            this.txtMAXCAPACITY.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtMAXCAPACITY.Name = "txtMAXCAPACITY";
            this.txtMAXCAPACITY.Size = new System.Drawing.Size(100, 35);
            // 
            // textBox6
            // 
            this.textBox6.Flex = 1;
            this.textBox6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 35);
            // 
            // panel2
            // 
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
            // WHLCreateDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel7,
            this.panel8,
            this.panel15,
            this.panel16,
            this.panel1,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel9,
            this.panel2});
            this.Size = new System.Drawing.Size(600, 425);
            this.Load += new System.EventHandler(this.WHLCreateDialog_Load);

        }
        #endregion

        private Label label1;
        private Panel panel7;
        private Label label3;
        private Label label5;
        private Panel panel8;
        private Label txtWareID;
        private Label txtWareName;
        private Panel panel15;
        private Label label10;
        private Label label11;
        private Panel panel16;
        private Label txtSTID;
        private Label txtSTName;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Panel panel3;
        private TextBox txtSLID;
        private TextBox txtSLName;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private Panel panel5;
        private TreeSelect btnManager;
        private TextBox txtMAXVOLUME;
        private Panel panel6;
        private Label label8;
        private Label label9;
        private Panel panel9;
        private TextBox txtMAXCAPACITY;
        private Label  textBox6;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
    }
}