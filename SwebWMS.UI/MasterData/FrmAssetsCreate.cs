using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebWMS.UI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAssetsCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAssetsCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
    }
}