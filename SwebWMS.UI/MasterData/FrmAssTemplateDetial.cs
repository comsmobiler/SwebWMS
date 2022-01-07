using SMOWMS.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssTemplateDetial : Swebui.Controls.SwebUserControl
    {
        public FrmAssTemplateDetial() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string TempId; //资产编号
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string typeId;
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssTemplate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        private void FrmAssTemplateDetial_Load(object sender, EventArgs e)
        {
            try
            {
                AssTemplate outputDto = _autofacConfig.SettingService.GetAtbyId(TempId);
                if (outputDto != null)
                {
                    lblTempID.Text = outputDto.TEMPLATEID;
                    lblName.Text = outputDto.NAME;
                    lblPrice.Text = outputDto.PRICE.ToString();
                    lblSpe.Text = outputDto.SPECIFICATION;
                    lblUnit.Text = outputDto.UNIT;
                    lblVendor.Text = outputDto.VENDOR;
                    ImgPicture.ResourceID = outputDto.IMAGE;
                    lblNote.Text = outputDto.NOTE;
                    var type = _autofacConfig.assTypeService.GetByID(outputDto.TYPEID);
                    lblType.Text = type.NAME;

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }


    }
}