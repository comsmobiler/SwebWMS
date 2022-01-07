using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class AssetSaleOrderLayout : Swebui.Controls.SwebUserControl
    {
        public AssetSaleOrderLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private DataTable SelectSource;
        public string TemplateID
        {
            set
            {
                templateid.Text = value;
                // treeSelect1.DefaultValues = new string[] { value };
            }
            get { return templateid.Text; }
        }
        public string NumQuant
        {
            set
            {
                numQuant.Text = value;
            }
            get { return numQuant.Text; }
        }
        public string NumPrice
        {
            set
            {
                numPrice.Text = value;
            }
            get { return numPrice.Text; }
        }
        public string Img
        {
            set
            {
                image1.ResourceID = value;
            }
            get
            {
                return image1.ResourceID;
            }
        }
        public AssetSaleOrderLayout(DataTable selectsource) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            SelectSource = selectsource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void AssetSaleOrderLayout_Load(object sender, EventArgs e)
        {
            if (SelectSource != null)
            {
                foreach (DataRow row in SelectSource.Rows)
                {
                    TreeSelectNode treeSelectNode = new TreeSelectNode(row["TEMPLATEID"].ToString(), row["NAME"].ToString());
                    treeSelect1.Nodes.Add(treeSelectNode);

                }
            }
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            templateid.Text = args.TreeID;
            foreach (DataRow row in SelectSource.Rows)
            {
                if (row["TEMPLATEID"].ToString() == args.TreeID)
                {
                    image1.ResourceID = row["IMAGE"].ToString();
                    break;
                }

            }
        }
    }
}