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
             List<object> chartInfo= autofacConfig.
                ConPurchaseOrderService.GetVendorAnalyzeEchart((DateTime)dpStart.Value.BeginDate, (DateTime)dpStart.Value.EndDate);
            SetEchartOption(chartInfo);
        }
        private void SetEchartOption(List<object> chartInfo)
        {
            if (chartInfo != null)
            {
                List<string> vendors = (List<string>)chartInfo[0];
                List<BarChartDto> dtos = (List<BarChartDto>)chartInfo[1];
                List<string> dimensions = new List<string>();
                dimensions.Add("product");
                List<string> xairs = new List<string>();
                List<Dictionary<string, object>> source = new List<Dictionary<string, object>>();
                string series = "";
                foreach (var dto in dtos)
                {
                    if (xairs.Contains(dto.XValue) == false)
                    {
                        xairs.Add(dto.XValue);
                        Dictionary<string, object> valuePairs = new Dictionary<string, object>();
                        valuePairs.Add("product", dto.XValue);
                        source.Add(valuePairs);
                    }
                }
                foreach (var vendor in vendors)
                {
                    series += "{ type: 'bar',name:'" + vendor + "'},";
                    dimensions.Add(vendor);
                    foreach (var _source in source)
                    {
                        foreach (var dto in dtos)
                        {
                            if (dto.Series == vendor && dto.XValue == _source["product"].ToString())
                            {
                                _source.Add(vendor, dto.YValue);
                                break;
                            }
                        }

                    }
                }

                eCharts1.Option = @" {
  legend: {},

  tooltip: {
    formatter: function (params) {
         return params.seriesName+'<br/>'+'数量：'+params.value[params.dimensionNames[params.encode.y[0]]];
      }
        },
  dataset: {
    dimensions: " + JsonConvert.SerializeObject(dimensions) + @",
    source:" + JsonConvert.SerializeObject(source) + @"
  },
  xAxis: { type: 'category' },
  yAxis: { },
  // Declare several bar series, each will be mapped
  // to a column of dataset.source by default.
  series:[" + series + @"]
}";

            }
            else
            {
                eCharts1.Option = "";
            }
        }
    }
}