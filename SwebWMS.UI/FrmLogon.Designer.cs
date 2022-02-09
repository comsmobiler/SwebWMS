using Swebui;
using System;

namespace SwebWMS.UI
{
    partial class FrmLogon : Swebui.Controls.SwebForm
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
            this.image1 = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.image2 = new Swebui.Controls.Image();
            this.psdPanel = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtUserName = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.fontIcon2 = new Swebui.Controls.FontIcon();
            this.txtPassWord = new Swebui.Controls.TextBox();
            this.loginBtn = new Swebui.Controls.Button();
            this.panel6 = new Swebui.Controls.Panel();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(600, 400);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "login_from_left.png.png";
            this.image1.Size = new System.Drawing.Size(300, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2,
            this.psdPanel});
            this.panel2.Name = "panel2";
            this.panel2.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel2.Scrollable = true;
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // image2
            // 
            this.image2.BorderRadius = 4;
            this.image2.BorderStyle = Swebui.Controls.BorderStyle.Dotted;
            this.image2.Margin = new Swebui.Controls.Margin(0F, 50F, 0F, 0F);
            this.image2.Name = "image2";
            this.image2.ResourceID = "smowms.png";
            this.image2.Size = new System.Drawing.Size(0, 100);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // psdPanel
            // 
            this.psdPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel5,
            this.loginBtn,
            this.panel6});
            this.psdPanel.Flex = 1;
            this.psdPanel.Name = "psdPanel";
            this.psdPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel3.BorderRadius = 4;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtUserName});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(20F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 32);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.fontIcon1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "user";
            this.fontIcon1.Size = new System.Drawing.Size(16, 16);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.txtUserName.Flex = 1;
            this.txtUserName.FontSize = 12F;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtUserName.Size = new System.Drawing.Size(100, 32);
            this.txtUserName.WaterMarkText = "账号";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
            this.panel5.Border = new Swebui.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel5.BorderRadius = 4;
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon2,
            this.txtPassWord});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel5.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 32);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.fontIcon2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "unlock-alt";
            this.fontIcon2.Size = new System.Drawing.Size(16, 16);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.txtPassWord.Flex = 1;
            this.txtPassWord.FontSize = 12F;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtPassWord.SecurityMode = true;
            this.txtPassWord.Size = new System.Drawing.Size(100, 32);
            this.txtPassWord.WaterMarkText = "密码";
            this.txtPassWord.SubmitEditing += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NumberOfLines = 0;
            this.loginBtn.Size = new System.Drawing.Size(0, 35);
            this.loginBtn.Text = "登录";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button2,
            this.button3});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.SpaceBetween;
            this.panel6.Margin = new Swebui.Controls.Margin(20F, 20F, 20F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 38);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button2.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button2.Size = new System.Drawing.Size(99, 0);
            this.button2.Text = "演示账号";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button3.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button3.Size = new System.Drawing.Size(100, 0);
            this.button3.Text = "注册";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmLogon
            // 
            this.BackgroundImage = "login_bg.jpg";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Image image1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.Image image2;
        private Swebui.Controls.Panel psdPanel;
        private Swebui.Controls.Panel panel3;
        private Swebui.Controls.FontIcon fontIcon1;
        private Swebui.Controls.TextBox txtUserName;
        private Swebui.Controls.Panel panel5;
        private Swebui.Controls.FontIcon fontIcon2;
        private Swebui.Controls.TextBox txtPassWord;
        private Swebui.Controls.Button loginBtn;
        private Swebui.Controls.Panel panel6;
        private Swebui.Controls.Button button2;
        private Swebui.Controls.Button button3;
    }
}