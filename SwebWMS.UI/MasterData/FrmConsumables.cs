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
    partial class FrmConsumables : Swebui.Controls.SwebUserControl
    {
        public FrmConsumables() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion
        private void FrmConsumables_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable conTable = _autofacConfig.consumablesService.GetConList();
                gridView1.DataSource = conTable;
                gridView1.DataBind();
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

    }
}