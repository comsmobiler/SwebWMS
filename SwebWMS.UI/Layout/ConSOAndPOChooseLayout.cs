using SMOWMS.Domain.Entity;
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
    partial class ConSOAndPOChooseLayout : Swebui.Controls.SwebUserControl
    {
        public ConSOAndPOChooseLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public ConSOAndPOChooseLayout(List<Consumables> selectsource) : base()
        {
            InitializeComponent();
            SelectSource = selectsource;
        }
        private List<Consumables> SelectSource;
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
        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            templateid.Text = args.TreeID;
            foreach (Consumables row in SelectSource)
            {
                if (row.CID == args.TreeID)
                {
                    image1.ResourceID = row.IMAGE;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void ConSOAndPOChooseLayout_Load(object sender, EventArgs e)
        {
            foreach (Consumables row in SelectSource)
            {
                treeSelect1.Nodes.Add(new TreeSelectNode(row.CID, row.NAME));
            }
        }
    }
}