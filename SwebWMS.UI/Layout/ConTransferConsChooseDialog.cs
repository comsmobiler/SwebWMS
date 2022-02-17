using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConTransferConsChooseDialog : Swebui.Controls.SwebUserControl
    {
        public ConTransferConsChooseDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConsumablesOrderRow> RowData = new List<ConsumablesOrderRow>();    //未开启SN行项
        public string LocInID;           //调入区域编号
        #endregion
        private void ConTransferConsChooseDialog_Load(object sender, EventArgs e)
        {
            Bind(null);
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        /// <param name="Name"></param>
        public void Bind(String Name)
        {
            try
            {
            //    DataTable tableAssets = new DataTable();       //未开启SN的资产列表
            //    tableAssets.Columns.Add("CHECK");              //资产编号
            //    tableAssets.Columns.Add("CID");                //耗材编号
            //    tableAssets.Columns.Add("NAME");               //资产名称 
            //    tableAssets.Columns.Add("LOCID");              //   仓库/存储类型/库位
            //    tableAssets.Columns.Add("LOCNAME");            //   仓库名称/类型名称/库位名称
            //    tableAssets.Columns.Add("IMAGE");              //图片编号
            //    tableAssets.Columns.Add("QUANTITY");           //空闲数量
            //    tableAssets.Columns.Add("SELECTQTY");          //选择数量

                string[] LCData = LocInID.Split('/');
                List<ConQuantOutputDto> listAss = new List<ConQuantOutputDto>();
                if (String.IsNullOrEmpty(Name))     //查询所有耗材
                    listAss = autofacConfig.orderCommonService.GetUnUseCon(LCData[0], LCData[1], LCData[2], null);
                else
                {
                    List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
                    foreach (Consumables con in cons)
                    {
                        List<ConQuantOutputDto> list = autofacConfig.orderCommonService.GetUnUseCon(LCData[0], LCData[1], LCData[2], con.CID);
                        listAss.AddRange(list);
                    }
                }
                foreach (ConQuantOutputDto Row in listAss)
                {
                    Consumables cons = autofacConfig.consumablesService.GetConsById(Row.CID);
                    WHStorageLocationOutputDto WHLoc = autofacConfig.wareHouseService.GetSLByID(Row.WAREID, Row.STID, Row.SLID);
                    if (RowData.Count > 0)
                    {
                        Boolean isAdd = false;
                        foreach (ConsumablesOrderRow HaveRow in RowData)
                        {
                            if (HaveRow.CID == Row.CID && HaveRow.WAREID == Row.WAREID
                                && HaveRow.STID == Row.STID && HaveRow.SLID == Row.SLID)
                            {
                                snPanel.Controls.Add(new ConTDLayout() { IsChecked = true, CID = Row.CID, NAME = cons.NAME, LOCATIONID = Row.WAREID + "/" + Row.STID + "/" + Row.SLID, LOCATIONNAME = Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, Image = cons.IMAGE, INTRANSFERQTY = Row.QUANTITY.ToString(), Num = HaveRow.QTY.ToString() }); 
                                 isAdd = true;
                                break;
                            }
                        }
                        if (isAdd == false)
                            snPanel.Controls.Add(new ConTDLayout() { IsChecked = false, CID = Row.CID, NAME = cons.NAME, LOCATIONID = Row.WAREID + "/" + Row.STID + "/" + Row.SLID, LOCATIONNAME = Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, Image = cons.IMAGE, INTRANSFERQTY = Row.QUANTITY.ToString(), Num = "0" });
                    }
                    else
                    {
                        snPanel.Controls.Add(new ConTDLayout() { IsChecked = false, CID = Row.CID, NAME = cons.NAME, LOCATIONID = Row.WAREID + "/" + Row.STID + "/" + Row.SLID, LOCATIONNAME = Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, Image = cons.IMAGE, INTRANSFERQTY = Row.QUANTITY.ToString(), Num = "0" });
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //关闭当前页面
            try
            {
                if (RowData.Count > 0) RowData.Clear();
                foreach (ConTDLayout row in snPanel.Controls)
                {
                    if (row.IsChecked)
                    {
                        if (Convert.ToDecimal(row.Num) > Convert.ToDecimal(row.INTRANSFERQTY)) throw new Exception("调拨数量不可超过可用数量!");
                        if (Convert.ToDecimal(row.Num) == 0) throw new Exception("调拨数量不能为0!");
                        ConsumablesOrderRow Data = new ConsumablesOrderRow();
                        Data.IMAGE = row.Image;
                        Data.CID = row.CID.ToString();
                        Data.QTY = Convert.ToDecimal(row.Num);
                        string[] datas = row.LOCATIONID.Split('/');
                        Data.WAREID = datas[0];
                        Data.STID = datas[1];
                        Data.SLID = datas[2];
                        Data.STATUS = 0;
                        RowData.Add(Data);
                    }
                }
                ShowResult = ShowResult.Yes;
                Close();
            }catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Cancel;
            this.Close();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach(ConTDLayout row in snPanel.Controls)
                {
                    row.IsChecked = CheckAll.Checked;
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            snPanel.Controls.Clear();
            Bind(txtName.Text);
        }
    }
}