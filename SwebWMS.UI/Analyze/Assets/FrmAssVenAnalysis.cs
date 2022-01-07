using Newtonsoft.Json;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
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
    partial class FrmAssVenAnalysis : Swebui.Controls.SwebUserControl
    {
        public FrmAssVenAnalysis() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private DateTime startTime;
        private DateTime endTime;
        #endregion
        private void FrmAssVenAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
                startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                endTime = DateTime.Now.Date.AddDays(1);
                dpStart.Value = new ChooseDateValue(startTime, endTime);
                ///绑定常用事件项
                btnTime.Nodes.Add(new TreeSelectNode("Year", "本年"));
                btnTime.Nodes.Add(new TreeSelectNode("Month", "本月"));
                btnTime.Nodes.Add(new TreeSelectNode("Week", "本周"));
                btnTime.Nodes.Add(new TreeSelectNode("Day", "本日"));
                ///绑定供应商选项
                List<Vendor> vendors = _autofacConfig.vendorService.GetAll();
                if(vendors!=null&& vendors.Count > 0)
                {
                    btnVendor.Nodes.Add(new TreeSelectNode("", "全部"));
                    foreach(var vendor in vendors)
                    {
                        btnVendor.Nodes.Add(new TreeSelectNode(vendor.VID.ToString(), vendor.NAME));
                    }
                }
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void Bind()
        {
            try
            {
                int? Id = null;
                if (!string.IsNullOrEmpty(btnVendor.Tag == null ? null : btnVendor.Tag.ToString()))
                {
                    Id = int.Parse(btnVendor.Tag.ToString());
                }

                QueryAssCusandVenAnalysisInputDto inputDto = new QueryAssCusandVenAnalysisInputDto
                {
                    StarTime = startTime,
                    EndTime = endTime,
                    ID = Id
                };
                var chartInfo = _autofacConfig.AssAnalysisService.GetAssVendorAnalysisEChart(inputDto);

                SetEchartOption(chartInfo);
                //bc.DataSource = chartInfo;
                //bc.DataBind();

                var rows = _autofacConfig.AssAnalysisService.GetAssVendorAnalysis(inputDto);
                gridView1.Reload(rows);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                    series += "{ type: 'bar',name:'"+vendor+"'},";
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
    dimensions: " + JsonConvert.SerializeObject(dimensions)+ @",
    source:"+JsonConvert.SerializeObject(source)+@"
  },
  xAxis: { type: 'category' },
  yAxis: { },
  // Declare several bar series, each will be mapped
  // to a column of dataset.source by default.
  series:["+series+@"]
}";

            }
            else
            {
                eCharts1.Option = "";
            }
        }
        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            startTime = (DateTime)dpStart.Value.BeginDate;
            endTime = (DateTime)dpStart.Value.EndDate;
            Bind();
        }

        private void btnTime_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                switch (args.TreeID)
                {
                    case "Year":
                        startTime = new DateTime(DateTime.Now.Year, 1, 1);

                        break;
                    case "Month":
                        startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        break;
                    case "Week":
                        startTime = GetWeekFirstDayMon(DateTime.Now);
                        break;
                    case "Day":
                        startTime = DateTime.Now.Date;
                        break;
                }
                dpStart.Value = new ChooseDateValue(startTime, DateTime.Now.Date);
                endTime = DateTime.Now.Date.AddDays(1);
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 供应商选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnVendor_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnVendor.Tag = args.TreeID;
        }
        /// <summary>  
        /// 得到本周第一天(以星期一为第一天)  
        /// </summary>  
        /// <param name="datetime"></param>  
        /// <returns></returns>  
        public DateTime GetWeekFirstDayMon(DateTime datetime)
        {
            //星期一为第一天  
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。  
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天  
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }

    }
}