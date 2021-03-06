using Newtonsoft.Json;
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
    partial class FrmAssSOAnalysis : Swebui.Controls.SwebUserControl
    {
        public FrmAssSOAnalysis() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private DateTime startTime;
        private DateTime endTime;
        #endregion
        private void FrmAssSOAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
                startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                endTime = DateTime.Now.Date.AddDays(1);
                dpStart.Value = new ChooseDateValue(startTime, endTime);
                ///绑定常用时间
                btnTime.Nodes.Add(new TreeSelectNode("Year", "本年"));
                btnTime.Nodes.Add(new TreeSelectNode("Month", "本月"));
                btnTime.Nodes.Add(new TreeSelectNode("Week", "本周"));
                btnTime.Nodes.Add(new TreeSelectNode("Day", "本日"));
                QueryAssAnalysisInputDto inputDto = new QueryAssAnalysisInputDto
                {
                    StarTime = startTime,
                    EndTime = endTime
                };
                var chartInfo = _autofacConfig.AssAnalysisService.GetAssSaleAnalysisChart(inputDto);
                SetEchartOption(chartInfo);
                var rows = _autofacConfig.AssAnalysisService.GetAssSaleAnalysis(inputDto);
                gridView1.DataSource = rows;
                gridView1.DataBind();
          
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
                QueryAssAnalysisInputDto inputDto = new QueryAssAnalysisInputDto
                {
                    StarTime = startTime,
                    EndTime = endTime
                };
                var chartInfo = _autofacConfig.AssAnalysisService.GetAssSaleAnalysisChart(inputDto);
                SetEchartOption(chartInfo);
                var rows = _autofacConfig.AssAnalysisService.GetAssSaleAnalysis(inputDto);
                gridView1.Reload(rows);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void SetEchartOption(List<BarChartDto> dtos)
        {
            if (dtos != null && dtos.Count > 0)
            {
                string datasource = JsonConvert.SerializeObject(dtos);
                eCharts1.Option = @" {
  tooltip: {   formatter: function (params) {
       return '数量：'+params.value[params.dimensionNames[params.encode.y[0]]];
      }
        },
  dataset: {
    dimensions:['XValue', 'YValue'],
    source:" + datasource + @"
  },
  xAxis: { type: 'category' },
  yAxis: {},
  // Declare several bar series, each will be mapped
  // to a column of dataset.source by default.
  series: [{ type: 'bar'}]
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
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssSOAnalysis() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);

        }
    }
}