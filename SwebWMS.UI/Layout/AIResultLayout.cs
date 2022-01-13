using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class AIResultLayout : Swebui.Controls.SwebUserControl
    {
        public AIResultLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string NAME
        {
            set { lblName.Text = value; }
            get { return lblName.Text; }
        }
        public string Image
        {
            set { image1.ResourceID = value; }
            get { return image1.ResourceID; }
        }
        public string SN
        {
            set { lblSN.Text = value; }
            get { return lblSN.Text; }
        }
        public string TypeName
        {
            set { lblTypeName.Text = value; }
            get { return lblTypeName.Text; }
        }
        public string Specification
        {
            set { lblSpecification.Text = value; }
            get { return lblSpecification.Text; }
        }
        public string Price
        {
            set { lblPrice.Text = value; }
            get { return lblPrice.Text; }
        }
        public string SLName
        {
            set { lblSLName.Text = value; }
            get { return lblSLName.Text; }
        }
        public string RESULTNAME
        {
            set { lblRESULTNAME.Text = value; }
            get { return lblRESULTNAME.Text; }
        }
        public string ASSID
        {
            set { lblASSID.Text = value; }
            get { return lblASSID.Text; }
        }

        private void AIResultLayout_Load(object sender, EventArgs e)
        {
            if (lblRESULTNAME.Text == "盘亏")
                lblRESULTNAME.ForeColor = System.Drawing.Color.Red;
            if (lblRESULTNAME.Text == "盘盈")
                lblRESULTNAME.ForeColor = System.Drawing.Color.FromArgb(43, 140, 255);
        }
    }
}