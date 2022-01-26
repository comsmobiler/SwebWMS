using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmAssTemplate : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.GridViewColumn gridViewColumn5 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn6 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn7 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn8 = new Swebui.Controls.GridViewColumn();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.AddBtn = new Swebui.Controls.Button();
            this.EditBtn = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtNote = new Swebui.Controls.TextBox();
            this.btnSearch = new Swebui.Controls.Button();
            this.gridView1 = new Swebui.Controls.GridView();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.FontSize = 24F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.Text = "资产模板列表";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.AddBtn,
            this.EditBtn,
            this.ViewBtn,
            this.RefreshBtn,
            this.panel3});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Border = new Swebui.Controls.Border(1F);
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AddBtn.ForeColor = System.Drawing.Color.DimGray;
            this.AddBtn.IconName = "fa fa-plus";
            this.AddBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NumberOfLines = 0;
            this.AddBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.AddBtn.Size = new System.Drawing.Size(0, 26);
            this.AddBtn.Text = "新增";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Border = new Swebui.Controls.Border(1F);
            this.EditBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.EditBtn.ForeColor = System.Drawing.Color.DimGray;
            this.EditBtn.IconName = "fa fa-pencil-square-o";
            this.EditBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.NumberOfLines = 0;
            this.EditBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.EditBtn.Size = new System.Drawing.Size(0, 26);
            this.EditBtn.Text = "编辑";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.ViewBtn.Text = "查看";
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Border = new Swebui.Controls.Border(1F);
            this.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DimGray;
            this.RefreshBtn.IconName = "fa fa-refresh";
            this.RefreshBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.NumberOfLines = 0;
            this.RefreshBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.RefreshBtn.Size = new System.Drawing.Size(0, 26);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtNote,
            this.btnSearch});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 26);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.DimGray;
            this.fontIcon1.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            // 
            // txtNote
            // 
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 20);
            this.txtNote.WaterMarkText = "请输入模板编号或者名称";
            this.txtNote.SubmitEditing += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NumberOfLines = 0;
            this.btnSearch.Size = new System.Drawing.Size(0, 20);
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn5.DisplayMember = "TEMPLATEID";
            gridViewColumn5.HeaderText = "ID";
            gridViewColumn6.DisplayMember = "NAME";
            gridViewColumn6.HeaderText = "名称";
            gridViewColumn7.DisplayMember = "PRICE";
            gridViewColumn7.HeaderText = "单价";
            gridViewColumn8.DisplayMember = "UNIT";
            gridViewColumn8.HeaderText = "单位";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn5,
            gridViewColumn6,
            gridViewColumn7,
            gridViewColumn8});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // FrmAssTemplate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.gridView1});
            this.Load += new System.EventHandler(this.FrmAssTemplate_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button AddBtn;
        private Button EditBtn;
        private Button ViewBtn;
        private Button RefreshBtn;
        private GridView gridView1;
        private Panel panel3;
        private FontIcon fontIcon1;
        private TextBox txtNote;
        private Button btnSearch;
    }
}