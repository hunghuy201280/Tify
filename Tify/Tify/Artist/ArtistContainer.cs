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
using System.Threading;

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

        public ArtistContainer(string coverLink,string name)
        {
            InitializeComponent();
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            PictureBox temp = new PictureBox();
            temp.Load(coverLink);
            artistCover_panel.BackgroundImage = temp.Image;
            artistName_Label.Text = name;
        }




        public string artistID;
        public Artist artistFm;
        public string spotifyID;
        public ArtistContainer(Artist artistFm, string artistID)
        {
            InitializeComponent();
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);

            this.artistFm = artistFm;
            this.artistID = artistID;


            info_worker.RunWorkerAsync();
            
            //load tracktable
            new Thread(() => {
                trackTable = Database.getTrack_Artist(artistID);
            }).Start();

            //load album table
            new Thread(() => {
                albumTalbe = Database.getAlbumOfArtist(artistID);
            }).Start();

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }


        #region load tracktable
        private DataTable trackTable = new DataTable();
     
        #endregion

        #region load cover,name
        private void info_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable infoTable = Database.getArtistInfo_Artist(artistID);
            e.Result = infoTable;
        }

        private void info_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error!=null)
            {
                return;
            }
            DataTable infoTable = e.Result as DataTable;
            if (infoTable.Rows.Count!=0)
            {
                artistName_Label.Text = infoTable.Rows[0]["artistName"].ToString();
                PictureBox pb = new PictureBox();
                pb.Load(GetSongData.getArtistCover(artistName_Label.Text));
                artistCover_panel.BackgroundImage = pb.Image;
            }
        }
        #endregion

        #region hover
        private void artistCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }
        #endregion


        #region load  track
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private void detail_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            #region load track detail
            foreach (DataRow track in trackTable.Rows)
            {
                //stop add at
                if (trackTable.Rows[10]==track)
                {
                    break;
                }

                TrackInfo tempTrack = new TrackInfo();
                tempTrack.Title = track["trackTitle"].ToString();
                tempTrack.Artist = track["artistName"].ToString();
                tempTrack.TrackLink = track["trackLink"].ToString();
                tempTrack.TrackID = track["trackID"].ToString();

                TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(tempTrack.TrackLink));


                string timeString = time.ToString(@"mm\:ss");
                tempTrack.Time = timeString;

               


                using (PictureBox pb = new PictureBox())
                {
                    pb.Load(GetSongData.GetSongCover(tempTrack.TrackLink));
                    tempTrack.Cover = pb.Image;
                }

                if (Database.checkIfTrackLoved(tempTrack.TrackID, artistFm.mainScr.CurrentUser.UserID))
                {
                    tempTrack.IsLoved = true;
                }
                else
                {
                    tempTrack.IsLoved = false;
                }

                trackInfos.Add(tempTrack);
                
            }
            #endregion
            isLoaded = true;
        }

        private void detail_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                return;
            }
            artistFm.artistDetail.setTrackDetailInfo(trackInfos, this);

        }
        #endregion

        //open artist detail on click

        private bool isLoaded = false;
        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (isLoaded)
            {
                artistFm.artistDetail.setTrackDetailInfo(trackInfos, this);
                return;
            }

            if (detail_worker.IsBusy)
            {
                return;
            }
            
            detail_worker.RunWorkerAsync();
            album_worker.RunWorkerAsync();
        }


        #region load artist's albums

        private DataTable albumTalbe;
        List<AlbumContainer> albumContainers = new List<AlbumContainer>();
        private void album_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < albumTalbe.Rows.Count; i++)
            {
                albumContainers.Add(new AlbumContainer(albumTalbe.Rows[0]["albumID"].ToString(), artistFm.mainScr.albumsScr));
            }
        }

        private void album_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                return;
            }
            artistFm.artistDetail.setAlbumInfo(albumContainers, this);
        }

        #endregion
    }
}
