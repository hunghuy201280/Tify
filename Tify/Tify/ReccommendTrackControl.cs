using GetData;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Tify;

namespace ReccomendTrackContainer
{
    public partial class ReccommendTrackControl : UserControl
    {
        public string Url = string.Empty;

        public ReccommendTrackControl()
        {
            InitializeComponent();
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            opacity_panel.Visible = false;
        }
        MainScreen mainscr;
        public ReccommendTrackControl(MainScreen param)
        {
            InitializeComponent();
            mainscr = param;
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            opacity_panel.Visible = false;
        }

        private void songCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        #region get/set

        public void setSongName(string name)
        {
            title_label.Text = name;
        }

        public void setSongArtist(string name)
        {
            artist_label.Text = "Track by " + name;
        }

        public void setSongCover(Image img)
        {
            songCover_panel.BackgroundImage = img;
        }

        #endregion get/set

        //change song
        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            new Thread(() => {
                mainscr.BeginInvoke((Action)delegate ()
                {

                    mainscr.loadNewSong(Url);
                });
                }).Start();
            
        }
    }
}