using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmConsumablesCreate : Swebui.Controls.SwebUserControl
    {
        public FrmConsumablesCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConsumables() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //判断有效性
                int? Ceiling = null;
                if (!string.IsNullOrEmpty(txtCeiling.Text))
                {
                    int result;
                    if (int.TryParse(txtCeiling.Text, out result))
                    {
                        Ceiling = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的安全库存上限.");
                    }
                }
                int? Floor = null;
                if (!string.IsNullOrEmpty(txtFloor.Text))
                {
                    int result;
                    if (int.TryParse(txtFloor.Text, out result))
                    {
                        Floor = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的安全库存下限.");
                    }
                }
                int? SPQ = null;
                if (!string.IsNullOrEmpty(txtSPQ.Text))
                {
                    int result;
                    if (int.TryParse(txtSPQ.Text, out result))
                    {
                        SPQ = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的标准包装数量.");
                    }
                }
                ConsumablesInputDto consumablesInputDto = new ConsumablesInputDto()
                {
                    CREATEUSER = Client.Session["UserId"].ToString(),
                    IMAGE = ImgPicture.ResourceID,
                    MODIFYUSER = Client.Session["UserId"].ToString(),
                    NAME = txtName.Text,
                    NOTE = txtNote.Text,
                    SAFECEILING = Ceiling,
                    SAFEFLOOR = Floor,
                    SPECIFICATION = txtCeiling.Text,
                    SPQ = SPQ,
                    UNIT = txtUnit.Text
                };
                ReturnInfo returnInfo = _autofacConfig.consumablesService.AddConsumables(consumablesInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("添加成功.");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(returnInfo.ErrorInfo);
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
                        string[] suffixs = args.ResourceID.Split('.');
                        string name = Client.Session["UserId"].ToString() + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + suffixs[1];
                        args.SaveFile(name, Swebui.SwebResourceManager.DefaultImagePath);
                        ImgPicture.ResourceID = name;
                        Toast("上传成功！");
                    }
                    else
                        throw new Exception(args.error);
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


    }
}