using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class CIResultLayout : Swebui.Controls.SwebUserControl
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
            this.image1 = new Swebui.Controls.Image();
            this.lblName = new Swebui.Controls.Label();
            this.lblCID = new Swebui.Controls.Label();
            this.lblLOCNAME = new Swebui.Controls.Label();
            this.lblNumber = new Swebui.Controls.Label();
            this.lblREALAMOUNT = new Swebui.Controls.Label();
            this.lblRESULTNAME = new Swebui.Controls.Label();
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblName
            // 
            this.lblName.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 35);
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblCID
            // 
            this.lblCID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(100, 35);
            this.lblCID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblLOCNAME
            // 
            this.lblLOCNAME.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblLOCNAME.Name = "lblLOCNAME";
            this.lblLOCNAME.Size = new System.Drawing.Size(100, 35);
            this.lblLOCNAME.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblNumber
            // 
            this.lblNumber.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 35);
            this.lblNumber.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblREALAMOUNT
            // 
            this.lblREALAMOUNT.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblREALAMOUNT.Name = "lblREALAMOUNT";
            this.lblREALAMOUNT.Size = new System.Drawing.Size(100, 35);
            this.lblREALAMOUNT.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblRESULTNAME
            // 
            this.lblRESULTNAME.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblRESULTNAME.Name = "lblRESULTNAME";
            this.lblRESULTNAME.Size = new System.Drawing.Size(100, 35);
            this.lblRESULTNAME.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // CIResultLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.lblName,
            this.lblCID,
            this.lblLOCNAME,
            this.lblNumber,
            this.lblREALAMOUNT,
            this.lblRESULTNAME});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);
            this.Load += new System.EventHandler(this.CIResultLayout_Load);

        }
        #endregion

        private Image image1;
        private Label lblName;
        private Label lblCID;
        private Label lblLOCNAME;
        private Label lblNumber;
        private Label lblREALAMOUNT;
        private Label lblRESULTNAME;
    }
}