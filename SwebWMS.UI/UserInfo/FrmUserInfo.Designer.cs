using Swebui.Controls;
using System;

namespace SwebWMS.UI.UserInfo
{
    partial class FrmUserInfo : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.TreeSelectNode treeSelectNode1 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode2 = new Swebui.Controls.TreeSelectNode();
            this.panel1 = new Swebui.Controls.Panel();
            this.userImg1 = new Swebui.Controls.Image();
            this.btnName1 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.labTel = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.editBtn = new Swebui.Controls.Button();
            this.saveBtn = new Swebui.Controls.Button();
            this.cancelBtn = new Swebui.Controls.Button();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel13 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel14 = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.userImg = new Swebui.Controls.Image();
            this.button1 = new Swebui.Controls.Button();
            this.psdChange = new Swebui.Controls.Button();
            this.panel5 = new Swebui.Controls.Panel();
            this.lab = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.btnSex = new Swebui.Controls.TreeSelect();
            this.btnName = new Swebui.Controls.TextBox();
            this.panel9 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.dpkBirthday = new Swebui.Controls.DatePicker();
            this.btnEmail = new Swebui.Controls.TextBox();
            this.panel11 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.txtAddress = new Swebui.Controls.TextBox();
            this.txtPhone = new Swebui.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.userImg1,
            this.btnName1,
            this.panel3});
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Swebui.Controls.Padding(20F, 40F, 20F, 10F);
            this.panel1.Size = new System.Drawing.Size(300, 0);
            // 
            // userImg1
            // 
            this.userImg1.Name = "userImg1";
            this.userImg1.ResourceID = "logon.png";
            this.userImg1.Size = new System.Drawing.Size(0, 210);
            this.userImg1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // btnName1
            // 
            this.btnName1.FontSize = 16F;
            this.btnName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnName1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(0, 49);
            this.btnName1.Text = "smobiler管理员";
            this.btnName1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.labTel});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "电话";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // labTel
            // 
            this.labTel.Flex = 1;
            this.labTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labTel.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(0, 35);
            this.labTel.Text = "13123456789";
            this.labTel.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel6});
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel4.Border = new Swebui.Controls.Border(4F, 0F, 0F, 0F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.editBtn,
            this.saveBtn,
            this.cancelBtn});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel4.Size = new System.Drawing.Size(0, 44);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "个人信息";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.editBtn.Text = "编辑";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Border = new Swebui.Controls.Border(1F);
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.saveBtn.BorderRadius = 8;
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.saveBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.NumberOfLines = 0;
            this.saveBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.saveBtn.Size = new System.Drawing.Size(0, 0);
            this.saveBtn.Text = "保存";
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Border = new Swebui.Controls.Border(1F);
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.cancelBtn.BorderRadius = 8;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.cancelBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.NumberOfLines = 0;
            this.cancelBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.cancelBtn.Size = new System.Drawing.Size(0, 0);
            this.cancelBtn.Text = "取消";
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel13,
            this.panel14,
            this.panel5,
            this.panel7,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12});
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 0);
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label10});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 30);
            this.label5.Text = "头像";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 30);
            this.label10.Text = "密码";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel8,
            this.psdChange});
            this.panel14.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(0, 120);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.userImg,
            this.button1});
            this.panel8.Flex = 1;
            this.panel8.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel8.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 120);
            // 
            // userImg
            // 
            this.userImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.userImg.BorderRadius = 80;
            this.userImg.Margin = new Swebui.Controls.Margin(0F, 5F, 0F, 5F);
            this.userImg.Name = "userImg";
            this.userImg.ResourceID = "logon.png";
            this.userImg.Size = new System.Drawing.Size(80, 80);
            this.userImg.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.Text = "更换头像";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // psdChange
            // 
            this.psdChange.BackColor = System.Drawing.Color.Transparent;
            this.psdChange.Border = new Swebui.Controls.Border(1F);
            this.psdChange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.psdChange.Flex = 1;
            this.psdChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.psdChange.Margin = new Swebui.Controls.Margin(10F, 15F, 20F, 10F);
            this.psdChange.Name = "psdChange";
            this.psdChange.NumberOfLines = 0;
            this.psdChange.Size = new System.Drawing.Size(0, 30);
            this.psdChange.Text = "修改登录密码";
            this.psdChange.Click += new System.EventHandler(this.psdChange_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lab,
            this.label7});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // lab
            // 
            this.lab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lab.Flex = 1;
            this.lab.ForeColor = System.Drawing.Color.DimGray;
            this.lab.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(0, 30);
            this.lab.Text = "性别";
            this.lab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 30);
            this.label7.Text = "昵称";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnSex,
            this.btnName});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // btnSex
            // 
            this.btnSex.Border = new Swebui.Controls.Border(1F);
            this.btnSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSex.DefaultValue = new string[0];
            this.btnSex.Disabled = true;
            this.btnSex.Flex = 1;
            this.btnSex.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.btnSex.Name = "btnSex";
            treeSelectNode1.Text = "男";
            treeSelectNode1.TreeID = "0";
            treeSelectNode2.Text = "女";
            treeSelectNode2.TreeID = "1";
            this.btnSex.Nodes.AddRange(new Swebui.Controls.TreeSelectNode[] {
            treeSelectNode1,
            treeSelectNode2});
            this.btnSex.Size = new System.Drawing.Size(0, 35);
            this.btnSex.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnSex_Press);
            // 
            // btnName
            // 
            this.btnName.Border = new Swebui.Controls.Border(1F);
            this.btnName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnName.Flex = 1;
            this.btnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnName.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.btnName.Name = "btnName";
            this.btnName.ReadOnly = true;
            this.btnName.Size = new System.Drawing.Size(0, 35);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.label8});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label9
            // 
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 30);
            this.label9.Text = "生日";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 30);
            this.label8.Text = "邮箱";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.dpkBirthday,
            this.btnEmail});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.Border = new Swebui.Controls.Border(1F);
            this.dpkBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpkBirthday.Enable = false;
            this.dpkBirthday.Flex = 1;
            this.dpkBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpkBirthday.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.dpkBirthday.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Size = new System.Drawing.Size(0, 35);
            this.dpkBirthday.Value = new System.DateTime(2021, 11, 2, 15, 1, 50, 0);
            // 
            // btnEmail
            // 
            this.btnEmail.Border = new Swebui.Controls.Border(1F);
            this.btnEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnEmail.Flex = 1;
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEmail.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.ReadOnly = true;
            this.btnEmail.Size = new System.Drawing.Size(0, 35);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label3});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.Text = "地址";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.Text = "电话";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtAddress,
            this.txtPhone});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 35);
            // 
            // txtAddress
            // 
            this.txtAddress.Border = new Swebui.Controls.Border(1F);
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAddress.Flex = 1;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAddress.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPhone
            // 
            this.txtPhone.Border = new Swebui.Controls.Border(1F);
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtPhone.Flex = 1;
            this.txtPhone.Margin = new Swebui.Controls.Margin(10F, 0F, 20F, 0F);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 0);
            // 
            // FrmUserInfo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);

        }
        #endregion

        private Panel panel1;
        private Image userImg1;
        private Label btnName1;
        private Panel panel3;
        private Label label2;
        private Label labTel;
        private Panel panel2;
        private Panel panel4;
        private Label label4;
        private Button editBtn;
        private Button saveBtn;
        private Button cancelBtn;
        private Panel panel6;
        private Panel panel5;
        private Label lab;
        private Label label7;
        private Panel panel7;
        private TreeSelect btnSex;
        private TextBox btnName;
        private Panel panel9;
        private Panel panel10;
        private DatePicker dpkBirthday;
        private TextBox btnEmail;
        private Panel panel11;
        private Label label1;
        private Label label3;
        private Panel panel12;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Panel panel13;
        private Label label5;
        private Label label10;
        private Panel panel14;
        private Panel panel8;
        private Image userImg;
        private Button button1;
        private Label label9;
        private Label label8;
        private Button psdChange;
    }
}