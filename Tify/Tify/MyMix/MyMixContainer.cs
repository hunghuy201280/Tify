using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class MyMixContainer : UserControl
    {
        public MyMixContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }



        private void myMixCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        private void MyMixContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }
    }
}
