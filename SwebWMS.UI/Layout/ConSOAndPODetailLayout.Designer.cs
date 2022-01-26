using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ConSOAndPODetailLayout : Swebui.Controls.SwebUserControl
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
            this.labName = new Swebui.Controls.Label();
            this.image1 = new Swebui.Controls.Image();
            this.numQuant = new Swebui.Controls.Label();
            this.numPrice = new Swebui.Controls.Label();
            this.AlOut = new Swebui.Controls.Label();
            this.AlBack = new Swebui.Controls.Label();
            // 
            // labName
            // 
            this.labName.Border = new Swebui.Controls.Border(1F);
            this.labName.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.labName.Flex = 1;
            this.labName.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.labName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(200, 35);
            this.labName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image1.Zooming = true;
            // 
            // numQuant
            // 
            this.numQuant.Border = new Swebui.Controls.Border(1F);
            this.numQuant.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.numQuant.Flex = 1;
            this.numQuant.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.numQuant.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(200, 35);
            this.numQuant.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // numPrice
            // 
            this.numPrice.Border = new Swebui.Controls.Border(1F);
            this.numPrice.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.numPrice.Flex = 1;
            this.numPrice.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.numPrice.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(200, 35);
            this.numPrice.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // AlOut
            // 
            this.AlOut.Border = new Swebui.Controls.Border(1F);
            this.AlOut.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AlOut.Flex = 1;
            this.AlOut.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.AlOut.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.AlOut.Name = "AlOut";
            this.AlOut.Size = new System.Drawing.Size(100, 35);
            this.AlOut.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // AlBack
            // 
            this.AlBack.Border = new Swebui.Controls.Border(1F);
            this.AlBack.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AlBack.Flex = 1;
            this.AlBack.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.AlBack.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.AlBack.Name = "AlBack";
            this.AlBack.Size = new System.Drawing.Size(88, 35);
            this.AlBack.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // ConSOAndPODetailLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labName,
            this.image1,
            this.numQuant,
            this.numPrice,
            this.AlOut,
            this.AlBack});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 50);

        }
        #endregion

        private Label labName;
        private Image image1;
        private Label numQuant;
        private Label numPrice;
        private Label AlOut;
        private Label AlBack;
    }
}