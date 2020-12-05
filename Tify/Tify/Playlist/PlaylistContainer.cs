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
    public partial class PlaylistContainer : UserControl
    {
        public PlaylistContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        Playlist playlist;
        public PlaylistContainer(Playlist callform)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            playlist = callform;
            opacity_panel.Click += callform.opacity_panel_Click;
        }

        private void PlaylistContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void playlistCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }
    }
}
