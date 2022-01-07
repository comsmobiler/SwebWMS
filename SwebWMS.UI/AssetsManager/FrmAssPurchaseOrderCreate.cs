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
    partial class FrmAssPurchaseOrderCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAssPurchaseOrderCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public List<AssRowInputDto> Rows = new List<AssRowInputDto>();
        public List<string> TemplateIds = new List<string>();
        private string UserId;
        private string errorInfo;
        public bool isEdit;
        public string POID;
        #endregion
        private void FrmAssPurchaseOrderCreate_Load(object sender, EventArgs e)
        {
            try
            {   //绑定采购人
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                if (users != null)
                {
                    foreach (coreUser user in users)
                    {
                        TreeSelectNode node = new TreeSelectNode(user.USER_ID, user.USER_NAME);
                        btnDealMan.Nodes.Add(node);
                    }
                }
                ///绑定供应商
                List<Vendor> vendors = _autofacConfig.vendorService.GetAll();
                if (vendors != null)
                {
                    foreach (Vendor vendor in vendors)
                    {
                        TreeSelectNode node = new TreeSelectNode(vendor.VID.ToString(), vendor.NAME);
                        btnVendor.Nodes.Add(node);
                    }
                }
                if (isEdit)
                {
                    labTitle.Text = "编辑资产采购订单";
                    var asspo = _autofacConfig.AssPurchaseOrderService.GetById(POID);
                    if (asspo != null)
                    {
                        txtPOID.Text = POID;
                        txtName.Text = asspo.NAME;
                        txtRealID.Text = asspo.REALID;
                        btnDealMan.Tag = asspo.PURCHASER;
                        //设置默认值
                        btnDealMan.DefaultValue = new string[] { asspo.PURCHASER };
                        btnVendor.Tag = asspo.VID;
                        btnVendor.DefaultValue = new string[] { asspo.VID.ToString() };
                    }
                    var assporow = _autofacConfig.AssPurchaseOrderService.GetPORows(POID);
                    if (assporow != null)
                    {
                        Rows = Mapper.Map<List<AssPORowOutputDto>, List<AssRowInputDto>>(assporow);
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAssPurchaseOrderList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                errorInfo = "";
                if (btnDealMan.Tag == null) throw new Exception("请选择采购人！");
                if (string.IsNullOrEmpty(txtName.Text)) throw new Exception("请输入名称！");
                if (btnVendor.Tag == null) throw new Exception("请选择供应商！");
                int VId = int.Parse(btnVendor.Tag.ToString());
                GetRows();
                if (!string.IsNullOrEmpty(errorInfo))
                {
                    return;
                }
                if (Rows.Count != 0)
                {
                    AssPurchaseOrderInputDto assPurchaseOrderInput = new AssPurchaseOrderInputDto()
                    {
                        POID = this.POID,
                        PURCHASER = btnDealMan.Tag.ToString(),
                        CREATEUSER = UserId,
                        MODIFYUSER = UserId,
                        NAME = txtName.Text,
                        REALID = txtRealID.Text,
                        STATUS = 0,
                        VID = VId,
                        RowInputDtos = Rows
                    };
                    ReturnInfo returnInfo;
                    if (isEdit)//编辑
                    {
                        returnInfo =
                        _autofacConfig.AssPurchaseOrderService.UpdatePurchaseOrderOnly(assPurchaseOrderInput);

                    }
                    else//新增
                    {
                        returnInfo =
                     _autofacConfig.AssPurchaseOrderService.AddPurchaseOrder(assPurchaseOrderInput);

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
        /// 编辑时加载明细
        /// </summary>
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
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你确定要删除该订单吗?", "系统提醒", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        if (string.IsNullOrEmpty(POID))
                            throw new Exception("缺少编号");
                        ReturnInfo rInfo = _autofacConfig.AssPurchaseOrderService.DeletePurchaseOrder(POID);
                        if (rInfo.IsSuccess)
                        {
                            Toast("删除订单成功");
                            ShowResult = ShowResult.Yes;
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
        /// <summary>
        /// 采购人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealMan.Tag = args.TreeID;
        }
        /// <summary>
        /// 供应商选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnCus_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnVendor.Tag = args.TreeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable AllATTable = _autofacConfig.SettingService.GetAllAssTemps();
            listPanel.Controls.Add(new AssetSaleOrderLayout(AllATTable));
        }

    }
}