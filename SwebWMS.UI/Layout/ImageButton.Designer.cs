using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ImageButton : Swebui.Controls.SwebUserControl
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
            this.image1 = new Swebui.Controls.Image();
            this.button1 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.button1});
            this.panel1.Flex = 1;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(60, 60);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Size = new System.Drawing.Size(0, 30);
            this.button1.Click += new System.EventHandler(this.panel1_Press);
            // 
            // ImageButton
            // 
            this.Border = new Swebui.Controls.Border(1F);
            this.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BorderRadius = 8;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(100, 100);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Button button1;
    }
}