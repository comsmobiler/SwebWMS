using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class EditPsdDialog : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.txtPwd = new Swebui.Controls.TextBox();
            this.button1 = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.txtPassWord1 = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.txtPassWord2 = new Swebui.Controls.TextBox();
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
            this.label1.Text = "修改密码";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 139);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.txtPwd,
            this.button1});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "原始密码";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPwd
            // 
            this.txtPwd.Border = new Swebui.Controls.Border(1F);
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtPwd.Flex = 1;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.SecurityMode = true;
            this.txtPwd.Size = new System.Drawing.Size(100, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "验证";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.txtPassWord1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            this.panel4.Visible = false;
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "输入密码";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPassWord1
            // 
            this.txtPassWord1.Border = new Swebui.Controls.Border(1F);
            this.txtPassWord1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtPassWord1.Flex = 1;
            this.txtPassWord1.Name = "txtPassWord1";
            this.txtPassWord1.SecurityMode = true;
            this.txtPassWord1.Size = new System.Drawing.Size(100, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.txtPassWord2});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 35);
            this.panel5.Visible = false;
            // 
            // label4
            // 
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "确认密码";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPassWord2
            // 
            this.txtPassWord2.Border = new Swebui.Controls.Border(1F);
            this.txtPassWord2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtPassWord2.Flex = 1;
            this.txtPassWord2.Name = "txtPassWord2";
            this.txtPassWord2.SecurityMode = true;
            this.txtPassWord2.Size = new System.Drawing.Size(100, 0);
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
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
            // EditPsdDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel1,
            this.panel2});
            this.Size = new System.Drawing.Size(500, 400);

        }
        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
        private Panel panel3;
        private Label label2;
        private TextBox txtPwd;
        private Button button1;
        private Panel panel4;
        private Label label3;
        private TextBox txtPassWord1;
        private Panel panel5;
        private Label label4;
        private TextBox txtPassWord2;
    }
}