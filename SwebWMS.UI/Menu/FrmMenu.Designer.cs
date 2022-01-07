using Swebui.Controls;
using System;

namespace SwebWMS.UI.Menu
{
    partial class FrmMenu : Swebui.Controls.SwebUserControl
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
            this.panel3 = new Swebui.Controls.Panel();
            this.panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.assPanel = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.conPanel = new Swebui.Controls.Panel();
            this.labWeek = new Swebui.Controls.Label();
            this.labDate = new Swebui.Controls.Label();
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.BorderRadius = 8;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labWeek,
            this.labDate});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel4});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.BorderRadius = 8;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.assPanel});
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.FontSize = 20F;
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "资产";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // assPanel
            // 
            this.assPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.assPanel.Flex = 1;
            this.assPanel.Name = "assPanel";
            this.assPanel.Size = new System.Drawing.Size(0, 100);
            this.assPanel.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel4.BorderRadius = 8;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.conPanel});
            this.panel4.Flex = 1;
            this.panel4.Margin = new Swebui.Controls.Margin(10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // label2
            // 
            this.label2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.FontSize = 20F;
            this.label2.Name = "label2";
            this.label2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "耗材";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // conPanel
            // 
            this.conPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.conPanel.Flex = 1;
            this.conPanel.Name = "conPanel";
            this.conPanel.Size = new System.Drawing.Size(0, 100);
            this.conPanel.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // labWeek
            // 
            this.labWeek.FontSize = 30F;
            this.labWeek.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.labWeek.Name = "labWeek";
            this.labWeek.Size = new System.Drawing.Size(0, 30);
            this.labWeek.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // labDate
            // 
            this.labDate.FontSize = 20F;
            this.labDate.ForeColor = System.Drawing.Color.DimGray;
            this.labDate.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(0, 30);
            this.labDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // FrmMenu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel1});
            this.Load += new System.EventHandler(this.FrmMenu_Load);

        }
        #endregion

        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Panel assPanel;
        private Panel conPanel;
        private Label labWeek;
        private Label labDate;
    }
}