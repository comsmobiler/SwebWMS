using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class WHLLayout : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.whlID = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.WHLName = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.switch1 = new Swebui.Controls.Switch();
            this.button1 = new Swebui.Controls.Button();
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.whlID});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 5F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 20);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.NumberOfLines = 1;
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.Text = "库位编号";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // whlID
            // 
            this.whlID.Flex = 1;
            this.whlID.Name = "whlID";
            this.whlID.NumberOfLines = 1;
            this.whlID.Size = new System.Drawing.Size(0, 20);
            this.whlID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.WHLName});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 5F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 20);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.NumberOfLines = 1;
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.Text = "库位名称";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // WHLName
            // 
            this.WHLName.Flex = 1;
            this.WHLName.Name = "WHLName";
            this.WHLName.NumberOfLines = 1;
            this.WHLName.Size = new System.Drawing.Size(0, 20);
            this.WHLName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.switch1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 5F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 20);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.NumberOfLines = 1;
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.Text = "是否启用";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // switch1
            // 
            this.switch1.BackColor = System.Drawing.Color.Transparent;
            this.switch1.BorderColor = System.Drawing.Color.Black;
            this.switch1.BorderRadius = 0;
            this.switch1.Flex = 1;
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(0, 20);
            this.switch1.CheckedChanged += new System.EventHandler(this.switch1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 5F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Size = new System.Drawing.Size(59, 20);
            this.button1.Text = "编辑";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WHLLayout
            // 
            this.Border = new Swebui.Controls.Border(1F);
            this.BorderRadius = 4;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4,
            this.button1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.Padding = new Swebui.Controls.Padding(10F);
            this.Size = new System.Drawing.Size(150, 110);

        }
        #endregion

        private Panel panel2;
        private Label label1;
        private Label whlID;
        private Panel panel3;
        private Label label3;
        private Label WHLName;
        private Panel panel4;
        private Label label2;
        private Switch switch1;
        private Button button1;
    }
}