using Swebui.Controls;
using SwebWMS.UI.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.Menu
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmMenu : Swebui.Controls.SwebUserControl
    {
        public FrmMenu() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            labWeek.Text = DateTime.Now.DayOfWeek.ToString();

            string [] assetsName= new string[]{ "资产管理", "资产模板", "入库", "出库", "调拨","盘点" };
            string[] assetsImg = new string[] { "zichan.png", "muban.png", "ruku.png", "chuku.png", "diaobo.png", "pandian.png" };
            for(int i = 0; i < assetsName.Length; i++)
            {
                ImageButton imageButton= new ImageButton();
                imageButton.ResourceID = assetsImg[i];
                imageButton.Text = assetsName[i];
                imageButton.Press += ImageButtonPress;
                imageButton.Margin = new Margin(10);
                assPanel.Controls.Add(imageButton);
            }
            string[] conName = new string[] { "耗材管理", "入库", "出库", "调拨", "盘点" };
            string[] conImg = new string[] { "haocai.png", "ruku.png", "chuku.png", "diaobo.png", "pandian.png" };
            for (int i = 0; i < conName.Length; i++)
            {
                ImageButton imageButton = new ImageButton();
                imageButton.ResourceID = conImg[i];
                imageButton.Text = conName[i];
                imageButton.Press += ImageButtonPress1;
                imageButton.Margin = new Margin(10);
                conPanel.Controls.Add(imageButton);
            }
        }
        private void ImageButtonPress(object sender, EventArgs e)
        {

        }
        private void ImageButtonPress1(object sender, EventArgs e)
        {

        }
    }
}