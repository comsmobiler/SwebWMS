using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.OutputDTO;
using Swebui;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssets : Swebui.Controls.SwebUserControl
    {
        public FrmAssets() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectAssId;  //当前选择的资产
        private string Type;        //资产大类
        private string UserId;
        internal string wareId = "";    //所选仓库编号
        #endregion
        /// <summary>
        /// 编辑按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmAssetsEdit assetsEdit = new FrmAssetsEdit();
                    assetsEdit.Flex = 1;
                    assetsEdit.AssId = args.SelectedRows[0]["ASSID"].ToString();
                    this.Parent.Controls.Add(assetsEdit);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 查看按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    FrmAssetDetial assetsEdit = new FrmAssetDetial();
                    assetsEdit.Flex = 1;
                    assetsEdit.AssId = args.SelectedRows[0]["ASSID"].ToString();
                    this.Parent.Controls.Add(assetsEdit);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });

        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            wareId = Type = txtNote.Text = "";
            tpSearch.DefaultValue = tpWare.DefaultValue = new string[] { };
            DataTable table = _autofacConfig.SettingService.GetAllAss("");

            gridView1.Reload(table);
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssets_Load(object sender, EventArgs e)
        {
            try
            {
                ///绑定仓库
                tpWare.Nodes.Add(new TreeSelectNode("", "全部"));
                List<WareHouse> wareHouseList = _autofacConfig.wareHouseService.GetAllWareHouse();
                foreach (WareHouse Row in wareHouseList)
                {
                    tpWare.Nodes.Add(new TreeSelectNode(Row.WAREID, Row.NAME));
                }
                ///绑定类型
                tpSearch.Nodes.Add(new TreeSelectNode("", "全部"));
                List<AssetsType> types = _autofacConfig.assTypeService.GetAllFirstLevel();
                foreach (AssetsType Row in types)
                {
                    tpSearch.Nodes.Add(new TreeSelectNode(Row.TYPEID, Row.NAME));
                }

                UserId = Client.Session["UserID"].ToString();
                Bind();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.GetAllAss(wareId);
                if (table.Rows.Count > 0)
                {
                    gridView1.DataSource = table;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        ///搜索数据
        /// </summary>
        private void SearchData()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.QueryAssets(txtNote.Text, Type, wareId);
                gridView1.Reload(table);
            }

            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 按照名称或者SN查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNote_SubmitEditing(object sender, EventArgs e)
        {
            SearchData();
        }
        /// <summary>
        /// 按类别查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void tpSearch_Press(object sender, TreeSelectPressEventArgs args)
        {
            Type = args.TreeID;
            SearchData();
        }
        /// <summary>
        /// 按仓库查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void tpWare_Press(object sender, TreeSelectPressEventArgs args)
        {
            wareId = args.TreeID;
            DataTable table = _autofacConfig.SettingService.GetAllAss(wareId);
            gridView1.Reload(table);
        }
        /// <summary>
        /// 打印按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    string AssId = args.SelectedRows[0]["ASSID"].ToString();
                    try
                    {
                        Dictionary<string, string> Datas = new Dictionary<string, string>();
                        AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                        if (outputDto != null)
                        {
                            Datas.Add("资产编号", outputDto.AssId);
                            Datas.Add("SN", outputDto.SN);
                            Datas.Add("类别", outputDto.TypeName);
                            Datas.Add("过期时间", outputDto.ExpiryDate.ToString("yyyy-MM-dd"));
                            Datas.Add("购入时间", outputDto.BuyDate.ToString("yyyy-MM-dd"));
                            Datas.Add("名称", outputDto.Name);
                            Datas.Add("单位", outputDto.Unit);
                            Datas.Add("金额", outputDto.Price.ToString());
                            Datas.Add("规格型号 ", outputDto.Specification);
                            Datas.Add("地点", outputDto.Place);
                            Datas.Add("库位", outputDto.SLName);
                            Datas.Add("供应者", outputDto.Vendor);
                            Datas.Add("模板ID", outputDto.ATID);
                            Datas.Add("备注", outputDto.Note);
                            if (outputDto.Image.Contains(".")==false)
                                outputDto.Image += ".png";
                            Datas.Add("图片", SwebResourceManager.DefaultImagePath+"\\"+outputDto.Image);
                            Datas.Add("一维码", outputDto.AssId);
                            Datas.Add("二维码", outputDto.AssId);
                        }
                        PdfHelper.CreatePdf(SwebResourceManager.DefaultDocumentPath + "\\" + Client.SessionID + "Asstest.pdf", Datas);

                        string url = Swebui.SwebResourceManager.GetResourceURL(Client.SessionID, Client.SessionID + "Asstest.pdf", SwebResourceManager.DefaultDocumentPath);
                        Client.Print(url, "pdf");
                    }
                    catch (Exception ex)
                    {
                        Toast(ex.Message);
                    }
                }
                else
                {
                    Toast("未选择行！");
                }
            });

        }
    }
}