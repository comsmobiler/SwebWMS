using Swebui.Controls;
using System;

namespace SwebWMS.UI.Layout
{
    partial class ConSOAndPOChooseLayout : Swebui.Controls.SwebUserControl
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
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.templateid = new Swebui.Controls.Label();
            this.image1 = new Swebui.Controls.Image();
            this.numQuant = new Swebui.Controls.TextBox();
            this.numPrice = new Swebui.Controls.TextBox();
            this.button1 = new Swebui.Controls.Button();
            // 
            // treeSelect1
            // 
            this.treeSelect1.Border = new Swebui.Controls.Border(1F);
            this.treeSelect1.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.DropDownHeight = 280;
            this.treeSelect1.Flex = 1;
            this.treeSelect1.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Size = new System.Drawing.Size(200, 35);
            this.treeSelect1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect1_Press);
            // 
            // templateid
            // 
            this.templateid.Flex = 1;
            this.templateid.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.templateid.Name = "templateid";
            this.templateid.Size = new System.Drawing.Size(200, 35);
            this.templateid.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.numQuant.BackColor = System.Drawing.Color.Transparent;
            this.numQuant.Border = new Swebui.Controls.Border(1F);
            this.numQuant.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.numQuant.Flex = 1;
            this.numQuant.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(200, 35);
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.Transparent;
            this.numPrice.Border = new Swebui.Controls.Border(1F);
            this.numPrice.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.numPrice.Flex = 1;
            this.numPrice.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(200, 35);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Flex = 1;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.IconName = "fa fa-times-circle-o";
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "删除";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConSOAndPOChooseLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeSelect1,
            this.templateid,
            this.image1,
            this.numQuant,
            this.numPrice,
            this.button1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 50);
            this.Load += new System.EventHandler(this.ConSOAndPOChooseLayout_Load);

        }
        #endregion

        private TreeSelect treeSelect1;
        private Label templateid;
        private Image image1;
        private TextBox numQuant;
        private TextBox numPrice;
        private Button button1;
    }
}