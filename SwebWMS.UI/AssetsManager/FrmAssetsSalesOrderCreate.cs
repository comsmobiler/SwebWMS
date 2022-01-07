using AutoMapper;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
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
    partial class FrmAssetsSalesOrderCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAssetsSalesOrderCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string UserId;
        private string errorInfo;
        List<AssRowInputDto> Rows = new List<AssRowInputDto>();
        public bool isEdit;
        public string SOID;
        #endregion

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssetsSalesOrderCreate_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                //选择销售人
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                if (users != null)
                {
                    foreach (coreUser user in users)
                    {
                        TreeSelectNode node = new TreeSelectNode(user.USER_ID, user.USER_NAME);
                        btnDealMan.Nodes.Add(node);
                    }
                }
                //选择客户
                List<Customer> customers = _autofacConfig.customerService.GetAll();
                if (customers != null)
                {
                    foreach (Customer customer in customers)
                    {
                        TreeSelectNode node = new TreeSelectNode(customer.CUSID.ToString(), customer.NAME);
                        btnCus.Nodes.Add(node);
                    }
                }
                if (isEdit)//编辑初始化
                {
                    labTitle.Text = "编辑资产销售订单";
                    var assso = _autofacConfig.AssSalesOrderService.GetById(SOID);
                    if (assso != null)
                    {
                        txtPOID.Text = SOID;
                        txtName.Text = assso.NAME;
                        txtRealID.Text = assso.REALID;
                        btnDealMan.Tag = assso.SALESPERSON;
                        //设置默认值
                          btnDealMan.DefaultValue= new string[] { assso.SALESPERSON };
                        btnCus.Tag = assso.CUSID;
                        btnCus.DefaultValue= new string[] { assso.CUSID.ToString() };
                    }
                    var assSorow = _autofacConfig.AssSalesOrderService.GetSORows(SOID);
                    if (assSorow != null)
                    {
                        Rows = Mapper.Map<List<AssSORowOutputDto>, List<AssRowInputDto>>(assSorow);
                        LoadRows();
                    }
                    DeleteBtn.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssetsSalesOrderList() { Flex = 1 });
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
                errorInfo = "";
                if (btnDealMan.Tag == null) throw new Exception("请选择销售人！");
                if (string.IsNullOrEmpty(txtName.Text)) throw new Exception("请输入名称！");
                if (btnCus.Tag == null) throw new Exception("请选择客户！");
                int CusId = int.Parse(btnCus.Tag.ToString());
                GetRows();
                if (!string.IsNullOrEmpty(errorInfo))
                {
                    return;
                }
                if (Rows.Count > 0)
                {
                    AssSalesOrderInputDto assSalesOrderInput = new AssSalesOrderInputDto()
                    {
                        SOID = this.SOID,
                        SALESPERSON = btnDealMan.Tag.ToString(),
                        CREATEUSER = UserId,
                        MODIFYUSER = UserId,
                        NAME = txtName.Text,
                        REALID = txtRealID.Text,
                        STATUS = 0,
                        CUSID = CusId,
                        RowInputDtos = Rows
                    };
                    ReturnInfo returnInfo;
                    if (isEdit)
                    {
                        returnInfo = _autofacConfig.AssSalesOrderService.UpdateSalesOrderOnly(assSalesOrderInput);
                    }
                    else
                    {
                        returnInfo = _autofacConfig.AssSalesOrderService.AddSalesOrder(assSalesOrderInput);
                    }
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        if (isEdit)
                            Toast("编辑成功");
                        else
                            Toast("添加成功");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }
                else
                {
                    throw new Exception("请添加行项！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 得到行项数据
        /// </summary>
        public void GetRows()
        {
            Rows.Clear();
            if (listPanel.Controls != null)
            {
                foreach (AssetSaleOrderLayout Row in listPanel.Controls)
                {
                    if (Rows.Find(a => a.TEMPLATEID == Row.TemplateID) != null)
                    {
                        throw new Exception("请将编号重复的项合并！");
                    }
                    AssRowInputDto rowInputDto = new AssRowInputDto();
                    rowInputDto.TEMPLATEID = Row.TemplateID;
                    rowInputDto.QUANT = Convert.ToDecimal(Row.NumQuant);
                    rowInputDto.PRICE = Convert.ToDecimal(Row.NumPrice);
                    rowInputDto.CREATEUSER = UserId;
                    rowInputDto.MODIFYUSER = UserId;
                    if (rowInputDto.QUANT == 0 || rowInputDto.PRICE == 0)
                    {
                        errorInfo = "请保证行项中的数量和单价均不为0！";
                        throw new Exception("请保证行项中的数量和单价均不为0！");
                    }
                    Rows.Add(rowInputDto);
                }
            }
        }
        public void LoadRows()
        {
            if (Rows.Count > 0)
            {
                DataTable AllATTable = _autofacConfig.SettingService.GetAllAssTemps();
                foreach (AssRowInputDto dto in Rows)
                {
                    listPanel.Controls.Add(new AssetSaleOrderLayout(AllATTable) { TemplateID = dto.TEMPLATEID, NumQuant = dto.QUANT.ToString(), NumPrice = dto.PRICE.ToString(), Img = dto.IMAGE });
                }
            }
        }
        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你确定要删除该订单吗?", "系统提醒", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        if (string.IsNullOrEmpty(SOID))
                            throw new Exception("缺少编号");
                        ReturnInfo rInfo = _autofacConfig.AssSalesOrderService.DeleteSalesOrder(SOID);
                        if (rInfo.IsSuccess)
                        {
                            Toast("删除订单成功");
                            BackBtn_Click(null, null);
                        }
                        else
                        {
                            throw new Exception(rInfo.ErrorInfo);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Form.Toast(ex.Message);
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable AllATTable = _autofacConfig.SettingService.GetAllAssTemps();
            listPanel.Controls.Add(new AssetSaleOrderLayout(AllATTable));
        }
        /// <summary>
        /// 客户选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnCus_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnCus.Tag = args.TreeID;
        }
        /// <summary>
        /// 销售人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealMan.Tag = args.TreeID;
        }
    }
}