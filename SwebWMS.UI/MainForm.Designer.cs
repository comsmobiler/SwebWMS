using Swebui;
using System;

namespace SwebWMS.UI
{
    partial class MainForm : Swebui.Controls.SwebForm
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
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.exitBtn = new Swebui.Controls.Button();
            this.useBtn = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.menuView1 = new Swebui.Controls.MenuView();
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.exitBtn,
            this.useBtn});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 50);
            this.label1.Text = "Sweb WMS";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Bold = true;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.exitBtn.IconName = "fa fa-sign-out";
            this.exitBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.NumberOfLines = 0;
            this.exitBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.exitBtn.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.exitBtn.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.exitBtn.Size = new System.Drawing.Size(0, 60);
            this.exitBtn.Text = "退出";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // useBtn
            // 
            this.useBtn.BackColor = System.Drawing.Color.Transparent;
            this.useBtn.Bold = true;
            this.useBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.useBtn.IconName = "fa fa-user";
            this.useBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.useBtn.Name = "useBtn";
            this.useBtn.NumberOfLines = 0;
            this.useBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.useBtn.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.useBtn.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.useBtn.Size = new System.Drawing.Size(0, 60);
            this.useBtn.Text = "admin";
            this.useBtn.Click += new System.EventHandler(this.useBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.menuView1,
            this.tabPageView1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // menuView1
            // 
            this.menuView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.menuView1.Color = System.Drawing.Color.White;
            this.menuView1.DefaultIcon = "tasks";
            this.menuView1.Name = "menuView1";
            this.menuView1.Size = new System.Drawing.Size(200, 0);
            this.menuView1.MenuItemClick += new Swebui.Controls.MenuViewItemClickEventHandler(this.menuView1_MenuItemClick);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Margin = new Swebui.Controls.Margin(10F);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.None;
            this.tabPageView1.Size = new System.Drawing.Size(100, 0);
            // 
            // MainForm
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Load += new System.EventHandler(this.MainForm_Load);

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.Button exitBtn;
        private Swebui.Controls.Button useBtn;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.MenuView menuView1;
        private Swebui.Controls.TabPageView tabPageView1;
    }
}