using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class CIResultLayout : Swebui.Controls.SwebUserControl
    {
        public CIResultLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string Image
        {
            set { image1.ResourceID = value; }
            get { return image1.ResourceID; }
        }
        public string CID
        {
            set { lblCID.Text = value; }
            get { return lblCID.Text; }
        }
        public string NAME
        {
            set { lblName.Text = value; }
            get { return lblName.Text; }
        }
        public string LOCNAME
        {
            set { lblLOCNAME.Text = value; }
            get { return lblLOCNAME.Text; }
        }
        public string LOCID
        {
            set;
            get;
        }
        public string Total
        {
            set { lblNumber.Text = value; }
            get { return lblNumber.Text; }
        }
        public string REALAMOUNT
        {
            set { lblREALAMOUNT.Text = value; }
            get { return lblREALAMOUNT.Text; }
        }
        public string RESULTNAME {
            set { lblRESULTNAME.Text = value; }
            get { return lblRESULTNAME.Text; }
        }

        private void CIResultLayout_Load(object sender, EventArgs e)
        {
            if (lblRESULTNAME.Text == "盘亏")
                lblRESULTNAME.ForeColor = System.Drawing.Color.Red;
            else if (lblRESULTNAME.Text == "盘盈")
                lblRESULTNAME.ForeColor = System.Drawing.Color.FromArgb(43, 140, 255);
        }
    }
}