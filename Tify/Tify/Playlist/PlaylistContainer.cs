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
        public Playlist playlistFm;
        private string playlistID;
        public string description;
        public string owner;
        public PlaylistContainer(Playlist callform,string PLAYLIST_ID)
        {
            InitializeComponent();
            playlistID = PLAYLIST_ID;
            playlistFm = callform;
            opacity_panel.Click += callform.opacity_panel_Click;



            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private void opacity_panel_Paint(object sender, PaintEventArgs e)
        {
            loadInfo(playlistID);
        }
        public void loadInfo(string playlistid)
        {
            load_worker.RunWorkerAsync();
        }
        private DataTable trackTable = new DataTable();
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            trackTable = Database.getTrackInPlaylist(playlistID);
            if (trackTable.Rows.Count != 0)
                owner = trackTable.Rows[0]["name"].ToString();
            foreach (DataRow track in trackTable.Rows)
            {

                string lastTrackID = "";
                if (track["trackID"].ToString() == lastTrackID && lastTrackID != "")
                {
                    trackInfos[trackInfos.Count - 1].Artist += ";" + track["artistName"].ToString();
                }
                else
                {
                    TrackInfo temp = new TrackInfo();
                    temp.TrackID = track["trackID"].ToString();
                    temp.Artist = track["artistName"].ToString();
                    temp.Title = track["trackTitle"].ToString();
                    temp.TrackLink = track["trackLink"].ToString();
                    DateTime dateAdded = DateTime.Parse(track["dateAdded"].ToString());
                    temp.DateAdded = dateAdded.ToShortDateString();
                    if (Database.checkIfTrackLoved(temp.TrackID, playlistFm.mainScr.CurrentUser.UserID))
                    {
                        temp.IsLoved = true;
                    }
                    else
                    {
                        temp.IsLoved = false;
                    }

                    int[] duration = GetSongData.GetSongDuration(track["trackLink"].ToString());

                    //neu giay >=10
                    if (duration[1] >= 10)
                        temp.Time = duration[0] + ":" + duration[1];
                    else
                        temp.Time = duration[0] + ":0" + duration[1];
                    if (temp.Time == "0:00")
                    {
                        continue;
                    }

                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
        }

        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
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
