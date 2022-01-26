using Swebui.Controls;
using System;

namespace SwebWMS.UI.ConsumablesManager
{
    partial class FrmConInventoryCreate : Swebui.Controls.SwebUserControl
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
            this.lblIID = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.TextBox();
            this.btnManager = new Swebui.Controls.TreeSelect();
            this.btnWareHouse = new Swebui.Controls.TreeSelect();
            this.panel5 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.btnST = new Swebui.Controls.TreeSelect();
            this.btnSL = new Swebui.Controls.TreeSelect();
            this.label = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.lblIID});
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
            this.labTitle.Text = "新增耗材盘点单";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // lblIID
            // 
            this.lblIID.FontSize = 20F;
            this.lblIID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblIID.Name = "lblIID";
            this.lblIID.Size = new System.Drawing.Size(0, 26);
            this.lblIID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn,
            this.DeleteBtn});
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
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Border = new Swebui.Controls.Border(1F);
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.IconName = "fa fa-trash-o";
            this.DeleteBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NumberOfLines = 0;
            this.DeleteBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DeleteBtn.Size = new System.Drawing.Size(0, 26);
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "盘点单名";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "盘点人";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "仓库";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.btnManager,
            this.btnWareHouse});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            // 
            // btnManager
            // 
            this.btnManager.Border = new Swebui.Controls.Border(1F);
            this.btnManager.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnManager.DefaultValue = new string[0];
            this.btnManager.DropDownHeight = 280;
            this.btnManager.Flex = 1;
            this.btnManager.ListBackgroundColor = System.Drawing.Color.White;
            this.btnManager.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(100, 35);
            this.btnManager.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnManager_Press);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.Border = new Swebui.Controls.Border(1F);
            this.btnWareHouse.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnWareHouse.DefaultValue = new string[0];
            this.btnWareHouse.DropDownHeight = 280;
            this.btnWareHouse.Flex = 1;
            this.btnWareHouse.ListBackgroundColor = System.Drawing.Color.White;
            this.btnWareHouse.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Size = new System.Drawing.Size(100, 35);
            this.btnWareHouse.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnWareHouse_Press_1);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label5,
            this.label6});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "存储类型";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "库位";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnST,
            this.btnSL,
            this.label});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // btnST
            // 
            this.btnST.Border = new Swebui.Controls.Border(1F);
            this.btnST.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnST.DefaultValue = new string[0];
            this.btnST.DropDownHeight = 280;
            this.btnST.Flex = 1;
            this.btnST.ListBackgroundColor = System.Drawing.Color.White;
            this.btnST.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(100, 35);
            this.btnST.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnST_Press_1);
            // 
            // btnSL
            // 
            this.btnSL.Border = new Swebui.Controls.Border(1F);
            this.btnSL.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnSL.DefaultValue = new string[0];
            this.btnSL.DropDownHeight = 280;
            this.btnSL.Flex = 1;
            this.btnSL.ListBackgroundColor = System.Drawing.Color.White;
            this.btnSL.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(100, 35);
            this.btnSL.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnSL_Press);
            // 
            // label
            // 
            this.label.Flex = 1;
            this.label.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 35);
            // 
            // FrmConInventoryCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6});
            this.Load += new System.EventHandler(this.FrmConInventoryCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label labTitle;
        private Label lblIID;
        private Panel panel2;
        private Button BackBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TextBox txtName;
        private TreeSelect btnManager;
        private TreeSelect btnWareHouse;
        private Panel panel5;
        private Label label1;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private TreeSelect btnST;
        private TreeSelect btnSL;
        private Label label;
    }
}