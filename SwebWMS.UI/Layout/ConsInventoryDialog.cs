using SMOWMS.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConsInventoryDialog : Swebui.Controls.SwebUserControl
    {
        public ConsInventoryDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 定义变量
        AutofacConfig autofacConfig = new AutofacConfig();
        public string ConLocation;
        public string ConLocationName;
        public string IID;
        #endregion

        public string CID
        {
            get { return lblName.Tag.ToString(); }
        }
        public decimal RealAmount
        {
            get
            {
                return Convert.ToDecimal(txtRealAmount.Text);
            }
        }
        /// <summary>
        /// 确定操作，进行数量盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblName.Tag == null) throw new Exception("请选择盘点耗材");
                if (String.IsNullOrEmpty(txtRealAmount.Text)) throw new Exception("实盘数量不能为空!");
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRealAmount.Text.Trim(), "^\\d+$") == false)
                {
                    throw new Exception("请输入数字!");
                }
                this.ShowResult = ShowResult.Yes;
                this.Close();          //关闭当前弹出框
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Cancel;
            this.Close();
        }

        private void ConsInventoryDialog_Load(object sender, EventArgs e)
        {
            lblSL.Text = ConLocationName;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(lblName.Text) == false)
                {
                    String cId = lblName.Text;
                    Consumables con = autofacConfig.consumablesService.GetConsById(cId);
                    if (con == null) throw new Exception("不存在此耗材");
                    String[] locData = ConLocation.Split('/');
                    ConInventoryResult result = autofacConfig.ConInventoryService.GetResultBySL(
                    IID, lblName.Text,
                       locData[0], locData[1], locData[2]);
                    if (result == null) throw new Exception("不存在该盘点行项");

                    lblName.Text = con.NAME;
                    lblName.Tag = con.CID;
                    lblNumber.Text = result.TOTAL.ToString();
                }
                else
                    throw new Exception("请输入耗材编号！");
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}