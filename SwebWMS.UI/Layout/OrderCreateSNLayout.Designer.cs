using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class OrderCreateSNLayout : Swebui.Controls.SwebUserControl
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
            this.button1 = new Swebui.Controls.Button();
            this.image1 = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.IconName = "fa fa-times-circle-o";
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.Text = "删除";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(50, 50);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image1.Zooming = true;
            // 
            // label1
            // 
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // OrderCreateSNLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.image1,
            this.label1,
            this.label2,
            this.label3});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);
            this.Load += new System.EventHandler(this.OrderCreateSNLayout_Load);

        }
        #endregion
        private Button button1;
        private Image image1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}