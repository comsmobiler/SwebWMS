using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ConPORInStoLayout : Swebui.Controls.SwebUserControl
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
            this.checkBox1 = new Swebui.Controls.CheckBox();
            this.image1 = new Swebui.Controls.Image();
            this.labName = new Swebui.Controls.Label();
            this.labInNum = new Swebui.Controls.Label();
            this.txtIn = new Swebui.Controls.TextBox();
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.BorderRadius = 0;
            this.checkBox1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 26);
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image1.Zooming = true;
            // 
            // labName
            // 
            this.labName.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(120, 26);
            this.labName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // labInNum
            // 
            this.labInNum.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.labInNum.Name = "labInNum";
            this.labInNum.Size = new System.Drawing.Size(120, 26);
            this.labInNum.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtIn
            // 
            this.txtIn.Border = new Swebui.Controls.Border(1F);
            this.txtIn.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtIn.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(120, 26);
            this.txtIn.ValueType = Swebui.Controls.TextBoxValueType.Number;
            // 
            // ConPORInStoLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1,
            this.image1,
            this.labName,
            this.labInNum,
            this.txtIn});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);

        }
        #endregion

        private CheckBox checkBox1;
        private Image image1;
        private Label labName;
        private Label labInNum;
        private TextBox txtIn;
    }
}