using SMOWMS.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Analyze
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmImminentExpiryAss : Swebui.Controls.SwebUserControl
    {
        public FrmImminentExpiryAss() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private DateTime startTime;
        private DateTime endTime;
        #endregion
        private void FrmImminentExpiryAss_Load(object sender, EventArgs e)
        {
            try
            {
               //绑定选项
                btnTime.Nodes.Add(new TreeSelectNode("OM","一个月"));
                btnTime.Nodes.Add(new TreeSelectNode("15","半个月"));
                btnTime.Nodes.Add(new TreeSelectNode("7","一周" ));
                ///
                startTime = DateTime.Now.Date;
                endTime = DateTime.Now.Date.AddMonths(1);
                QueryAssAnalysisInputDto inputDto = new QueryAssAnalysisInputDto
                {
                    StarTime = startTime,
                    EndTime = endTime
                };
                var rows = _autofacConfig.AssAnalysisService.GetImminentExpiryAss(inputDto);
              
                gridView1.DataSource = rows;
                gridView1.DataBind();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnTime_Press(object sender, TreeSelectPressEventArgs args)
        {
            switch (args.TreeID)
            {
                case "OM":
                    endTime = DateTime.Now.Date.AddMonths(1);
                    break;
                case "15":
                    endTime = DateTime.Now.Date.AddDays(15);
                    break;
                case "7":
                    endTime = DateTime.Now.Date.AddDays(7);
                    break;
            }
            Bind();
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
                var rows = _autofacConfig.AssAnalysisService.GetImminentExpiryAss(inputDto);
                gridView1.Reload(rows);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}