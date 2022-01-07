using Newtonsoft.Json;
using SMOWMS.Domain.Entity;
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
    partial class FrmQuantAnalyze : Swebui.Controls.SwebUserControl
    {
        public FrmQuantAnalyze() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void FrmQuantAnalyze_Load(object sender, EventArgs e)
        {
            ///绑定仓库
            List<WareHouse> wareHouseList = autofacConfig.wareHouseService.GetAllWareHouse();
            if (wareHouseList != null && wareHouseList.Count > 0)
            {
                btnWare.Nodes.Add(new TreeSelectNode("", "全部"));
                foreach (var ware in wareHouseList)
                {
                    btnWare.Nodes.Add(new TreeSelectNode(ware.WAREID, ware.NAME));
                }

            }
            Bind();

        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            String wareId = btnWare.Tag == null ? null : btnWare.Tag.ToString();
            Dictionary<string, decimal> result = autofacConfig.consumablesService.GetQuantAnalyse(wareId);
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
        private void btnWare_Press(object sender, TreeSelectPressEventArgs args)
        {
            if (args.TreeID == "")
                btnWare.Tag = null;
            else
                btnWare.Tag = args.TreeID;
            Bind();
        }



    }
}