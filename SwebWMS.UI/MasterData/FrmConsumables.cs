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
    partial class FrmConsumables : Swebui.Controls.SwebUserControl
    {
        public FrmConsumables() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion
        /// <summary>
        /// 页面初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConsumables_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable conTable = _autofacConfig.consumablesService.GetConList();
                gridView1.DataSource = conTable;
                gridView1.DataBind();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 新增按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmConsumablesCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
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
                    FrmConsumablesDetailEdit assetsEdit = new FrmConsumablesDetailEdit();
                    assetsEdit.Flex = 1;
                    assetsEdit.CID = args.SelectedRows[0]["CID"].ToString();
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
                    FrmConsumablesDetail assetsEdit = new FrmConsumablesDetail();
                    assetsEdit.Flex = 1;
                    assetsEdit.CID = args.SelectedRows[0]["CID"].ToString();
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
            try
            {
                DataTable conTable = _autofacConfig.consumablesService.GetConList();
                gridView1.Reload(conTable);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                    string CID = args.SelectedRows[0]["CID"].ToString();
                    try
                    {
                        Dictionary<string, string> Datas = new Dictionary<string, string>();
                        var consumables = _autofacConfig.consumablesService.GetConsById(CID);
                        Datas.Add("编号", consumables.CID);
                        Datas.Add("名称", consumables.NAME);
                        Datas.Add("单位", consumables.UNIT); Datas.Add("标准包装数量", consumables.SPQ.ToString());
                        Datas.Add("安全库存上限", consumables.SAFECEILING.ToString());
                        Datas.Add("安全库存下限", consumables.SAFEFLOOR.ToString());
                        Datas.Add("规格型号", consumables.SPECIFICATION);
                        Datas.Add("备注", consumables.NOTE);
                        Datas.Add("一维码", consumables.CID);
                        Datas.Add("二维码", consumables.CID);
                        Datas.Add("图片", SwebResourceManager.DefaultImagePath + "\\"+consumables.IMAGE);
                        PdfHelper.CreatePdf(SwebResourceManager.DefaultDocumentPath + "\\" + Client.SessionID + "Contest.pdf", Datas);

                        string url = Swebui.SwebResourceManager.GetResourceURL(Client.SessionID, Client.SessionID + "Contest.pdf", SwebResourceManager.DefaultDocumentPath);
                        Client.Print(url, "pdf");
                    }
                    catch (Exception ex)
                    {


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