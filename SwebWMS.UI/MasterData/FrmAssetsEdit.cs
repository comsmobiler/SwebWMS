using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
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
    partial class FrmAssetsEdit : Swebui.Controls.SwebUserControl
    {
        public FrmAssetsEdit() : base()
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
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssetsEdit_Load(object sender, EventArgs e)
        {
            try
            {
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                if (outputDto != null)
                {
                    txtAssId1.Text = outputDto.AssId;
                    ImgPicture.ResourceID = outputDto.Image;
                    txtNote1.Text = outputDto.Note;
                    DatePickerExpiry.Value = outputDto.ExpiryDate;
                    DatePickerBuy.Value = outputDto.BuyDate;
                    txtName1.Text = outputDto.Name;
                    txtPrice1.Text = outputDto.Price.ToString();
                    txtSPE1.Text = outputDto.Specification;
                    txtNote1.Text = outputDto.Note;
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
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssets() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AssetsInputDto assetsInputDto = new AssetsInputDto
                {
                    ASSID = txtAssId1.Text,
                    BUYDATE = DatePickerBuy.Value,
                    CREATEUSER = Client.Session["UserId"].ToString(),
                    IMAGE = ImgPicture.ResourceID,
                    SLID = SLID,
                    STID = STID,
                    WAREID = WAREID,
                    MODIFYUSER = Client.Session["UserId"].ToString(),
                    NAME = txtName1.Text,
                    NOTE = txtNote1.Text,
                    PLACE = txtPlace1.Text,
                    SPECIFICATION = txtSPE1.Text,
                    TYPEID = TypeId,
                    UNIT = txtUnit1.Text,
                    VENDOR = txtVendor1.Text,
                    EXPIRYDATE = DatePickerExpiry.Value,
                    SN = txtSN.Text
                };
                if (String.IsNullOrEmpty(txtPrice1.Text) == false)
                {
                    assetsInputDto.PRICE = decimal.Parse(txtPrice1.Text);
                }
                ReturnInfo returnInfo = _autofacConfig.SettingService.UpdateAssets(assetsInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("修改成功.");
                    BackBtn_Click(null,null);
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}