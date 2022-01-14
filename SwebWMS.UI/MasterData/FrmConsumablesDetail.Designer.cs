using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmConsumablesDetail : Swebui.Controls.SwebUserControl
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
            this.txtAssID = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.Label();
            this.panel = new Swebui.Controls.Panel();
            this.ImgPicture = new Swebui.Controls.Image();
            this.txtUnit = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtSpe = new Swebui.Controls.Label();
            this.txtSPQ = new Swebui.Controls.Label();
            this.txtCeiling = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtFloor = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.Label();
            this.label = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.txtAssID});
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
            this.labTitle.Text = "耗材详情";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // txtAssID
            // 
            this.txtAssID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Size = new System.Drawing.Size(0, 26);
            this.txtAssID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
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
            this.ViewBtn.Text = "库存分布";
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
            this.label3.Text = "单位";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.panel,
            this.txtUnit});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 55);
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            this.txtName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // txtUnit
            // 
            this.txtUnit.Flex = 1;
            this.txtUnit.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 35);
            this.txtUnit.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.label4.Text = "规格型号";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "标准包装数量";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "安全库存上限";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtSpe,
            this.txtSPQ,
            this.txtCeiling});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtSpe
            // 
            this.txtSpe.Flex = 1;
            this.txtSpe.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtSpe.Name = "txtSpe";
            this.txtSpe.Size = new System.Drawing.Size(100, 35);
            this.txtSpe.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtSPQ
            // 
            this.txtSPQ.Flex = 1;
            this.txtSPQ.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtSPQ.Name = "txtSPQ";
            this.txtSPQ.Size = new System.Drawing.Size(100, 35);
            this.txtSPQ.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtCeiling
            // 
            this.txtCeiling.Flex = 1;
            this.txtCeiling.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtCeiling.Name = "txtCeiling";
            this.txtCeiling.Size = new System.Drawing.Size(100, 35);
            this.txtCeiling.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8,
            this.label9});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(800, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "安全库存下限";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "备注";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFloor,
            this.txtNote,
            this.label});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtFloor
            // 
            this.txtFloor.Flex = 1;
            this.txtFloor.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(100, 35);
            this.txtFloor.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtNote
            // 
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 35);
            this.txtNote.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label
            // 
            this.label.Flex = 1;
            this.label.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 35);
            this.label.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmConsumablesDetail
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
            this.panel8});
            this.Load += new System.EventHandler(this.FrmConsumablesDetail_Load);

        }
        #endregion

        private Panel panel1;
        private Label labTitle;
        private Label txtAssID;
        private Panel panel2;
        private Button BackBtn;
        private Button ViewBtn;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label txtName;
        private Panel panel;
        private Image ImgPicture;
        private Label txtUnit;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Label txtSpe;
        private Label txtSPQ;
        private Label txtCeiling;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private Label txtFloor;
        private Label txtNote;
        private Label label;
    }
}