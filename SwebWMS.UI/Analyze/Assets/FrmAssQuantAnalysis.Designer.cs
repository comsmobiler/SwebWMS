using Swebui.Controls;
using System;

namespace SwebWMS.UI.Analyze
{
    partial class FrmAssQuantAnalysis : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.btnWare = new Swebui.Controls.TreeSelect();
            this.label3 = new Swebui.Controls.Label();
            this.btnType = new Swebui.Controls.TreeSelect();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.eCharts1 = new Swebui.Controls.ECharts();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
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
            this.label1.Text = "资产库存";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.btnWare,
            this.label3,
            this.btnType});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "仓库";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // btnWare
            // 
            this.btnWare.Border = new Swebui.Controls.Border(1F);
            this.btnWare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnWare.DefaultValue = new string[0];
            this.btnWare.DropDownHeight = 280;
            this.btnWare.ListBackgroundColor = System.Drawing.Color.White;
            this.btnWare.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(250, 35);
            this.btnWare.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnWare_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.Text = "类型";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // btnType
            // 
            this.btnType.Border = new Swebui.Controls.Border(1F);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnType.DefaultValue = new string[0];
            this.btnType.DropDownHeight = 280;
            this.btnType.ListBackgroundColor = System.Drawing.Color.White;
            this.btnType.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(250, 35);
            this.btnType.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnType_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.eCharts1});
            this.panel4.Flex = 2;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // label4
            // 
            this.label4.FontSize = 20F;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 35);
            this.label4.Text = "总览";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // eCharts1
            // 
            this.eCharts1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(0, 400);
            // 
            // panel5
            // 
            this.panel5.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.gridView1});
            this.panel5.Flex = 3;
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel5.Size = new System.Drawing.Size(0, 0);
            // 
            // label5
            // 
            this.label5.FontSize = 20F;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 35);
            this.label5.Text = "明细";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn1.DisplayMember = "WARENAME";
            gridViewColumn1.HeaderText = "仓库名称";
            gridViewColumn2.DisplayMember = "TYPENAME";
            gridViewColumn2.HeaderText = "资产条码";
            gridViewColumn3.DisplayMember = "NAME";
            gridViewColumn3.HeaderText = "名称";
            gridViewColumn4.DisplayMember = "QUANT";
            gridViewColumn4.HeaderText = "数量";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // FrmAssQuantAnalysis
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.FrmAssQuantAnalysis_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TreeSelect btnWare;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private ECharts eCharts1;
        private Panel panel5;
        private Label label5;
        private GridView gridView1;
        private Label label3;
        private TreeSelect btnType;
    }
}