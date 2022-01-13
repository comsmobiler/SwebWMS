using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class WarehouseCreateDialog : Swebui.Controls.SwebUserControl
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
            this.txtWareID = new Swebui.Controls.TextBox();
            this.txtWareName = new Swebui.Controls.TextBox();
            this.panel9 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.btnManager = new Swebui.Controls.TreeSelect();
            this.txtPlace = new Swebui.Controls.TextBox();
            this.panel11 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.switchIsEnable = new Swebui.Controls.Switch();
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
            this.label1.Text = "新增仓库";
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
            this.txtWareID.Border = new Swebui.Controls.Border(1F);
            this.txtWareID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtWareID.Flex = 1;
            this.txtWareID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtWareID.Name = "txtWareID";
            this.txtWareID.Size = new System.Drawing.Size(100, 35);
            // 
            // txtWareName
            // 
            this.txtWareName.Border = new Swebui.Controls.Border(1F);
            this.txtWareName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtWareName.Flex = 1;
            this.txtWareName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtWareName.Name = "txtWareName";
            this.txtWareName.Size = new System.Drawing.Size(100, 35);
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
            this.btnManager.Border = new Swebui.Controls.Border(1F);
            this.btnManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnManager.DefaultValue = new string[0];
            this.btnManager.DropDownHeight = 280;
            this.btnManager.Flex = 1;
            this.btnManager.ListBackgroundColor = System.Drawing.Color.White;
            this.btnManager.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(100, 35);
            this.btnManager.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnManager_Press);
            // 
            // txtPlace
            // 
            this.txtPlace.Border = new Swebui.Controls.Border(1F);
            this.txtPlace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtPlace.Flex = 1;
            this.txtPlace.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 35);
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
            this.panel12.Flex = 1;
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
            // WarehouseCreateDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12,
            this.panel2});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.WarehouseCreateDialog_Load);

        }
        #endregion

        private Label label1;
        private Panel panel7;
        private Label label3;
        private Label label5;
        private Panel panel8;
        private TextBox txtWareID;
        private TextBox txtWareName;
        private Panel panel9;
        private Label label2;
        private Label label6;
        private Panel panel10;
        private TreeSelect btnManager;
        private TextBox txtPlace;
        private Panel panel11;
        private Label label7;
        private Label label8;
        private Panel panel12;
        private Switch switchIsEnable;
        private Panel panel2;
        private Button saveBtn;
        private Button cancelBtn;
    }
}