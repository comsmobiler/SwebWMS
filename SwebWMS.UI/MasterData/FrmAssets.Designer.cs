using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmAssets : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.GridViewColumn gridViewColumn1 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn2 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn3 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn4 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn5 = new Swebui.Controls.GridViewColumn();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.EditBtn = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.printBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.tpWare = new Swebui.Controls.TreeSelect();
            this.panel4 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtNote = new Swebui.Controls.TextBox();
            this.button1 = new Swebui.Controls.Button();
            this.panel5 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.tpSearch = new Swebui.Controls.TreeSelect();
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
            this.label1.Text = "资产管理列表";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.EditBtn,
            this.ViewBtn,
            this.printBtn,
            this.RefreshBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
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
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.White;
            this.printBtn.Border = new Swebui.Controls.Border(1F);
            this.printBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.printBtn.ForeColor = System.Drawing.Color.DimGray;
            this.printBtn.IconName = "fa fa-print";
            this.printBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.printBtn.Name = "printBtn";
            this.printBtn.NumberOfLines = 0;
            this.printBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.printBtn.Size = new System.Drawing.Size(0, 26);
            this.printBtn.Text = "打印";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
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
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel6,
            this.panel4,
            this.panel5});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // panel6
            // 
            this.panel6.Border = new Swebui.Controls.Border(1F);
            this.panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.tpWare});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(220, 0);
            // 
            // label3
            // 
            this.label3.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Padding = new Swebui.Controls.Padding(0F, 0F, 10F, 0F);
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.Text = "仓库";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // tpWare
            // 
            this.tpWare.DefaultValue = new string[0];
            this.tpWare.DropDownHeight = 280;
            this.tpWare.Flex = 1;
            this.tpWare.ListBackgroundColor = System.Drawing.Color.White;
            this.tpWare.Name = "tpWare";
            this.tpWare.Size = new System.Drawing.Size(200, 0);
            this.tpWare.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.tpWare_Press);
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtNote,
            this.button1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(220, 0);
            // 
            // fontIcon1
            // 
            this.fontIcon1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(12, 12);
            // 
            // txtNote
            // 
            this.txtNote.Border = new Swebui.Controls.Border(1F, 0F, 1F, 0F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtNote.Flex = 1;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(0, 35);
            this.txtNote.SubmitEditing += new System.EventHandler(this.txtNote_SubmitEditing);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 1;
            this.button1.Padding = new Swebui.Controls.Padding(10F);
            this.button1.Size = new System.Drawing.Size(0, 35);
            this.button1.Text = "搜索";
            this.button1.Click += new System.EventHandler(this.txtNote_SubmitEditing);
            // 
            // panel5
            // 
            this.panel5.Border = new Swebui.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.tpSearch});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(220, 0);
            // 
            // label2
            // 
            this.label2.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Padding = new Swebui.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "类型";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // tpSearch
            // 
            this.tpSearch.DefaultValue = new string[0];
            this.tpSearch.DropDownHeight = 280;
            this.tpSearch.Flex = 1;
            this.tpSearch.ListBackgroundColor = System.Drawing.Color.White;
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(200, 0);
            this.tpSearch.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.tpSearch_Press);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn1.DisplayMember = "ASSID";
            gridViewColumn1.HeaderText = "资产编号";
            gridViewColumn2.DisplayMember = "Name";
            gridViewColumn2.HeaderText = "资产名称";
            gridViewColumn3.DisplayMember = "SN";
            gridViewColumn3.HeaderText = "SN";
            gridViewColumn4.DisplayMember = "Price";
            gridViewColumn4.HeaderText = "金额";
            gridViewColumn5.DisplayMember = "SLName";
            gridViewColumn5.HeaderText = "库位";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4,
            gridViewColumn5});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // FrmAssets
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.gridView1});
            this.Load += new System.EventHandler(this.FrmAssets_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button EditBtn;
        private Button ViewBtn;
        private Button printBtn;
        private Panel panel3;
        private GridView gridView1;
        private Panel panel6;
        private Label label3;
        private TreeSelect tpWare;
        private Panel panel4;
        private FontIcon fontIcon1;
        private TextBox txtNote;
        private Button button1;
        private Panel panel5;
        private Label label2;
        private TreeSelect tpSearch;
        private Button RefreshBtn;
    }
}