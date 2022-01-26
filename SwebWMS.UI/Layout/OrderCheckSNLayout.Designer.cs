using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class OrderCheckSNLayout : Swebui.Controls.SwebUserControl
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
            this.check = new Swebui.Controls.CheckBox();
            this.image1 = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.BorderColor = System.Drawing.Color.Black;
            this.check.BorderRadius = 0;
            this.check.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(60, 26);
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
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
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // OrderCheckSNLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.check,
            this.image1,
            this.label1,
            this.label2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);

        }
        #endregion
        private CheckBox check;
        private Image image1;
        private Label label1;
        private Label label2;
    }
}