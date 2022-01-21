using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Analyze
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmSafeQuantAnalyze : Swebui.Controls.SwebUserControl
    {
        public FrmSafeQuantAnalyze() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion

        private void FrmSafeQuantAnalyze_Load(object sender, EventArgs e)
        {

            List<ConOutputDto> conSafeQuantlist = autofacConfig.consumablesService.GetSafeQuantAnalyse();
            if (conSafeQuantlist.Count > 0)
            {
                gridView1.DataSource = conSafeQuantlist;
                gridView1.DataBind();
            }
           
        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmSafeQuantAnalyze() { Flex=1 });
            this.Parent.Controls.RemoveAt(0);
        }
    }
}