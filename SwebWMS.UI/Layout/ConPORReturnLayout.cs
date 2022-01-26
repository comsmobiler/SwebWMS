using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConPORReturnLayout : Swebui.Controls.SwebUserControl
    {
        public ConPORReturnLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public bool IsChecked
        {
            set { checkBox1.Checked = value; }
            get { return checkBox1.Checked; }
        }
        public string Image
        {
            set { image1.ResourceID =value; }
            get { return image1.ResourceID; }
        }
        public string NAME
        {
            set { labName.Text = value; }
            get { return labName.Text; }
        }
        public string QUANTSTORED
        {
            set { labInNum.Text = value; }
            get { return labInNum.Text; }
        }
        public string LOCID { set; get; }
        public string LOCNAME
        {
            set { lblLoc.Text = value; }
            get { return lblLoc.Text; }
        }
        public string Num
        {
            set { txtIn.Text = value; }
            get
            {
                return txtIn.Text;
            }
        }
        public string CID { set; get; }
        public string POROWID { set; get; }
    }
}