﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
        private MainScreen callForm = null;
        public Home(MainScreen parentForm)
        {
            callForm= parentForm;
            InitializeComponent();
            /*  flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
              flowLayoutPanel1.HorizontalScroll.Maximum = 195 * flowLayoutPanel1.Controls.Count + 195 - flowLayoutPanel1.Size.Width;*/
            foreach (var item in home_flowLayoutPanel.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)item;
                    foreach (var flow in groupBox.Controls)
                    {
                        if (flow is FlowLayoutPanel)
                        {
                            FlowLayoutPanel flowLayoutPanel = flow as FlowLayoutPanel;
                            flowLayoutPanel.AutoScrollPosition = new Point(0, 0);
                            flowLayoutPanel.HorizontalScroll.Maximum = 195 * flowLayoutPanel.Controls.Count +
                                195 - flowLayoutPanel.Size.Width;
                        }

                    }

                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Size=new Size(callForm.childForm_panel.Size.Width - 16, callForm.childForm_panel.Height - 39);
            //MainScreen.hideScrollBar(flowLayoutPanel1, "flow");
            
        }

        //test



      

        #region đổi kích thước của group box khi form resize vì không dùng dock được
        private void home_flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            foreach (var item in panel.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox temp = item as GroupBox;
                    temp.Size = new Size(panel.Size.Width, temp.Size.Height);
                }
            }
        }
        #endregion
    }
}
