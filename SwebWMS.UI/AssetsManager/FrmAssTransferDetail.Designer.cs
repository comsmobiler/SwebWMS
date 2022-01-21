using Swebui.Controls;
using System;

namespace SwebWMS.UI.AssetsManager
{
    partial class FrmAssTransferDetail : Swebui.Controls.SwebUserControl
    {
        #region "SwebUserControl generated code "

        //SwebUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SwebUserControl
        //It can be modified using the SwebUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.lblTID = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.INBtn = new Swebui.Controls.Button();
            this.OutBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.lblTDInMan = new Swebui.Controls.Label();
            this.lblDatePicker = new Swebui.Controls.Label();
            this.lblLocation = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.lblDealMan = new Swebui.Controls.Label();
            this.lblNote = new Swebui.Controls.Label();
            this.textBox3 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.snPanel = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblTID});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.FontSize = 24F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.Text = "资产调拨";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // lblTID
            // 
            this.lblTID.FontSize = 20F;
            this.lblTID.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(0, 26);
            this.lblTID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.INBtn,
            this.OutBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(0, 26);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // INBtn
            // 
            this.INBtn.BackColor = System.Drawing.Color.White;
            this.INBtn.Border = new Swebui.Controls.Border(1F);
            this.INBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.INBtn.ForeColor = System.Drawing.Color.DimGray;
            this.INBtn.IconName = "fa fa-pencil-square-o";
            this.INBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.INBtn.Name = "INBtn";
            this.INBtn.NumberOfLines = 0;
            this.INBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.INBtn.Size = new System.Drawing.Size(0, 26);
            this.INBtn.Text = "调拨入库";
            this.INBtn.Click += new System.EventHandler(this.INBtn_Click);
            // 
            // OutBtn
            // 
            this.OutBtn.BackColor = System.Drawing.Color.White;
            this.OutBtn.Border = new Swebui.Controls.Border(1F);
            this.OutBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.OutBtn.ForeColor = System.Drawing.Color.DimGray;
            this.OutBtn.IconName = "fa fa-pencil-square-o";
            this.OutBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.NumberOfLines = 0;
            this.OutBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.OutBtn.Size = new System.Drawing.Size(0, 26);
            this.OutBtn.Text = "调拨取消";
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "调入管理员";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "业务日期";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "调入库位";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblTDInMan,
            this.lblDatePicker,
            this.lblLocation});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // lblTDInMan
            // 
            this.lblTDInMan.Flex = 1;
            this.lblTDInMan.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.lblTDInMan.Name = "lblTDInMan";
            this.lblTDInMan.Size = new System.Drawing.Size(100, 35);
            this.lblTDInMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.Flex = 1;
            this.lblDatePicker.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(100, 35);
            this.lblDatePicker.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblLocation
            // 
            this.lblLocation.Flex = 1;
            this.lblLocation.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 35);
            this.lblLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label6,
            this.label7});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "处理人";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "备注";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblDealMan,
            this.lblNote,
            this.textBox3});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // lblDealMan
            // 
            this.lblDealMan.Flex = 1;
            this.lblDealMan.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.lblDealMan.Name = "lblDealMan";
            this.lblDealMan.Size = new System.Drawing.Size(100, 35);
            this.lblDealMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblNote
            // 
            this.lblNote.Flex = 1;
            this.lblNote.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(100, 35);
            this.lblNote.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Flex = 1;
            this.textBox3.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            // 
            // panel7
            // 
            this.panel7.Border = new Swebui.Controls.Border(1F);
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label10,
            this.label11,
            this.label9,
            this.label12});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 33);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 30);
            this.label10.Text = "图片";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.Text = "SN";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 30);
            this.label9.Text = "资产名称";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 30);
            this.label12.Text = "状态";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // snPanel
            // 
            this.snPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.snPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.snPanel.Flex = 1;
            this.snPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.snPanel.Name = "snPanel";
            this.snPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // FrmAssTransferDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.snPanel});
            this.Load += new System.EventHandler(this.FrmAssTransferDetail_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblTID;
        private Panel panel2;
        private Button BackBtn;
        private Button INBtn;
        private Button OutBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label lblTDInMan;
        private Label lblDatePicker;
        private Label lblLocation;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Label lblDealMan;
        private Label lblNote;
        private Label textBox3;
        private Panel panel7;
        private Label label10;
        private Label label11;
        private Label label9;
        private Panel snPanel;
        private Label label12;
    }
}