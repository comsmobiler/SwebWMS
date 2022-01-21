using Newtonsoft.Json;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Analyze
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmSaleAnalyze : Swebui.Controls.SwebUserControl
    {
        public FrmSaleAnalyze() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void FrmSaleAnalyze_Load(object sender, EventArgs e)
        {
            dpStart.Value =new ChooseDateValue( DateTime.Now.AddDays(1 - DateTime.Now.Day),DateTime.Now);
            dpStart.MaxDate = DateTime.Now;

            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            if (((DateTime)dpStart.Value.EndDate).Date != DateTime.Now.Date)
            {
                dpStart.Value = new ChooseDateValue(dpStart.Value.BeginDate, ((DateTime)dpStart.Value.EndDate).AddHours(23).AddMinutes(59));
            }
            Dictionary<string, decimal> result = autofacConfig.ConSalesOrderService.GetSaleAnalyze((DateTime)dpStart.Value.BeginDate, (DateTime)dpStart.Value.EndDate);
            DataTable table = new DataTable();
            table.Columns.Add("NAME");        //耗材名称
            table.Columns.Add("QUANTITY");    //耗材库存
            foreach (string name in result.Keys)
            {
                table.Rows.Add(name, result[name]);
            }
            if (table.Rows.Count > 0)
            {
                eCharts1.Option = @"{
  legend: {},
  tooltip: {},
  dataset: {
    dimensions: ['NAME', 'QUANTITY'],
    source: " + JsonConvert.SerializeObject(table) + @"
  },
  xAxis: { type: 'category' },
  yAxis: {},
  // Declare several bar series, each will be mapped
  // to a column of dataset.source by default.
  series: [{ type: 'bar' }]
}";
            }
            else
            {
                eCharts1.Option = "";
            }
        }
        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            Bind();

        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmSaleAnalyze() { Flex=1});
            this.Parent.Controls.RemoveAt(0);
        }
    }
}