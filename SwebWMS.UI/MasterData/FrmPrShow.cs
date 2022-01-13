using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmPrShow : Swebui.Controls.SwebUserControl
    {
        public FrmPrShow() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string AssId;  //资产编号
        AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssetDetial() {Flex=1,AssId=AssId});
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrShow_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.GetRecords(AssId, "");
                if (table != null)
                {
                    gridView1.DataSource = table;
                    gridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}