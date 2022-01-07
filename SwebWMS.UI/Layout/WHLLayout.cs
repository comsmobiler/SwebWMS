using SMOWMS.CommLib;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class WHLLayout : Swebui.Controls.SwebUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public WHLLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private string WareID;
        private string STID;
        private string SLID;
        private int IsEnable;
        public WHLLayout(string wareid, string stid, string whlid, string whlname, int isenable) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            WareID = wareid;
            STID = stid;
            SLID = whlID.Text = whlid;
            WHLName.Text = whlname;
            IsEnable = isenable;
            switch1.Checked = IsEnable == 1 ? true : false;
        }
        /// <summary>
        /// 是否启用库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switch1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switch1.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(WareID, STID, SLID, SMOWMS.DTOs.Enum.IsEnable.启用);
                    if (rInfo.IsSuccess)
                        Toast("启用库位成功");
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(WareID, STID, SLID, SMOWMS.DTOs.Enum.IsEnable.禁用);
                    if (rInfo.IsSuccess)
                        Toast("禁用库位成功");
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WHLCreateDialog dialog = new WHLCreateDialog();
            dialog.isEdit = true;
            dialog.WareID = WareID;
            dialog.STID = STID;
            dialog.SLID = SLID;
            this.ShowDialog(dialog, (obj, args) =>
            {

            });
        }
    }
}