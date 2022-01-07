using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConSOAndPODetailLayout : Swebui.Controls.SwebUserControl
    {
        public ConSOAndPODetailLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string NAME
        {
            set
            {
                labName.Text = value;
            }
            get
            {
                return labName.Text;
            }
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
        public string SaleNum
        {
            set
            {
                numQuant.Text = value;
            }
            get
            {
                return numQuant.Text;
            }
        }
        public string Price
        {
            set { numPrice.Text = value; }
            get
            {
                return numPrice.Text;
            }
        }
        public string AlreadyInOROut
        {
            set { AlOut.Text = value; }
            get { return AlOut.Text; }
        }
        public string AlreadBack
        {
            set { AlBack.Text = value; }
            get { return AlBack.Text; }
        }
        public string Status
        {
            set { status.Text = value; }
            get
            {
                return status.Text;
            }
        }
        public string ID { set; get; }
    }
}