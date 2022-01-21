using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssIn : Swebui.Controls.SwebUserControl
    {
        public FrmAssIn() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string POID;
        private decimal Total;
        private string Image;
        private List<string> snList = new List<string>();  //资产的初始列表
        #endregion
        private void FrmAssIn_Load(object sender, EventArgs e)
        {
            ///获取未完成的采购订单
            List<AssPOListOutputDto> asspoList = _autofacConfig.AssPurchaseOrderService.GetIncompleteOrders("");
            if (asspoList != null && asspoList.Count > 0)
            {
                foreach (var dto in asspoList)
                {
                    txtPOID.Nodes.Add(new TreeSelectNode(dto.POID, dto.POID + dto.NAME));
                }
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            txtPOID.Nodes.Clear();
            txtPOID.DefaultValue = new string[] { };
            ///获取未完成的采购订单
            List<AssPOListOutputDto> asspoList = _autofacConfig.AssPurchaseOrderService.GetIncompleteOrders("");
            if (asspoList != null && asspoList.Count > 0)
            {
                foreach (var dto in asspoList)
                {
                    txtPOID.Nodes.Add(new TreeSelectNode(dto.POID, dto.POID + dto.NAME));
                }
            }
            btnTemplate.Nodes.Clear();
            btnTemplate.DefaultValue = new string[] { };
            POID = "";
            Image = "";
            snList.Clear();
            snPanel.Controls.Clear();
            lblQuant.Text = "";
            txtSLID.Text = "";
            txtSN.Text = "";

        }
        private void txtPOID_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                string barCode = args.TreeID;
                bool IsExist = _autofacConfig.AssPurchaseOrderService.POIDIsExist(barCode);
                if (IsExist)
                {
                    if (POID != barCode)
                    {
                        POID = barCode;
                    }
                    GetTemplateNodes();
                }
                else
                {
                    throw new Exception("请选择正确的采购单编号！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        private void GetTemplateNodes()
        {
            btnTemplate.DefaultValue = new string[] { };
            btnTemplate.Nodes.Clear();
            List<AssTempOutputDto> assTemp =
             _autofacConfig.AssPurchaseOrderService.GetTemplateList(POID);
            foreach (AssTempOutputDto Row in assTemp)
            {
                btnTemplate.Nodes.Add(new TreeSelectNode(Row.TEMPLATEID, Row.NAME));
            }
        }
        private void GetTotal()
        {
            //得到需要输入的SN数量
            if (btnTemplate.Tag != null && string.IsNullOrEmpty(POID) == false)
            {
                var porow = _autofacConfig.AssPurchaseOrderService.GetPORows(POID);
                if (porow == null) throw new ArgumentNullException("porow");
                var row = porow.Find(a => a.TEMPLATEID == btnTemplate.Tag.ToString());
                if (row != null)
                {
                    Total = row.QUANTPURCHASED - row.QUANTSTORED;
                    lblQuant.Text = Total.ToString();
                }

            }
        }

        public void ClearInfo()
        {

        }

        private void btnTemplate_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {

                btnTemplate.Tag = args.TreeID;
                AssTemplate tempOutput = _autofacConfig.SettingService.GetAtbyId(btnTemplate.Tag.ToString());
                Image = tempOutput.IMAGE;
                GetTotal();
                //lblQuant.Text = "剩余:  " + GetRest();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region 校验库位
                string barCode = txtSLID.Text;
                string WareId = "";
                string STID = "";
                string SLID = "";

                string[] Ids = barCode.Split('/');
                WareId = Ids[0];
                if (Ids.Length == 3)
                {
                    STID = Ids[1];
                    SLID = Ids[2];
                }
                else
                {
                    throw new Exception("该库位编号不存在！");
                }
                if (_autofacConfig.wareHouseService.SLIsExists(WareId, STID, SLID))
                {
                    WHStorageLocationOutputDto whLoc = _autofacConfig.wareHouseService.GetSLByID(WareId, STID, SLID);
                    if (whLoc == null) throw new Exception("库位不存在，请检查!");
                    //txtSLID.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                    txtSLID.Tag = barCode;
                }
                else
                {
                    throw new Exception("该库位编号不存在！");
                }
                #endregion
                #region 入库
                if (snPanel.Controls.Count == 0)
                {
                    throw new Exception("请添加要入库的序列号！");
                }
                else
                {
                    snList.Clear();
                    foreach (SNRowLayout sNRow in snPanel.Controls)
                    {
                        snList.Add(sNRow.SN);
                    }
                }
                ReturnInfo rInfo = new ReturnInfo();
                AssInStorageInputDto inputDto = new AssInStorageInputDto
                {
                    POID = this.POID,
                    SLID = SLID,
                    STID = STID,
                    WAREID = WareId,
                    TEMPLATEID = btnTemplate.Tag.ToString(),
                    UserId = Client.Session["UserID"].ToString(),
                    SnList = snList
                };
                rInfo = _autofacConfig.AssPurchaseOrderService.InstorageAss(inputDto);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    //                    Toast("入库成功！");
                    btnTemplate.DefaultValue = new string[] { };
                    btnTemplate.Tag = null;
                    txtSLID.Text = "";
                    txtSLID.Tag = null;
                    txtSN.Text = "";
                    txtSN.Text = "";
                    snList.Clear();
                    snPanel.Controls.Clear();
                    //查询采购单状态
                    var po = _autofacConfig.AssPurchaseOrderService.GetById(this.POID);

                    //如果全部完成，则提示该订单已经完成入库
                    if (po.STATUS == (int)PurchaseOrderStatus.已完成)
                    {
                        Toast("该订单已全部入库完成！");
                        txtPOID.DefaultValue = new string[] { };
                        btnTemplate.Nodes.Clear();
                        txtPOID.Tag = null;
                        lblQuant.Text = "";
                    }
                    else
                    {
                        Toast("入库成功！");
                        GetTotal();
                        lblQuant.Text = "";
                        GetTemplateNodes();
                    }

                }
                else
                {
                    throw new Exception(rInfo.ErrorInfo);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 添加入库行项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSN.Text.Trim()))
                    throw new Exception("请输入SN号");
                    string barCode = txtSN.Text.Trim();
                    if (snPanel.Controls.Count == 0)
                    {
                        bool isExists = _autofacConfig.SettingService.SNIsExists(barCode);
                        if (!isExists)
                        {
                            AddSnToPanel(barCode);
                        }
                        else
                        {
                            throw new Exception("该序列号已经存在！");
                        }
                    }
                    else
                    {
                        bool isExists = false;
                        foreach (SNRowLayout sNRow in snPanel.Controls)
                        {
                            if (sNRow.SN == txtSN.Text)
                            {
                                isExists = true;
                                break;
                            }
                        }
                        if (isExists)
                        {
                            throw new Exception("该序列号已经存在！");
                        }
                        else
                        {
                            isExists = _autofacConfig.SettingService.SNIsExists(barCode);
                            if (!isExists)
                            {
                                AddSnToPanel(barCode);
                            }
                            else
                            {
                                throw new Exception("该序列号已经存在！");
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void AddSnToPanel(string sn)
        {
            txtSN.Text = "";
            snPanel.Controls.Add(new SNRowLayout() { Image = this.Image, SN = sn });
        }
    }
}