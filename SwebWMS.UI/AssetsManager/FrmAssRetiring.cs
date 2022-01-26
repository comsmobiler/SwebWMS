using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
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
    partial class FrmAssRetiring : Swebui.Controls.SwebUserControl
    {
        public FrmAssRetiring() : base()
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
        public string SOID;

        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssRetiring_Load(object sender, EventArgs e)
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
                if (!string.IsNullOrEmpty(SOID))
                {
                    txtSOID.Text = SOID;
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
            this.Parent.Controls.Add(new FrmAssetsSalesOrderDetail() { Flex=1,SOID=SOID }) ;
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string WareId = "";
                string STID = "";
                string SLID = "";
                if (txtSLID.Text != null)
                {
                    string[] Ids = txtSLID.Text.ToString().Split('/');
                    if (Ids.Length == 3)
                    {
                        WareId = Ids[0];
                        STID = Ids[1];
                        SLID = Ids[2];
                    }
                    else
                    {
                        throw new Exception("请输入正确的库位");
                    }

                }
                else
                {
                    throw new Exception("请输入库位！");
                }
                snList.Clear();
                if (snPanel.Controls.Count == 0)
                {
                    throw new Exception("请添加要退库的序列号！");
                }
                foreach(SNRowLayout layout in snPanel.Controls)
                {
                    snList.Add(layout.SN);
                }
                ReturnInfo rInfo = new ReturnInfo();
                AssRetiringInputDto inputDto = new AssRetiringInputDto
                {
                    SOID = txtSOID.Text,
                    SLID = SLID,
                    STID = STID,
                    WAREID = WareId,
                    UserId = UserId,
                    SnList = snList
                };
                rInfo = _autofacConfig.AssSalesOrderService.RetiringAss(inputDto);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("退库成功！");
                    RefreshBtn_Click(null, null);
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
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            snList.Clear();
            txtSLID.Text = "";
            txtSN.Text = "";
            snPanel.Controls.Clear();
        }
        /// <summary>
        /// 添加资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string barCode = txtSN.Text;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.AssSalesOrderService.SNIsOK(SOID, barCode);
                    if (isExists)
                    {
                        Assets assets = _autofacConfig.SettingService.GetSaledAssBySN(barCode);
                        if(assets==null)
                            throw new Exception("该序列号不在单据的销售项中！");
                        AddSnToDataTable(barCode, assets.IMAGE);
                    }
                    else
                    {
                        throw new Exception("该序列号不在单据的销售项中！");
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
                    foreach(SNRowLayout layout in snPanel.Controls)
                    {
                        if (layout.SN == SN)
                            throw new Exception("已添加序列号为"+SN+"的资产！");
                    }
                    snPanel.Controls.Add(new SNRowLayout() { Image = Image, SN = SN });
                }
            }
        }

    }
}