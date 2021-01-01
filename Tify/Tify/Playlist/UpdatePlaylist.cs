using System;
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
    public partial class UpdatePlaylist : Form
    {
        public UpdatePlaylist()
        {
            InitializeComponent();
        }

        public UpdatePlaylist(PlaylistContainer playlistContainer)
        {
            InitializeComponent();
            this.playlistContainer = playlistContainer;

            Title_TextBox.Text = playlistContainer.playlistName;
            Description_TextBox.Text = playlistContainer.description;
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        PlaylistContainer playlistContainer;
        private void save_button_Click(object sender, EventArgs e)
        {
            Database.EditPlaylist(playlistContainer.playlistID, Title_TextBox.Text, Description_TextBox.Text);
            playlistContainer.playlistName = Title_TextBox.Text;
            playlistContainer.description = Description_TextBox.Text;
            playlistContainer.opacity_panel_MouseClick(new object(), new MouseEventArgs(MouseButtons.Left,1,1,1,1));
            playlistContainer.playlistName_label.Text = Title_TextBox.Text;
            playlistContainer.playlistFm.mainScr.CreatePL.AddPlaylistButtonToMenuPanel(playlistContainer.playlistFm.mainScr.PlayList_FlowPanel);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
