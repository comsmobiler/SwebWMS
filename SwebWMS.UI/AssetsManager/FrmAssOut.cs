using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssOut : Swebui.Controls.SwebUserControl
    {
        public FrmAssOut() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private List<string> snList = new List<string>();  //资产的初始列表
        private List<string> TemplateIds = new List<string>();
        #endregion
        private void FrmAssOut_Load(object sender, EventArgs e)
        {
            List<AssSOListOutputDto> asssoList = _autofacConfig.AssSalesOrderService.GetIncompleteOrders("");
            if (asssoList != null && asssoList.Count > 0)
            {
                foreach (var assso in asssoList)
                {
                    txtSOID.Nodes.Add(new TreeSelectNode(assso.SOID, assso.SOID + assso.NAME));
                }
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (snPanel.Controls.Count == 0)
                {
                    throw new Exception("请添加要出库的序列号！");
                }
                snList.Clear();
                foreach (SNRowLayout sNRow in snPanel.Controls)
                {
                    snList.Add(sNRow.SN);
                }
                ReturnInfo rInfo = new ReturnInfo();
                AssSalesInputDto inputDto = new AssSalesInputDto
                {
                    SOID = txtSOID.Tag.ToString(),
                    UserId = Client.Session["UserId"].ToString(),
                    sns = snList
                };
                rInfo = _autofacConfig.AssSalesOrderService.SaleAss(inputDto);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    //                    Toast("出库成功！");
                    snList.Clear();
                    snPanel.Controls.Clear();
                    var so = _autofacConfig.AssSalesOrderService.GetById(txtSOID.Tag.ToString());
                    if (so != null)
                    {
                        if (so.STATUS == (int)SalesOrderStatus.已完成)
                        {
                            Toast("出库完成！");
                            RefreshBtn_Click(null,null);

                        }
                        else
                        {
                            RefreshBtn_Click(null, null);
                            Toast("出库成功！");;
                        }
                    }

                }
                else
                {
                    throw new Exception(rInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            txtSOID.Nodes.Clear();
            List<AssSOListOutputDto> asssoList = _autofacConfig.AssSalesOrderService.GetIncompleteOrders("");
            if (asssoList != null && asssoList.Count > 0)
            {
                foreach (var assso in asssoList)
                {
                    txtSOID.Nodes.Add(new TreeSelectNode(assso.SOID, assso.SOID + assso.NAME));
                }
            }
            snList.Clear();
            TemplateIds.Clear();
            txtSOID.DefaultValue = new string[] { };
            snPanel.Controls.Clear();
            txtSN.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string barCode = txtSN.Text ;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.SettingService.SOSNIsExists(barCode, TemplateIds);
                    if (isExists)
                    {
                        Assets assets = _autofacConfig.SettingService.GetBySN(barCode);
                        snPanel.Controls.Add(new SNRowLayout() { Image = assets.IMAGE, SN = barCode });
                    }
                    else
                    {
                        throw new Exception("该序列号不在库中！");
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void txtSOID_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                txtSOID.Tag = args.TreeID;
                var tempOutputDtos = _autofacConfig.AssSalesOrderService.GetTemplateList(args.TreeID);
                foreach (var tempOutput in tempOutputDtos)
                {
                    TemplateIds.Add(tempOutput.TEMPLATEID);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}