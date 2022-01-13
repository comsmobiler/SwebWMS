using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OrderCreateSNLayout : Swebui.Controls.SwebUserControl
    {
        public OrderCreateSNLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void OrderCreateSNLayout_Load(object sender, EventArgs e)
        {

        }
        public string Image
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
        public string SN
        {
            set
            {
                label1.Text = value;
            }
            get
            {
                return label1.Text;
            }
        }
        public string ASSName
        {
            set { label2.Text = value; }
            get
            {
                return label2.Text;
            }
        }
        public string ASSID { set; get; }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}