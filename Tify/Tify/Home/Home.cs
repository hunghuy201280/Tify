using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    //Recently,chart,mix for you,
    //2 cai because you listened to
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
        private MainScreen callForm = null;
        public Home(MainScreen parentForm)
        {
            
            InitializeComponent();
            callForm = parentForm;
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Size=new Size(callForm.childForm_panel.Size.Width - 16, callForm.childForm_panel.Height - 39);
            //MainScreen.hideScrollBar(flowLayoutPanel1, "flow");
            DoubleBuffered = true;

            mixesForYou.setContainerName("Mixes For You");
            theCharts.setContainerName("The Charts");

            hideScrollBar();
        }

        //test

        

      

        #region đổi kích thước của group box khi form resize vì không dùng dock được
        private void home_flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            foreach (var item in panel.Controls)
            {
                if (item is HomeItemContainer)
                {
                    HomeItemContainer temp = item as HomeItemContainer;
                    temp.Size = new Size(panel.Size.Width-15, temp.Size.Height);
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            recentlyPlayed.addItem(new PlaylistContainer());
            HomeItemContainer a = new HomeItemContainer();
         }

        #region hideScrollBar

        private void hideScrollBar()
        {
            home_flowLayoutPanel.AutoScroll = false;
            home_flowLayoutPanel.HorizontalScroll.Maximum = 0;
            home_flowLayoutPanel.AutoScrollPosition = new Point(0, 0);
            home_flowLayoutPanel.AutoScroll = true;
        }
        #endregion
    }
}
