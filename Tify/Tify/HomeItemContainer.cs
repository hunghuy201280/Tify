using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tify
{
    public partial class HomeItemContainer : UserControl
    {
        public HomeItemContainer()
        {
            InitializeComponent();
            hideScrollBar();
            clearItem();
        }
        public HomeItemContainer(string name)
        {
            InitializeComponent();
            containerTitle_label.Text = name;

            hideScrollBar();
        }

        #region get/set
        
        public void addItem(Control item)
        {
            recentlyPlayed_flowLayoutPanel.Controls.Add(item);
        }
        public void setContainerName(string name)
        {
            containerTitle_label.Text = name;
        }
        public void clearItem()
        {
            recentlyPlayed_flowLayoutPanel.Controls.Clear();
       }

        #endregion


        #region scroll Button
        private const int WM_SCROLL = 276; // Horizontal scroll
        private const int SB_LINELEFT = 0; // Scrolls one cell left
        private const int SB_LINERIGHT = 1; // Scrolls one line right

        private void hideScrollBar()
        {
            recentlyPlayed_flowLayoutPanel.AutoScroll = false;
            recentlyPlayed_flowLayoutPanel.HorizontalScroll.Maximum = 0;
            recentlyPlayed_flowLayoutPanel.AutoScrollPosition = new Point(0, 0);
            recentlyPlayed_flowLayoutPanel.AutoScroll = true;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
       

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                SendMessage(this.recentlyPlayed_flowLayoutPanel.Handle, WM_SCROLL, (IntPtr)(int)timer1.Tag, IntPtr.Zero);
            }
        }

        private void scroll_Button_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            if (sender == forward_Button)
            {
                timer1.Tag = 1;
            }
            else
            {
                timer1.Tag = 0;
            }
        }

        private void scroll_Button_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        #endregion


    }
}
