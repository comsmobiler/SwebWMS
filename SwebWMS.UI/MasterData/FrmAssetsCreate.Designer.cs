using Swebui.Controls;
using System;

namespace SwebWMS.UI.MasterData
{
    partial class FrmAssetsCreate : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.TreeSelectNode treeSelectNode1 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode2 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode3 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode4 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode5 = new Swebui.Controls.TreeSelectNode();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.treeSelect2 = new Swebui.Controls.TreeSelect();
            // 
            // treeSelect1
            // 
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.Name = "treeSelect1";
            treeSelectNode1.Text = "5";
            treeSelectNode1.TreeID = "5";
            treeSelectNode2.Text = "4";
            treeSelectNode2.TreeID = "4";
            this.treeSelect1.Nodes.AddRange(new Swebui.Controls.TreeSelectNode[] {
            treeSelectNode1,
            treeSelectNode2});
            this.treeSelect1.Size = new System.Drawing.Size(0, 30);
            // 
            // treeSelect2
            // 
            this.treeSelect2.DefaultValue = new string[0];
            this.treeSelect2.Name = "treeSelect2";
            treeSelectNode3.Text = "1";
            treeSelectNode3.TreeID = "1";
            treeSelectNode4.Text = "2";
            treeSelectNode4.TreeID = "2";
            treeSelectNode5.Text = "3";
            treeSelectNode5.TreeID = "3";
            this.treeSelect2.Nodes.AddRange(new Swebui.Controls.TreeSelectNode[] {
            treeSelectNode3,
            treeSelectNode4,
            treeSelectNode5});
            this.treeSelect2.Size = new System.Drawing.Size(0, 30);
            // 
            // FrmAssetsCreate
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeSelect1,
            this.treeSelect2});

        }
        #endregion

        private TreeSelect treeSelect1;
        private TreeSelect treeSelect2;
    }
}