using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssReturn : Swebui.Controls.SwebUserControl
    {
        public FrmAssReturn() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string UserId;
        private DataTable SNTable = new DataTable(); //待盘点的资产
        private static object lockobj = new object();
        private List<string> snList = new List<string>();  //资产的初始列表
        public string POID;
        public bool IsFromPO;
        #endregion
        private void FrmAssReturn_Load(object sender, EventArgs e)
        {
            try
            {
                //添加各表格的列
                if (SNTable.Columns.Count == 0)
                {
                    SNTable.Columns.Add("SN");
                    SNTable.Columns.Add("IMAGE");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = SNTable.Columns["SN"];
                SNTable.PrimaryKey = keys;

                UserId = Client.Session["UserID"].ToString();
                if (!string.IsNullOrEmpty(POID))
                {
                    txtPOID.Text = POID;
                    ImgBtnForPOID.Visible = false;
                    //                    txtPOID.Size = new Size(200, 30);
                }

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
                if (snList.Count == 0)
                {
                    throw new Exception("请添加要退货的序列号！");
                }
                ReturnInfo rInfo = new ReturnInfo();
                AssReturnInputDto inputDto = new AssReturnInputDto
                {
                    POID = txtPOID.Text,
                    UserId = UserId,
                    sns = snList
                };
                rInfo = _autofacConfig.AssPurchaseOrderService.ReturnAss(inputDto);

                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("退货成功！");
                    if (IsFromPO)
                    {
                        Close();
                    }
                }
                else
                {
                    Toast(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtSOID_Press(object sender, TreeSelectPressEventArgs args)
        {
            foreach (SNRowLayout layout in snPanel.Controls)
            {
                if (layout.SN == barCode)
                    throw new Exception("该序列号已添加");
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string barCode = txtSN.Text;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.AssPurchaseOrderService.SNIsOK(POID, barCode);
                    if (isExists)
                    {
                        Assets assets = _autofacConfig.SettingService.GetBySN(barCode);
                        AddSnToDataTable(barCode, assets.IMAGE);
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
        /// <summary>
        /// 把扫描到的资产添加到对应的Dictionary
        /// </summary>
        /// <param name="SN">序列号</param>
        private void AddSnToDataTable(string SN, string Image)
        {
            lock (lockobj)
            {
                DataRow row = SNTable.Rows.Find(SN);
                if (row == null)
                {
                    DataRow newRow = SNTable.NewRow();
                    newRow["SN"] = SN;
                    newRow["IMAGE"] = Image;
                    SNTable.Rows.Add(newRow);

                    var newdt = SNTable.Clone();
                    newdt.ImportRow(newRow);
                    snList.Add(SN);
                    lvSN.NewRow(newdt, "");
                }
            }
        }

    }
}