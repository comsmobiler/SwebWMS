using SMOWMS.CommLib;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI
{
    partial class FrmLogon : Swebui.Controls.SwebForm
    {
        public FrmLogon() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        private DateTime toasttime;
        #endregion
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String userID = txtUserName.Text.Trim();
                String PassWord = txtPassWord.Text.Trim();
                if (userID.Length <= 0)
                    throw new Exception("请输入手机号码");
                if (PassWord.Length < 0)
                    throw new Exception("请输入密码");
                ReturnInfo result = autofacConfig.coreUserService.Login(userID, PassWord);
                if (result.IsSuccess)
                {
                    String Role = autofacConfig.coreUserService.GetUserByID(userID).USER_ROLE;
                    Client.Session["UserID"] = userID;
                    Client.Session["Role"] = Role;
                    this.Show(new MainForm());
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 跳转注册页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Form.Show(new FrmRegister());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void verfiyLogin_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}