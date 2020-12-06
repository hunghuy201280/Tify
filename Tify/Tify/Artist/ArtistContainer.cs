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
    public partial class ArtistContainer : UserControl
    {
        public ArtistContainer()
        {
            InitializeComponent();
            opacity_panel.BackColor = Color.FromArgb(125,Color.Black);
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }

        public ArtistContainer(Image cover,string name)
        {
            InitializeComponent();
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            artistCover_panel.BackgroundImage = cover;
            artistName_Label.Text = name;
        }



        //hover
        private void artistCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }
    }
}
