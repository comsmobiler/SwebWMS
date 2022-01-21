using SMOWMS.CommLib;
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
    partial class EditPsdDialog : Swebui.Controls.SwebUserControl
    {
        public EditPsdDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String newPwd1 = txtPassWord1.Text.Trim();
                String newPwd2 = txtPassWord2.Text.Trim();
                if (newPwd1.Length < 0) throw new Exception("请输入新密码!");
                if (newPwd1.Length < 6 || newPwd1.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (newPwd2.Length < 0) throw new Exception("请输入确认密码!");
                if (newPwd2.Length < 6 || newPwd2.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (newPwd1.Equals(newPwd2) == false) throw new Exception("两次密码输入不一致，请检查!");
                if (txtPwd.Text.Equals(newPwd1)) throw new Exception("新密码不能与原密码相同，请重新输入!");
                ReturnInfo RInfo = autofacConfig.coreUserService.ChangePwd(Client.Session["UserId"].ToString(), txtPwd.Text, newPwd1);
                if (RInfo.IsSuccess == true)
                {
                    Toast("密码修改成功");
                    this.Close();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                coreUser user = autofacConfig.coreUserService.GetUserByID(Client.Session["UserID"].ToString());
                if (user.USER_PASSWORD == txtPwd.Text)
                {
                    panel3.Visible = false;
                    panel4.Visible = panel5.Visible = true;
                }
                else
                {
                    txtPwd.Text = "";
                    throw new Exception("输入的原密码不正确，请重新输入!");
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }

        }
    }
}