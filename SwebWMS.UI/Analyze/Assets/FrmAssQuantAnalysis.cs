using Newtonsoft.Json;
using SMOWMS.DTOs.InputDTO;
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
    partial class FrmAssQuantAnalysis : Swebui.Controls.SwebUserControl
    {
        public FrmAssQuantAnalysis() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private void FrmAssQuantAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
                btnWare.Tag = "";
                btnType.Tag = "";
                ///
                var typelist = _autofacConfig.assTypeService.GetAll();
                if (typelist != null)
                {
                    btnType.Nodes.Add(new TreeSelectNode("", "全部类型"));
                    foreach (var type in typelist)
                    {
                        btnType.Nodes.Add(new TreeSelectNode(type.TYPEID, type.NAME));
                    }
                }
                ///
                var whlist = _autofacConfig.wareHouseService.GetAllWareHouse();
                if (whlist != null)
                {
                    btnWare.Nodes.Add(new TreeSelectNode("", "全部仓库"));
                    foreach (var ware in whlist)
                    {
                        btnWare.Nodes.Add(new TreeSelectNode(ware.WAREID, ware.NAME));
                    }
                }
                string wareId = btnWare.Tag == null ? "" : btnWare.Tag.ToString();
                string typeId = btnType.Tag == null ? "" : btnType.Tag.ToString();
                QueryAssQuantInputDto inputDto = new QueryAssQuantInputDto
                {
                    WAREID = wareId,
                    TYPEID = typeId
                };
                SetEchartOption(inputDto);

                var rows = _autofacConfig.AssAnalysisService.GetAssQuant(inputDto);

                gridView1.DataSource = rows;
                gridView1.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 设置echart
        /// </summary>
        /// <param name="inputDto"></param>
        private void SetEchartOption(QueryAssQuantInputDto inputDto)
        {
            var chartInfo = _autofacConfig.AssAnalysisService.GetAssQuantEChart(inputDto);

            if (chartInfo != null && chartInfo.Count == 3)
            {
                List<string> warelist = (List<string>)chartInfo[0];
                List<string> typelist = (List<string>)chartInfo[1];
                List<AssQuantDto> datainfo = chartInfo[2] as List<AssQuantDto>;
                List<EChartData> eChartDatas = new List<EChartData>();
                if (warelist.Count > 0)
                {
                    foreach (string ware in warelist)
                    {

                        EChartData eChartData = new EChartData();
                        eChartData.name = ware;
                        foreach (var data in datainfo)
                        {
                            if (data.WARENAME == ware)
                            {
                                eChartData.data.Add(data.QUANT);
                            }
                        }
                        eChartDatas.Add(eChartData);
                    }


                }
                eCharts1.Option = @"{
  legend: {
    data: " + JsonConvert.SerializeObject(warelist) + @"
  },
  tooltip: {},
  series:" + JsonConvert.SerializeObject(eChartDatas) + @",
  xAxis: [
    {
      type: 'category',
     data:" + JsonConvert.SerializeObject(typelist) + @"
    }
  ],
  yAxis: [
    {
      type: 'value'
    }
  ]
}";
            }
            else
                eCharts1.Option = "";

        }

        /// <summary>
        /// 选择类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnType_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnType.Tag = args.TreeID;
            Bind();
        }
        /// <summary>
        ///仓库选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnWare_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnWare.Tag = args.TreeID;
            Bind();
        }
        private void Bind()
        {
            string wareId = btnWare.Tag == null ? "" : btnWare.Tag.ToString();
            string typeId = btnType.Tag == null ? "" : btnType.Tag.ToString();
            QueryAssQuantInputDto inputDto = new QueryAssQuantInputDto
            {
                WAREID = wareId,
                TYPEID = typeId
            };
            SetEchartOption(inputDto);

            var rows = _autofacConfig.AssAnalysisService.GetAssQuant(inputDto);

            gridView1.Reload(rows);

        }
    }

    public class EChartData
    {
        public string type = "bar";
        public string name { set; get; }
        public List<object> data = new List<object>();

    }
}