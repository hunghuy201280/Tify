using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist
{
    public partial class PlaylistContainer: UserControl
    {
        public PlaylistContainer()
        {
            InitializeComponent();
        }
        public string getPlaylistName()
        {
            return playlistName_label.Text;
        }
        public void setPlaylistName(string name)
        {
            playlistName_label.Text = name;
        }
        public int getNumberOfTracks()
        {
            string res = numberOfTracks_label.Text.Replace(" Tracks", "");
            return int.Parse(res);
        }
        public void setNumberOfTracks(int num)
        {

            numberOfTracks_label.Text = num.ToString() + " Tracks";
        }
        public void setPlaylistCover(Image image)
        {
            playListCover_pictureBox.BackgroundImage = image;
        }
        public Image getPlaylistCover()
        {
            return playListCover_pictureBox.BackgroundImage;
        }
    }
}
