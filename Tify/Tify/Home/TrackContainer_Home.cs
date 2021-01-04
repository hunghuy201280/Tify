using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetData;

namespace Tify
{
    public partial class TrackContainer_Home : UserControl
    {
        public TrackContainer_Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        public TrackContainer_Home(string trackID,MainScreen mainScreen)
        {
            InitializeComponent();
            track.TrackID = trackID;
            mainScr = mainScreen;
            load_worker.RunWorkerAsync();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }


        public TrackInfo track=new TrackInfo();
        private MainScreen mainScr;
        private DataTable infoTable;

        #region design
        private void TrackCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        private void TrackContainer_Home_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);

        }
        #endregion

        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            mainScr.nextTrack.Clear();
            mainScr.setplayfrom("Home");
            mainScr.changeSong(track);
        }

        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            infoTable = Database.getTrackBaseOnID(track.TrackID);
            string lastTrackID = "";
            foreach (DataRow Track in infoTable.Rows)
            {
                if (Track["trackID"].ToString() == lastTrackID && lastTrackID != "")
                {
                    track.Artist += ";" + Track["artistName"].ToString();
                }
                else
                {
                 

                    track.Artist = Track["artistName"].ToString();
                    track.Title = Track["trackTitle"].ToString();
                    track.TrackLink = Track["trackLink"].ToString();
                    if (track.Artist == "")
                    {
                        track.Artist = GetSongData.loadArtist(track.TrackLink);
                    }
                    using (PictureBox pb=new PictureBox())
                    {
                        pb.Load(GetSongData.GetSongCover(track.TrackLink));
                        track.Cover = pb.Image;
                    }
                    
                    if (Database.checkIfTrackLoved(track.TrackID, mainScr.CurrentUser.UserID))
                    {
                        track.IsLoved = true;
                    }
                    else
                    {
                        track.IsLoved = false;
                    }

                    TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(track.TrackLink));

                    string timeString = time.ToString(@"mm\:ss");
                    track.Time = timeString;


                    lastTrackID = track.TrackID;
                }
            }
           
           
        }

        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            trackCover_panel.BackgroundImage = track.Cover;
            trackArtist_label.Text = track.Artist;
            trackDuration_label.Text = track.Time;
            trackName_label.Text = track.Title;
        }
    }
}
