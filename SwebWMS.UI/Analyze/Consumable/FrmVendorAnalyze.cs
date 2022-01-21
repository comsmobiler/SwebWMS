using Newtonsoft.Json;
using SMOWMS.DTOs.OutputDTO;
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
    partial class FrmVendorAnalyze : Swebui.Controls.SwebUserControl
    {
        public FrmVendorAnalyze() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void FrmVendorAnalyze_Load(object sender, EventArgs e)
        {
            dpStart.Value = new ChooseDateValue(DateTime.Now.AddDays(1 - DateTime.Now.Day), DateTime.Now);
            dpStart.MaxDate = DateTime.Now;
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        private void Bind()
        {
            if (((DateTime)dpStart.Value.EndDate).Date != DateTime.Now.Date)
            {
                dpStart.Value = new ChooseDateValue(dpStart.Value.BeginDate, ((DateTime)dpStart.Value.EndDate).AddHours(23).AddMinutes(59));
            }
            Dictionary<string, Dictionary<string, decimal>> result = autofacConfig.
            ConPurchaseOrderService.GetVendorAnalyze((DateTime)dpStart.Value.BeginDate, (DateTime)dpStart.Value.EndDate);
            List<object> chartInfo= autofacConfig.
                ConPurchaseOrderService.GetVendorAnalyzeEchart((DateTime)dpStart.Value.BeginDate, (DateTime)dpStart.Value.EndDate);
            SetEchartOption(chartInfo);
        }
        private void SetEchartOption(List<object> chartInfo)
        {
            if (chartInfo != null)
            {
                List<string> type = (List<string>)chartInfo[0];
                Dictionary<string, Dictionary<string, decimal>> dtos = (Dictionary<string, Dictionary<string, decimal>>)chartInfo[1];
                string legend = "";
                string series = "";
                foreach(var dto in dtos)
                {
                    legend +="'"+ dto.Key+"',";
                    string values = "";
                    foreach( var dtoitem in dto.Value)
                    {
                        values += dtoitem.Value + ",";
                    } 
                    series += @"
                        {
                          name: '"+dto.Key+@"',
                          type: 'bar',
                          data: ["+values+@"]},";
                }

                eCharts1.Option = @"{
  legend: {
    data: ["+legend+@"]
  },
  tooltip: {},
  xAxis: [
    {
      type: 'category',
      axisTick: { show: false },
      data: "+JsonConvert.SerializeObject(type)+@"
    }
  ],
  yAxis: [
    {
      type: 'value'
    }
  ],
  series: [
    "+series+@"
  ]
}";

            }
            else
            {
                eCharts1.Option = "";
            }
        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmVendorAnalyze() { Flex=1});
            this.Parent.Controls.RemoveAt(0);
        }
    }
}