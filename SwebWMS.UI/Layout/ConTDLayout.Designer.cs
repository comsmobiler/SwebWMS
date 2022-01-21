using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ConTDLayout : Swebui.Controls.SwebUserControl
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
            this.lblName = new Swebui.Controls.Label();
            this.lblNumber = new Swebui.Controls.Label();
            this.lblLocation = new Swebui.Controls.Label();
            this.numNumber = new Swebui.Controls.TextBox();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.BorderColor = System.Drawing.Color.Black;
            this.check.BorderRadius = 0;
            this.check.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(60, 26);
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(50, 50);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblName
            // 
            this.lblName.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 30);
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblNumber
            // 
            this.lblNumber.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(120, 30);
            this.lblNumber.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblLocation
            // 
            this.lblLocation.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(120, 30);
            this.lblLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // numNumber
            // 
            this.numNumber.Border = new Swebui.Controls.Border(1F);
            this.numNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.numNumber.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(120, 30);
            this.numNumber.ValueType = Swebui.Controls.TextBoxValueType.Number;
            // 
            // ConTDLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.check,
            this.image1,
            this.lblName,
            this.lblNumber,
            this.lblLocation,
            this.numNumber});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);

        }
        #endregion

        private CheckBox check;
        private Image image1;
        private Label lblName;
        private Label lblNumber;
        private Label lblLocation;
        private TextBox numNumber;
    }
}