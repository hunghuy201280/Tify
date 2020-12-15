using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GetData;

namespace Tify
{
    public partial class AlbumContainer : UserControl
    {
        
        DataTable temp1 = new DataTable();
       
        public AlbumContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
           
        }

        public AlbumContainer(string imgUrl, string title, string artist, string year)
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
            if (year != "0")
            {
                albumYear_label.Text = year;
            }
            else
            {
                albumYear_label.Text = "Unknown";
            }

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }
        string albumid1;
       public  Albums album;
        public AlbumContainer(string inputid,Albums input)
        {
            InitializeComponent();

            albumid1 = inputid;
            album = input;

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_worker.RunWorkerAsync();
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

        private void track_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            temp1 = Database.getTrack_Album(albumid1); 
            
        }
        
        PictureBox PB=new PictureBox();
        private void track_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            
                albumName_label.Text = temp1.Rows[0]["albumTitle"].ToString();
                albumYear_label.Text = temp1.Rows[0]["albumYear"].ToString();
                PB.Load(GetData.GetSongData.GetSongCover(temp1.Rows[0]["albumLink"].ToString()));
                albumCover_panel.BackgroundImage = PB.Image;
                if (temp1.Rows[0]["albumTitle"].ToString() == null)
                {
                    albumArtist_label.Text = "unknown";
                }
                else
                    albumArtist_label.Text = temp1.Rows[0]["artistname"].ToString();



            
        }
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private List<Image> cover = new List<Image>();
        public void loadInfo()
        {
            load_worker.RunWorkerAsync();
        }
        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string lastTrackID = "";

            foreach (DataRow track in temp1.Rows)
            {

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
                    PictureBox pb = new PictureBox();
                    pb.Load(GetSongData.GetSongCover(track["trackLink"].ToString()));
                    cover.Add(pb.Image);
                    if (Database.checkIfTrackLoved(temp.TrackID, album.mainScr.CurrentUser.UserID))
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
            if (e.Error != null)
            {
                return;
            }
            album.albumDetail.setDetailInfo(trackInfos,PB, this);

        }
      
        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            
            loadInfo();
        }
    }
}
