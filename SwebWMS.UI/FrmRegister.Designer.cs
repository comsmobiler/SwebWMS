using Swebui.Controls;
using System;

namespace SwebWMS.UI
{
    partial class FrmRegister : Swebui.Controls.SwebForm
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
            Swebui.Controls.TreeSelectNode treeSelectNode3 = new Swebui.Controls.TreeSelectNode();
            this.panel1 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.txtTel = new Swebui.Controls.TextBox();
            this.button1 = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.txtVcode1 = new Swebui.Controls.TextBox();
            this.label3 = new Swebui.Controls.Label();
            this.button3 = new Swebui.Controls.Button();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.txtName = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.txtPwd1 = new Swebui.Controls.TextBox();
            this.panel9 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.txtPwd2 = new Swebui.Controls.TextBox();
            this.panel10 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.comboBox1 = new Swebui.Controls.TreeSelect();
            this.button5 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 8;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5,
            this.panel6});
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel4.Border = new Swebui.Controls.Border(4F, 0F, 0F, 0F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel4.Size = new System.Drawing.Size(600, 44);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "用户注册";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.button3});
            this.panel5.Flex = 1;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.txtTel,
            this.button1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel2.Size = new System.Drawing.Size(600, 35);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "手机号";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.Border = new Swebui.Controls.Border(1F);
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.txtTel.Flex = 1;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 35);
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.Text = "获取验证码";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.txtVcode1,
            this.label3});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel3.Size = new System.Drawing.Size(600, 35);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "验证码";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtVcode1
            // 
            this.txtVcode1.Border = new Swebui.Controls.Border(1F);
            this.txtVcode1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.txtVcode1.Flex = 1;
            this.txtVcode1.Name = "txtVcode1";
            this.txtVcode1.Size = new System.Drawing.Size(100, 35);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Name = "label3";
            this.label3.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(106, 35);
            this.label3.Text = "验证码请使用1234";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Size = new System.Drawing.Size(106, 35);
            this.button3.Text = "注册";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.button5});
            this.panel6.Flex = 1;
            this.panel6.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 100);
            this.panel6.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.txtName});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel7.Size = new System.Drawing.Size(600, 35);
            // 
            // label5
            // 
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "昵称";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.txtName.Flex = 1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.txtPwd1});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel8.Size = new System.Drawing.Size(600, 35);
            // 
            // label7
            // 
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 35);
            this.label7.Text = "输入密码";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Border = new Swebui.Controls.Border(1F);
            this.txtPwd1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.txtPwd1.Flex = 1;
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.SecurityMode = true;
            this.txtPwd1.Size = new System.Drawing.Size(100, 35);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.txtPwd2});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel9.Size = new System.Drawing.Size(600, 35);
            // 
            // label8
            // 
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.Text = "确认密码";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Border = new Swebui.Controls.Border(1F);
            this.txtPwd2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.txtPwd2.Flex = 1;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.SecurityMode = true;
            this.txtPwd2.Size = new System.Drawing.Size(100, 35);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.comboBox1});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel10.Size = new System.Drawing.Size(600, 35);
            // 
            // label9
            // 
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            this.label9.Text = "角色选择";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Border = new Swebui.Controls.Border(1F);
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.comboBox1.DefaultValue = new string[0];
            this.comboBox1.Flex = 1;
            this.comboBox1.ListBackgroundColor = System.Drawing.Color.White;
            this.comboBox1.Name = "comboBox1";
            treeSelectNode1.Text = "管理员";
            treeSelectNode1.TreeID = "ADMIN";
            treeSelectNode2.Text = "WMS管理员";
            treeSelectNode2.TreeID = "SMOWMSADMIN";
            treeSelectNode3.Text = "用户";
            treeSelectNode3.TreeID = "SMOWMSUser";
            this.comboBox1.Nodes.AddRange(new Swebui.Controls.TreeSelectNode[] {
            treeSelectNode1,
            treeSelectNode2,
            treeSelectNode3});
            this.comboBox1.Size = new System.Drawing.Size(100, 35);
            this.comboBox1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.comboBox1_Press);
            // 
            // button5
            // 
            this.button5.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Size = new System.Drawing.Size(106, 35);
            this.button5.Text = "开始使用";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmRegister
            // 
            this.BackgroundImage = "bg.png";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;

        }
        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Panel panel2;
        private Label label1;
        private TextBox txtTel;
        private Button button1;
        private Panel panel3;
        private Label label2;
        private TextBox txtVcode1;
        private Label label3;
        private Button button3;
        private Panel panel6;
        private Panel panel7;
        private Label label5;
        private TextBox txtName;
        private Panel panel8;
        private Label label7;
        private TextBox txtPwd1;
        private Panel panel9;
        private Label label8;
        private TextBox txtPwd2;
        private Panel panel10;
        private Label label9;
        private TreeSelect comboBox1;
        private Button button5;
        internal Button btnLocation;
    }
}