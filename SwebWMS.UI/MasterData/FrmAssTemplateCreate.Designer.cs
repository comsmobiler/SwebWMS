using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmAssTemplateCreate : Swebui.Controls.SwebUserControl
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
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.panel1 = new Swebui.Controls.Panel();
            this.labTitle = new Swebui.Controls.Label();
            this.txtAssID = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.TextBox();
            this.panel = new Swebui.Controls.Panel();
            this.ImgPicture = new Swebui.Controls.Image();
            this.button1 = new Swebui.Controls.Button();
            this.txtUnit = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtPrice = new Swebui.Controls.TextBox();
            this.btnType = new Swebui.Controls.TreeSelect();
            this.txtSpe = new Swebui.Controls.TextBox();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtVendor = new Swebui.Controls.TextBox();
            this.txtNote = new Swebui.Controls.TextBox();
            this.label = new Swebui.Controls.Label();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn});
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
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-floppy-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(0, 26);
            this.SaveBtn.Text = "保存";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.labTitle.Text = "新增资产模板";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // txtAssID
            // 
            this.txtAssID.FontSize = 20F;
            this.txtAssID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Size = new System.Drawing.Size(0, 26);
            this.txtAssID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
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
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "名称";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "图片";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
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
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            this.txtName.WaterMarkText = "(必填)";
            // 
            // panel
            // 
            this.panel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ImgPicture,
            this.button1});
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
            this.ImgPicture.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.ImgPicture.Name = "ImgPicture";
            this.ImgPicture.ResourceID = "";
            this.ImgPicture.Size = new System.Drawing.Size(45, 45);
            this.ImgPicture.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "上传";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.Transparent;
            this.txtUnit.Border = new Swebui.Controls.Border(1F);
            this.txtUnit.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtUnit.Flex = 1;
            this.txtUnit.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 35);
            this.txtUnit.WaterMarkText = "(选填)";
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
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "单价";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "类别";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "规格型号";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtPrice,
            this.btnType,
            this.txtSpe});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Border = new Swebui.Controls.Border(1F);
            this.txtPrice.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtPrice.Flex = 1;
            this.txtPrice.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 35);
            this.txtPrice.WaterMarkText = "(选填)";
            // 
            // btnType
            // 
            this.btnType.Border = new Swebui.Controls.Border(1F);
            this.btnType.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnType.DefaultValue = new string[0];
            this.btnType.DropDownHeight = 280;
            this.btnType.Flex = 1;
            this.btnType.ListBackgroundColor = System.Drawing.Color.White;
            this.btnType.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.btnType.Name = "btnType";
            this.btnType.Placeholder = "(必填)";
            this.btnType.Size = new System.Drawing.Size(100, 35);
            this.btnType.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnType_Press);
            // 
            // txtSpe
            // 
            this.txtSpe.BackColor = System.Drawing.Color.Transparent;
            this.txtSpe.Border = new Swebui.Controls.Border(1F);
            this.txtSpe.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtSpe.Flex = 1;
            this.txtSpe.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtSpe.Name = "txtSpe";
            this.txtSpe.Size = new System.Drawing.Size(100, 35);
            this.txtSpe.WaterMarkText = "(选填)";
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
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "供应商";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "备注";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtVendor,
            this.txtNote,
            this.label});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtVendor
            // 
            this.txtVendor.BackColor = System.Drawing.Color.Transparent;
            this.txtVendor.Border = new Swebui.Controls.Border(1F);
            this.txtVendor.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtVendor.Flex = 1;
            this.txtVendor.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(100, 35);
            this.txtVendor.WaterMarkText = "(选填)";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.Border = new Swebui.Controls.Border(1F);
            this.txtNote.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 35);
            this.txtNote.WaterMarkText = "(选填)";
            // 
            // label
            // 
            this.label.Flex = 1;
            this.label.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 35);
            // 
            // FrmAssTemplateCreate
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
            this.Load += new System.EventHandler(this.FrmAssTemplateCreate_Load);

        }
        #endregion

        private Panel panel2;
        private Button BackBtn;
        private Button SaveBtn;
        private Panel panel1;
        private Label labTitle;
        private Label txtAssID;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private TextBox txtName;
        private Panel panel;
        private TextBox txtUnit;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private TextBox txtPrice;
        private TreeSelect btnType;
        private TextBox txtSpe;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private TextBox txtVendor;
        private TextBox txtNote;
        private Label label;
        private Image ImgPicture;
        private Button button1;
    }
}