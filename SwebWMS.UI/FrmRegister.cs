using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmRegister : Swebui.Controls.SwebForm
    {
        public FrmRegister() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        string VCode = "";
        private string role;
        #endregion
        /// <summary>
        /// 获取验证码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTel.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入电话号码！");

                }
                else
                {
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                    if (regex.IsMatch(txtTel.Text.Trim()) == false)
                    {
                        throw new Exception("手机号码格式不正确！");
                    }
                }
                //验证电话号码是否已经注册，当返回值为true时，表示已注册
                bool isRegister = AutofacConfig.coreUserService.PhoneIsExit(txtTel.Text.Trim());
                if (isRegister == true)
                {
                    throw new Exception("电话号码" + txtTel.Text.Trim() + "已注册！");
                }
                label3.Visible = true;
                //模拟发送短信验证码
                int result = AutofacConfig.ValidateCodeService.SendVCode(txtTel.Text.Trim());
                if (result != 0)
                {
                    VCode = result.ToString();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }
        /// <summary>
        /// 注册按钮，验证验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTel.Text != null)
                {
                    String vcode = txtVcode1.Text.Trim();
                    if (vcode.Length > 0)
                    {
                        if (vcode != VCode) throw new Exception("您输入的验证码错误!");
                        panel5.Visible = false;
                        panel6.Visible = true;
                    }
                    else
                    {
                        throw new Exception("请输入手机验证码!");
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void comboBox1_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 开始使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim().Length < 0) throw new Exception("请输入昵称");
                String pwd1 = txtPwd1.Text.Trim();
                String pwd2 = txtPwd2.Text.Trim();
                if (pwd1.Length <= 0) throw new Exception("请输入新密码!");
                if (pwd1.Length < 6 || pwd1.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (pwd2.Length <= 0) throw new Exception("请输入确认密码!");
                if (pwd2.Length < 6 || pwd2.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (pwd1.Equals(pwd2) == false) throw new Exception("两次密码输入不一致，请检查!");
                if (String.IsNullOrEmpty(role)) throw new Exception("请选择角色!");
                if (role != "ADMIN")     //用户必须选择区域，管路员可以不选
                {
                    if (btnLocation.Tag == null) throw new Exception("请选择所属区域");
                }


                coreUser UserData = new coreUser();
                UserData.USER_ID = txtTel.Text.Trim();
                //if (btnLocation.Tag != null)
                //    UserData.USER_LOCATIONID = btnLocation.Tag.ToString();
                UserData.USER_NAME = txtName.Text;
                UserData.USER_PASSWORD = pwd1;
                UserData.USER_PHONE = txtTel.Text.Trim();
                UserData.USER_LANGUAGE = 0;
                UserData.USER_ROLE = role;

                ReturnInfo RInfo = AutofacConfig.coreUserService.AddUser(UserData);
                if (RInfo.IsSuccess)
                {
                    Client.Session["UserID"] = txtTel.Text.Trim();
                    Client.Session["Role"] = role;
                    //关闭当前界面
                    this.Close();
                    //frmAssets frm = new frmAssets();
                    ////跳转到资产主界面
                    //Show(frm);
                }
                else
                {
                    throw new Exception(RInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void comboBox1_Press(object sender, TreeSelectPressEventArgs args)
        {
            role = args.TreeID;
        }
    }
}