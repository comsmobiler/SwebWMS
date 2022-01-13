using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class AIResultLayout : Swebui.Controls.SwebUserControl
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
            this.lblSN = new Swebui.Controls.Label();
            this.lblASSID = new Swebui.Controls.Label();
            this.lblTypeName = new Swebui.Controls.Label();
            this.lblSpecification = new Swebui.Controls.Label();
            this.lblPrice = new Swebui.Controls.Label();
            this.lblSLName = new Swebui.Controls.Label();
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
            this.lblName.Size = new System.Drawing.Size(100, 30);
            // 
            // lblSN
            // 
            this.lblSN.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(100, 30);
            // 
            // lblASSID
            // 
            this.lblASSID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Size = new System.Drawing.Size(100, 30);
            // 
            // lblTypeName
            // 
            this.lblTypeName.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(100, 30);
            // 
            // lblSpecification
            // 
            this.lblSpecification.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(100, 30);
            // 
            // lblPrice
            // 
            this.lblPrice.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 30);
            // 
            // lblSLName
            // 
            this.lblSLName.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblSLName.Name = "lblSLName";
            this.lblSLName.Size = new System.Drawing.Size(100, 30);
            // 
            // lblRESULTNAME
            // 
            this.lblRESULTNAME.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblRESULTNAME.Name = "lblRESULTNAME";
            this.lblRESULTNAME.Size = new System.Drawing.Size(100, 30);
            // 
            // AIResultLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.lblName,
            this.lblSN,
            this.lblASSID,
            this.lblTypeName,
            this.lblSpecification,
            this.lblPrice,
            this.lblSLName,
            this.lblRESULTNAME});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);
            this.Load += new System.EventHandler(this.AIResultLayout_Load);

        }
        #endregion

        private Image image1;
        private Label lblName;
        private Label lblSN;
        private Label lblASSID;
        private Label lblTypeName;
        private Label lblSpecification;
        private Label lblPrice;
        private Label lblSLName;
        private Label lblRESULTNAME;
    }
}