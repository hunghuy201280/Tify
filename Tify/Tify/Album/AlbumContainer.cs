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
    public partial class AlbumContainer : UserControl
    {
        public AlbumContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        public AlbumContainer(string imgUrl,string title,string artist,string year)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            PictureBox temp = new PictureBox();
            temp.Load(imgUrl);
            albumCover_panel.BackgroundImage = temp.Image;
            albumName_label.Text = title;
            albumArtist_label.Text = artist;
            if (year!="0")
            {
                albumYear_label.Text = year;
            }
            else
            {
                albumYear_label.Text = "Unknown";
            }
        }
        private void AlbumContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void albumCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }
    }
}
