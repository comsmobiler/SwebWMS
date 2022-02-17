using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssetDetial : Swebui.Controls.SwebUserControl
    {
        public FrmAssetDetial() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string AssId;  //资产编号
        private string DepId; //部门编号
        private string STID;
        private string WAREID;
        private string TypeId; //类型编号
        private string SLID;  //库位编号
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssets() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        private void FrmAssetDetial_Load(object sender, EventArgs e)
        {
            try
            {
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                if (outputDto != null)
                {
                    txtAssId1.Text = outputDto.AssId;
                    ImgPicture.ResourceID = outputDto.Image;
                    txtNote1.Text = outputDto.Note;
                    DatePickerExpiry.Text = outputDto.ExpiryDate.ToString("yyyy-MM-dd");
                    DatePickerBuy.Text = outputDto.BuyDate.ToString("yyyy-MM-dd");
                    txtName1.Text = outputDto.Name;
                    txtPrice1.Text = outputDto.Price.ToString();
                    txtSPE1.Text = outputDto.Specification;
                    txtPlace1.Text = outputDto.Place;
                    txtSN.Text = outputDto.SN;
                    txtUnit1.Text = outputDto.Unit;
                    txtVendor1.Text = outputDto.Vendor;
                    txtATID.Text = outputDto.ATID;
                    txtType.Text = outputDto.TypeName;
                    TypeId = outputDto.TypeId;
                    txtSL.Text = outputDto.SLName;
                    SLID = outputDto.SLID;
                    STID = outputDto.STID;
                    WAREID = outputDto.WAREID;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 处理记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmPrShow() { AssId = AssId, Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
    }
}