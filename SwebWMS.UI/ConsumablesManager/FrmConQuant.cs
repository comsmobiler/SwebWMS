using Swebui.Controls;
using SwebWMS.UI.MasterData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConQuant : Swebui.Controls.SwebUserControl
    {
        public FrmConQuant() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string CID;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConQuant_Load(object sender, EventArgs e)
        {
            try
            {
                lblCID.Text = CID;
                DataTable dataTable = _autofacConfig.consumablesService.GetQuantsEx("", "", "", CID);
                if (dataTable.Rows.Count > 0)
                {
                    gridView1.DataSource = dataTable;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConsumablesDetail() { Flex=1,CID=CID});
            this.Parent.Controls.RemoveAt(0);
        }

       
    }
}