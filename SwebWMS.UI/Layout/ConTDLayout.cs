using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConTDLayout : Swebui.Controls.SwebUserControl
    {
        public ConTDLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public bool IsChecked
        {
            set
            {
                check.Checked = value;
            }
            get { return check.Checked; }
        }

        public string TOROWID
        {
            set;
            get;
        }
        public string Image
        {
            set { image1.ResourceID = value; }
            get { return image1.ResourceID; }
        }
        public string NAME
        {
            set { lblName.Text = value; }
            get { return lblName.Text; }
        }
        public string CID { set; get; }
        public string INTRANSFERQTY
        {
            set { lblNumber.Text = value; }
            get { return lblNumber.Text; }
        }
        public string LOCATIONNAME
        {
            set { lblLocation.Text = value; }
            get { return lblLocation.Text; }
        }
        public string LOCATIONID { set; get; }
        public string Num
        {
            set { numNumber.Text = value; }
            get { return numNumber.Text; }
        }
    }
}