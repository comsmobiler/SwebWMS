using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OrderCheckSNLayout : Swebui.Controls.SwebUserControl
    {
        public OrderCheckSNLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
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
        public bool Checked
        {
            set
            {
                check.Checked = value;
            }
            get
            {
                return check.Checked;
            }
        }
        public string ASSID { set; get; }
        public string TOROWID { set; get; }
        private void check_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}