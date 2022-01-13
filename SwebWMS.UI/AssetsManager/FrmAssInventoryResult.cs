using SMOWMS.CommLib;
using SMOWMS.DTOs.Enum;
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
    partial class FrmAssInventoryResult : Swebui.Controls.SwebUserControl
    {
        public FrmAssInventoryResult() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID; //盘点单编号
        private DataTable waiTable = new DataTable(); //待盘点的资产
        private DataTable alreadyTable = new DataTable(); //已盘点的资产
        private Dictionary<string, int> assDictionary = new Dictionary<string, int>();  //资产
        private List<string> assList;  //资产的初始列表
        //private List<string> RFIDlist;    //RFID的扫描数据集合
        public string WAREID;
        public string STID;
        public string SLID;
        public string typeId;
        public string DepartmentId;
        public InventoryStatus Status;
        private DataTable allAssTable = new DataTable(); //全部资产
        #endregion

        /// <summary>
        /// 返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssInventory() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        private void FrmAssInventoryResult_Load(object sender, EventArgs e)
        {

            try
            {
                lblIID.Text = IID;
                //添加各表格的列
                if (waiTable.Columns.Count == 0)
                {

                    waiTable.Columns.Add("RESULTNAME");
                    waiTable.Columns.Add("ASSID");
                    waiTable.Columns.Add("Image");
                    waiTable.Columns.Add("SLName");
                    waiTable.Columns.Add("Name");
                    waiTable.Columns.Add("Price");
                    waiTable.Columns.Add("SN");
                    waiTable.Columns.Add("TypeName");
                    waiTable.Columns.Add("Specification");


                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = waiTable.Columns["ASSID"];
                waiTable.PrimaryKey = keys;

                //添加各表格的列
                if (alreadyTable.Columns.Count == 0)
                {

                    alreadyTable.Columns.Add("RESULTNAME");
                    alreadyTable.Columns.Add("ASSID");
                    alreadyTable.Columns.Add("Image");
                    alreadyTable.Columns.Add("SLName");
                    alreadyTable.Columns.Add("Name");
                    alreadyTable.Columns.Add("Price");
                    alreadyTable.Columns.Add("SN");
                    alreadyTable.Columns.Add("TypeName");
                    alreadyTable.Columns.Add("Specification");
                }
                DataColumn[] keys2 = new DataColumn[1];
                keys2[0] = alreadyTable.Columns["ASSID"];
                alreadyTable.PrimaryKey = keys2;

                //   UserId = Client.Session["UserID"].ToString()
                //添加各表格的列
                if (allAssTable.Columns.Count == 0)
                {

                    //                    allAssTable.Columns.Add("RESULTNAME");
                    allAssTable.Columns.Add("ASSID");
                    allAssTable.Columns.Add("Image");
                    allAssTable.Columns.Add("SLName");
                    allAssTable.Columns.Add("Name");
                    allAssTable.Columns.Add("Price");
                    allAssTable.Columns.Add("SN");
                    allAssTable.Columns.Add("TypeName");
                    allAssTable.Columns.Add("Specification");
                }
                DataColumn[] keys3 = new DataColumn[1];
                keys[0] = allAssTable.Columns["SN"];
                allAssTable.PrimaryKey = keys;

                allAssTable.Rows.Clear();
                waiTable.Rows.Clear();
                alreadyTable.Rows.Clear();

                var allAssTable1 = _autofacConfig.SettingService.GetAllAss(null);
                foreach (DataRow row in allAssTable1.Rows)
                {
                    DataRow Row = allAssTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["SLName"] = row["SLName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();


                    allAssTable.Rows.Add(Row);
                }
                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                txtName.Text = inventory.NAME;
                txtHandleMan.Text = inventory.HANDLEMANNAME;
                string count = inventory.TOTAL.ToString();
                txtCount.Text = count;
                txtWare.Text = inventory.WareNAME;
                txtST.Text = string.IsNullOrEmpty(inventory.STID) ? "全部" : inventory.STNAME;
                txtSL.Text = string.IsNullOrEmpty(inventory.SLID) ? "全部" : inventory.SLNAME;
                txtType.Text = string.IsNullOrEmpty(inventory.TYPEID) ? "全部" : inventory.TYPENAME;
                Status = (InventoryStatus)inventory
                    .STATUS;
                WAREID = inventory.WAREID;
                STID = inventory.STID;
                SLID = inventory.SLID;
                if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.未盘点)
                {
                    snPanel.Visible = false;
                }


                //获得需要盘点的资产列表
                assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);

                //得到盘点单当前的所有行项
                assDictionary = _autofacConfig.AssInventoryService.GetResultDictionary(IID);

                //得到待盘点的资产列表
                var waiTable1 = _autofacConfig.AssInventoryService.GetPendingInventoryTable(IID, WAREID, STID, SLID, typeId);
                foreach (DataRow row in waiTable1.Rows)
                {
                    DataRow Row = waiTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["SLName"] = row["SLName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();


                    waiTable.Rows.Add(Row);
                }
                if (inventory.TOTAL == 0)
                {
                    txtCount.Text = "需盘点总数:" + waiTable1.Rows.Count.ToString();
                }


                //得到已盘点的资产列表
                var alreadyTable1 = _autofacConfig.AssInventoryService.GetAssInventoryResultsByIID(IID, ResultStatus.存在);
                foreach (DataRow row in alreadyTable1.Rows)
                {
                    DataRow Row = alreadyTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["SLName"] = row["SLName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();

                    alreadyTable.Rows.Add(Row);
                }
                if (Status == InventoryStatus.未盘点)
                {
                    StartBtn.Visible = true;
                    endBtn.Visible = upBtn.Visible = false;
                    snPanel.Visible = false;
                    lbSN.Visible = false;
                }
                else if (Status == InventoryStatus.盘点中)
                {
                    StartBtn.Visible = false;
                    endBtn.Visible = true;
                    upBtn.Visible = snPanel.Visible = true;
                    lbSN.Visible = true;
                }
                else if (Status == InventoryStatus.盘点结束)
                {
                    StartBtn.Visible = endBtn.Visible = upBtn.Visible = false;
                    snPanel.Visible = false;
                    snPanel.Visible = false;
                }
                //绑定数据
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private static object lockobj = new object();
        private void Bind()
        {
            lock (lockobj)
            {
                try
                {
                    waitPanel.Controls.Clear();
                    foreach (DataRow row in waiTable.Rows)
                    {
                        waitPanel.Controls.Add(new AIResultLayout()
                        {
                            ASSID = row["ASSID"].ToString(),
                            RESULTNAME = row["RESULTNAME"].ToString(),
                            Image = row["Image"].ToString(),
                            SLName = row["SLName"].ToString(),
                            NAME = row["Name"].ToString(),
                            Price = row["Price"].ToString(),
                            SN = row["SN"].ToString(),
                            TypeName = row["TypeName"].ToString(),
                            Specification = row["Specification"].ToString()

                        });
                    }
                    waitBtn.Text = "待盘点（" + waiTable.Rows.Count.ToString() + "）";
                    alPanel.Controls.Clear();
                    foreach (DataRow row in alreadyTable.Rows)
                    {
                        alPanel.Controls.Add(new AIResultLayout()
                        {
                            ASSID = row["ASSID"].ToString(),
                            RESULTNAME = row["RESULTNAME"].ToString(),
                            Image = row["Image"].ToString(),
                            SLName = row["SLName"].ToString(),
                            NAME = row["Name"].ToString(),
                            Price = row["Price"].ToString(),
                            SN = row["SN"].ToString(),
                            TypeName = row["TypeName"].ToString(),
                            Specification = row["Specification"].ToString()

                        });
                    }
                    alBtn.Text = "已盘点（" + alreadyTable.Rows.Count.ToString() + "）";
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }

        }

        /// <summary>
        /// 待盘点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waitBtn_Click(object sender, EventArgs e)
        {
            if (waitPanel.Visible == false)
            {
                waitPanel.Visible = true;
                alPanel.Visible = false;
                waitBtn.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                waitBtn.ForeColor = System.Drawing.Color.White;
                alBtn.BackColor = System.Drawing.Color.White;
                alBtn.ForeColor = System.Drawing.Color.Black;
            }
        }
        /// <summary>
        /// 已盘点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alBtn_Click(object sender, EventArgs e)
        {
            if (alPanel.Visible == false)
            {
                alPanel.Visible = true;
                waitPanel.Visible = false;
                alBtn.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                alBtn.ForeColor = System.Drawing.Color.White;
                waitBtn.BackColor = System.Drawing.Color.White;
                waitBtn.ForeColor = System.Drawing.Color.Black;
            }
        }
        /// <summary>
        /// 结束盘点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status == InventoryStatus.盘点中)
                {
                    //盘点结束
                    ReturnInfo rInfo = new ReturnInfo();
                    Dictionary<string, int> assDictionary2 = new Dictionary<string, int>();
                    foreach (var key in assDictionary.Keys)
                    {

                        if (assDictionary[key] == (int)ResultStatus.待盘点)
                        {
                            assDictionary2.Add(key, (int)ResultStatus.盘亏);
                        }
                        else
                        {
                            assDictionary2.Add(key, assDictionary[key]);
                        }
                    }


                    AssInventoryInputDto inputDto2 = new AssInventoryInputDto
                    {
                        IID = IID,
                        IsEnd = false,
                        AssDictionary = assDictionary2
                    };
                    inputDto2.IsEnd = true;
                    rInfo = _autofacConfig.AssInventoryService.UpdateInventory(inputDto2);
                    if (rInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("盘点结束成功.");
                        BackBtn_Click(null,null);
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);

            }

        }
        /// <summary>
        /// 开始盘点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //开始盘点
                AddAIResultInputDto inputDto = new AddAIResultInputDto { IID = IID };
                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                ReturnInfo returnInfo = _autofacConfig.AssInventoryService.AddAssInventoryResult(inputDto);
                if (returnInfo.IsSuccess)
                {
                    Status = InventoryStatus.盘点中;
                    upBtn.Visible = true;
                    snPanel.Visible = true;
                    lbSN.Visible = true;
                    assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);
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
        /// 上传结果 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo rInfo = new ReturnInfo();
                AssInventoryInputDto inputDto = new AssInventoryInputDto
                {
                    IID = IID,
                    IsEnd = false,
                    AssDictionary = assDictionary
                };
                inputDto.IsEnd = false;
                rInfo = _autofacConfig.AssInventoryService.UpdateInventory(inputDto);
                if (rInfo.IsSuccess)
                {
                    Toast("上传结果成功.");
                    BackBtn_Click(null, null);
                }
                else

                    throw new Exception(rInfo.ErrorInfo);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 输入SN 后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSN.Text))
                    throw new Exception("请输入SN");
                string barCode = txtSN.Text;
                string assId = "";
                //根据sn得到Assid
                var asset = _autofacConfig.SettingService.GetAssetsBySN(barCode);
                if (asset != null && asset.Rows.Count == 1)
                {
                    assId = asset.Rows[0]["ASSID"].ToString();
                    AddAssToDictionary(assId, barCode);
                    txtSN.Text = "";
                }
                else
                {
                    Toast("未找到该SN对应的资产编号.");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void AddAssToDictionary(string assid, string SN)
        {
            lock (lockobj)
            {
                try
                {
                    if (assList.Contains(assid))
                    {
                        //如果状态是待盘点，则变成存在(意味 资产在库)
                        DataRow row = waiTable.Rows.Find(assid);
                        if (row != null)
                        {
                            DataRow newRow = getNewRow(row, ResultStatus.存在);
                            assDictionary[assid] = (int)ResultStatus.存在;
                            alreadyTable.Rows.Add(newRow);
                            alPanel.Controls.Add(new AIResultLayout()
                            {
                                ASSID = newRow["ASSID"].ToString(),
                                Image = newRow["Image"].ToString(),
                                SLName = newRow["SLName"].ToString(),
                                NAME = newRow["Name"].ToString(),
                                Price = newRow["Price"].ToString(),
                                SN = newRow["SN"].ToString(),
                                TypeName = newRow["TypeName"].ToString(),
                                Specification = newRow["Specification"].ToString(),
                                RESULTNAME = "存在"
                            });
                            waitPanel.Controls.RemoveAt(waiTable.Rows.IndexOf(row));
                            waiTable.Rows.Remove(row);
                        }
                        else
                        {
                            throw new Exception("该资产已盘点");

                        }
                    }
                    else
                    {
                        //如果本来是不需要盘点的，状态改为盘盈
                        if (!assDictionary.ContainsKey(assid))
                        {
                            assDictionary.Add(assid, (int)ResultStatus.盘盈);
                        }

                        DataRow row = alreadyTable.Rows.Find(assid);
                        if (row == null)
                        {
                            DataRow asset = allAssTable.Rows.Find(SN);
                            if (asset != null)
                            {
                                DataRow newRow = getNewRow(asset, ResultStatus.盘盈);
                                alreadyTable.Rows.Add(newRow);
                                alPanel.Controls.Add(new AIResultLayout()
                                {

                                    ASSID = newRow["ASSID"].ToString(),
                                    Image = newRow["Image"].ToString(),
                                    SLName = newRow["SLName"].ToString(),
                                    NAME = newRow["Name"].ToString(),
                                    Price = newRow["Price"].ToString(),
                                    SN = newRow["SN"].ToString(),
                                    TypeName = newRow["TypeName"].ToString(),
                                    Specification = newRow["Specification"].ToString(),
                                    RESULTNAME = "盘盈"

                                });
                            }
                            else
                            {
                                throw new Exception("请输入正确的SN");

                            }
                        }
                        else
                        {
                            throw new Exception("该资产已盘点");

                        }
                    }
                    waitBtn.Text = "待盘点(" + waiTable.Rows.Count.ToString() + ")";
                    alBtn.Text = "已盘点(" + alreadyTable.Rows.Count.ToString() + ")";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        private DataRow getNewRow(DataRow datarow, ResultStatus status)
        {
            DataRow newRow = alreadyTable.NewRow();
            newRow["ASSID"] = datarow["ASSID"].ToString();
            newRow["Image"] = datarow["Image"].ToString();
            newRow["SLName"] = datarow["SLName"].ToString();
            newRow["Name"] = datarow["Name"].ToString();
            newRow["Price"] = datarow["Price"].ToString();
            newRow["SN"] = datarow["SN"].ToString();
            newRow["TypeName"] = datarow["TypeName"].ToString();
            newRow["Specification"] = datarow["Specification"].ToString();

            newRow["RESULTNAME"] = status.ToString();
            return newRow;
        }
    }
}
