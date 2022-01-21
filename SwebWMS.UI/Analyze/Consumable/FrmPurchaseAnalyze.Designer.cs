using Swebui.Controls;
using System;

namespace SwebWMS.UI.Analyze
{
    partial class FrmPurchaseAnalyze : Swebui.Controls.SwebUserControl
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
            this.dpStart = new Swebui.Controls.ChooseDatePicker();
            this.panel3 = new Swebui.Controls.Panel();
            this.eCharts1 = new Swebui.Controls.ECharts();
            this.RefreshBtn = new Swebui.Controls.Button();
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
            this.label1.Text = "耗材采购分析";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.dpStart,
            this.RefreshBtn});
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
            this.label2.Text = "采购时间";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpStart
            // 
            this.dpStart.Border = new Swebui.Controls.Border(1F);
            this.dpStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dpStart.FontSize = 13F;
            this.dpStart.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.dpStart.Name = "dpStart";
            this.dpStart.Placeholder.BeginPlaceholder = "开始日期";
            this.dpStart.Placeholder.EndPlaceHolder = "结束日期";
            this.dpStart.Size = new System.Drawing.Size(350, 35);
            this.dpStart.Value.BeginDate = null;
            this.dpStart.Value.EndDate = null;
            this.dpStart.ValueChanged += new System.EventHandler(this.dpStart_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.eCharts1});
            this.panel3.Flex = 1;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // eCharts1
            // 
            this.eCharts1.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(600, 400);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Border = new Swebui.Controls.Border(1F);
            this.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DimGray;
            this.RefreshBtn.IconName = "fa fa-refresh";
            this.RefreshBtn.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.NumberOfLines = 0;
            this.RefreshBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.RefreshBtn.Size = new System.Drawing.Size(0, 26);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FrmPurchaseAnalyze
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.FrmPurchaseAnalyze_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ChooseDatePicker dpStart;
        private Panel panel3;
        private ECharts eCharts1;
        private Button RefreshBtn;
    }
}