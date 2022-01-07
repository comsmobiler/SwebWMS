using Swebui.Controls;
using System;

namespace SwebWMS.UI.Analyze
{
    partial class FrmQuantAnalyze : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.btnWare = new Swebui.Controls.TreeSelect();
            this.panel3 = new Swebui.Controls.Panel();
            this.eCharts1 = new Swebui.Controls.ECharts();
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
            this.label1.Text = "耗材库存统计";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.btnWare});
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
            this.btnWare.ListBackgroundColor = System.Drawing.Color.White;
            this.btnWare.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(250, 35);
            this.btnWare.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnWare_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.eCharts1});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // eCharts1
            // 
            this.eCharts1.Flex = 1;
            this.eCharts1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(0, 400);
            // 
            // FrmQuantAnalyze
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.FrmQuantAnalyze_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TreeSelect btnWare;
        private Panel panel3;
        private ECharts eCharts1;
    }
}