using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SwebWMS.UI.UserInfo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmUserInfo : Swebui.Controls.SwebUserControl
    {
        public FrmUserInfo() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户名
                                     //  public EuserInfo eInfo;            //用户修改项
        private coreUser UserData;
        public Boolean isDemo;       //是否是演示账号
                                     //   private EditUserInfoLayout Dialog = new EditUserInfoLayout();     //修改信息
        private int Sex = 0;
        #endregion
        private void editBtn_Click(object sender, EventArgs e)
        {
            btnEmail.ReadOnly = false;
            txtAddress.ReadOnly = false;
            btnName.ReadOnly = false;
            editBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            btnSex.Disabled = false;
            dpkBirthday.Enable = true;
            txtPhone.ReadOnly = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserData.USER_NAME = btnName1.Text.Trim();
                UserData.USER_SEX = Sex;

                UserData.USER_BIRTHDAY = dpkBirthday.Value;
                UserData.USER_ADDRESS = txtAddress.Text.Trim();
                if (string.IsNullOrEmpty(btnEmail.Text.Trim()) == false)
                {
                    Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");
                    if (RegEmail.Match(btnEmail.Text.Trim()).Success)
                        UserData.USER_EMAIL = btnEmail.Text.Trim();
                    else
                        throw new Exception("请填写正确的邮箱");
                }
                if (string.IsNullOrEmpty(txtPhone.Text.Trim()) == false)
                {
                    Regex Regphone = new Regex("^\\+?[1-9][0-9]*$");
                    if (Regphone.Match(txtPhone.Text.Trim()).Success)
                        UserData.USER_PHONE = txtPhone.Text.Trim();
                    else
                        throw new Exception("请填写正确的电话号码");
                }
                ReturnInfo resultInfo = autofacConfig.coreUserService.UpdateUser(UserData);
                if (resultInfo.IsSuccess)
                    cancelBtn_Click(null, null);
                else
                    throw new Exception(resultInfo.ErrorInfo);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmUserInfo() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        ///更换头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Client.FileUpload((obj,args)=>
                {
                    if (args.isError == false)
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        args.SaveFile(UserID +"."+ suffixs[1], Swebui.SwebResourceManager.DefaultImagePath);
                        userImg.ResourceID =userImg1.ResourceID=UserID+"."+suffixs[1];
                        coreUser UserInfo = new coreUser();
                        UserInfo.USER_ID = UserID;
                        UserInfo.USER_IMAGEID = userImg.ResourceID;
                        ReturnInfo RInfo = autofacConfig.coreUserService.UpdateUser(UserInfo, EuserInfo.修改头像);
                        if (RInfo.IsSuccess)
                        {
                            Toast("修改头像成功!");
                        }
                        else
                        {
                            throw new Exception(RInfo.ErrorInfo);
                        }
                    }
                    else
                        throw new Exception(args.error);
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void psdChange_Click(object sender, EventArgs e)
        {
            if (Client.Session["UserId"].ToString() == "13123456789" || Client.Session["UserId"].ToString() == "12345678917")
            {
                Toast("测试用户没有此权限");
            }
            else
                ShowDialog(new EditPsdDialog());
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            try
            {
                // 设置菜单栏默认选中项
                //  menuToolbar.SelectedIndex = 4;

                UserID = Client.Session["UserID"].ToString();
                UserData = autofacConfig.coreUserService.GetUserByID(UserID);
                Sex = Convert.ToInt32(UserData.USER_SEX);
                if (UserData.USER_SEX != null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        btnSex.DefaultValue = new string[] { "0" };
                    else
                        btnSex.DefaultValue = new string[] { "1" };
                }
                if (UserData.USER_IMAGEID == null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        userImg.ResourceID = userImg1.ResourceID = "male.png";
                    else
                        userImg.ResourceID = userImg1.ResourceID = "female.png";
                }
                else
                {
                    userImg.ResourceID = userImg1.ResourceID = UserData.USER_IMAGEID;
                }
                if (UserData.USER_ADDRESS != null) txtAddress.Text = UserData.USER_ADDRESS;
                //     lblID.Text = UserID;
                if (UserData.USER_NAME != null)
                {
                    btnName.Text = btnName1.Text = UserData.USER_NAME;
                }
                else
                {
                    btnName.Text = btnName1.Text = UserID;
                }
                if (UserData.USER_PHONE != null) labTel.Text = UserData.USER_PHONE;
                if (UserData.USER_EMAIL != null) btnEmail.Text = UserData.USER_EMAIL;
                if (UserData.USER_BIRTHDAY != null) dpkBirthday.Value = (DateTime)UserData.USER_BIRTHDAY;

                if (UserData.USER_ISDEMO != null)
                {
                    if (UserData.USER_ISDEMO == 1)
                        isDemo = true;
                    else
                        isDemo = false;
                }
                txtPhone.Text = UserData.USER_PHONE;
                btnEmail.Text = UserData.USER_EMAIL;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void btnSex_Press(object sender, TreeSelectPressEventArgs args)
        {
            Sex = Convert.ToInt32(args.TreeID);
        }
    }
}