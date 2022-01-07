using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using Swebui;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssTemplateCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAssTemplateCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string UserId; //用户名
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string TempId;  //资产模板编号
        #endregion
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssTemplate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnType.Tag == null)
                {
                    throw new Exception("请选择类别.");
                }
                decimal? price = null;

                if (!string.IsNullOrEmpty(txtPrice.Text))
                {
                    decimal p2;
                    if (!decimal.TryParse(txtPrice.Text, out p2))
                    {
                        throw new Exception("请输入正确的价格.");
                    }
                    else
                    {
                        price = p2;
                    }
                }
                if (string.IsNullOrEmpty(TempId))//新增
                {
                    AssTemplateInputDto assTemplateInputDto = new AssTemplateInputDto
                    {
                        IMAGE = ImgPicture.ResourceID,
                        NAME = txtName.Text,
                        NOTE = txtNote.Text,
                        PRICE = price,
                        SPECIFICATION = txtSpe.Text,
                        TYPEID = btnType.Tag.ToString(),
                        UNIT = txtUnit.Text,
                        VENDOR = txtVendor.Text
                    };
                    ReturnInfo returnInfo = _autofacConfig.SettingService.AddAssTemplate(assTemplateInputDto);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("添加成功.资产模板编号为" + returnInfo.ErrorInfo);
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }
                else//编辑
                {
                    AssTemplateInputDto assTemplateInputDto = new AssTemplateInputDto
                    {
                        TEMPLATEID = TempId,
                        IMAGE = ImgPicture.ResourceID,
                        NAME = txtName.Text,
                        NOTE = txtNote.Text,
                        PRICE = price,
                        SPECIFICATION = txtSpe.Text,
                        TYPEID = btnType.Tag.ToString(),
                        UNIT = txtUnit.Text,
                        VENDOR = txtVendor.Text
                    };
                    ReturnInfo returnInfo = _autofacConfig.SettingService.UpdateAssTemplate(assTemplateInputDto);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("修改成功.");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Client.FileUpload((obj, args) =>
                {

                    if (string.IsNullOrEmpty(args.error))
                    {
                        string imgName = "";
                        if (string.IsNullOrEmpty(ImgPicture.ResourceID))
                        {
                            string[] name = args.ResourceID.Split('.');
                            imgName = UserId + DateTime.Now.ToString("yyyyMMddHHmmss") + name[1];
                        }
                        else
                        {
                            string[] name = args.ResourceID.Split('.');
                            string[] firstName = ImgPicture.ResourceID.Split(',');
                            imgName = firstName[0] + name[1];
                        }
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        ImgPicture.ResourceID = imgName;
                        ImgPicture.Refresh();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssTemplateCreate_Load(object sender, EventArgs e)
        {
            try
            {
                #region"获取类别"
                List<AssetsType> Data = _autofacConfig.assTypeService.GetAll();
                if (Data != null && Data.Count > 0)
                {
                    foreach (var type in Data)
                    {
                        if (type.TLEVEL == 1)
                        {
                            TreeSelectNode firstNode = new TreeSelectNode(type.TYPEID, type.NAME);
                            foreach (var type1 in Data)
                            {
                                if (string.IsNullOrEmpty(type1.PARENTTYPEID) == false && type1.PARENTTYPEID == type.TYPEID.ToString())
                                {
                                    TreeSelectNode secondNode = new TreeSelectNode(type1.TYPEID, type1.NAME);
                                    foreach (var type2 in Data)
                                    {
                                        if (string.IsNullOrEmpty(type2.PARENTTYPEID) == false && type2.PARENTTYPEID == type1.TYPEID.ToString())
                                        {
                                            TreeSelectNode Node = new TreeSelectNode(type2.TYPEID, type2.NAME);
                                            secondNode.Nodes.Add(Node);
                                        }
                                    }
                                    firstNode.Nodes.Add(secondNode);
                                }
                            }
                            btnType.Nodes.Add(firstNode);
                        }
                    }
                }
                #endregion
                if (string.IsNullOrEmpty(TempId) == false)
                {
                    AssTemplate outputDto = _autofacConfig.SettingService.GetAtbyId(TempId);
                    if (outputDto != null)
                    {
                        txtAssID.Text = outputDto.TEMPLATEID;
                        txtName.Text = outputDto.NAME;
                        txtPrice.Text = outputDto.PRICE.ToString();
                        txtSpe.Text = outputDto.SPECIFICATION;
                        txtUnit.Text = outputDto.UNIT;
                        txtVendor.Text = outputDto.VENDOR;
                        ImgPicture.ResourceID = outputDto.IMAGE;
                        txtNote.Text = outputDto.NOTE;
                        btnType.DefaultValue = new string[] { outputDto.TYPEID };
                        btnType.Tag = outputDto.TYPEID;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 类型选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnType_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnType.Tag = args.TreeID;
        }
    }
}