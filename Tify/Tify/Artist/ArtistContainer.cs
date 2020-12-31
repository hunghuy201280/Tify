using GetData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Tify
{
    public partial class ArtistContainer : UserControl
    {
        public ArtistContainer()
        {
            InitializeComponent();
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
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
            ThreadPool.QueueUserWorkItem(delegate {
                trackTable = Database.getTrack_Artist(artistID);
            });
        

            ThreadPool.QueueUserWorkItem(delegate {
                albumTalbe = Database.getAlbumOfArtist(artistID);
            });
       

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        #region reload status

        public void reloadStatus()
        {
            //reload in track

        
            new Thread(() =>
            {
                foreach (var track in trackInfos)
                {
                    if (Database.checkIfTrackLoved(track.TrackID, artistFm.mainScr.CurrentUser.UserID))
                    {
                        track.IsLoved = true;
                    }
                    else if (!Database.checkIfTrackLoved(track.TrackID, artistFm.mainScr.CurrentUser.UserID))
                    {
                        track.IsLoved = false;
                    }
                }
            }).Start();
            //reload album
            foreach (var item in albumContainers)
            {
                item.reloadStatus();
            }
        }

        #endregion reload status

        #region load tracktable

        private DataTable trackTable = new DataTable();

        #endregion load tracktable

        #region load cover,name

        private void info_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable infoTable = Database.getArtistInfo_Artist(artistID);
            e.Result = infoTable;
        }

        private void info_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                return;
            }
            DataTable infoTable = e.Result as DataTable;
            if (infoTable.Rows.Count != 0)
            {
                artistName_Label.Text = infoTable.Rows[0]["artistName"].ToString();

                ThreadPool.QueueUserWorkItem(delegate {
                    PictureBox pb = new PictureBox();
                    pb.Load(GetSongData.getArtistCover(artistName_Label.Text));
                    this.BeginInvoke((Action)delegate {
                    artistCover_panel.BackgroundImage = pb.Image;
                    });
                });
               
            }
        }

        #endregion load cover,name

        #region hover

        private void artistCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        #endregion hover

        #region load  track

        private List<TrackInfo> trackInfos = new List<TrackInfo>();

        private void detail_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            #region load track detail

            foreach (DataRow track in trackTable.Rows)
            {
                //stop add at
                if (trackTable.Rows.Count>15 &&trackTable.Rows[15] == track)
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

            #endregion load track detail

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

        #endregion load  track

        //open artist detail on click

        private bool isLoaded = false;

        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            artistFm.openChildForm(artistFm.artistDetail);
            if (isLoaded)
            {
                artistFm.artistDetail.setTrackDetailInfo(trackInfos, this);
                artistFm.artistDetail.setAlbumInfo(albumContainers, this);
                return;
            }

            if (detail_worker.IsBusy)
            {
                return;
            }
            artistFm.artistDetail.showLoading();
            detail_worker.RunWorkerAsync();
            loadAlbum();
        }

        #region load artist's albums

        private void loadAlbum()
        {
            for (int i = 0; i < albumTalbe.Rows.Count; i++)
            {
                if (i == 7)
                {
                    break;
                }
                albumContainers.Add(new AlbumContainer(albumTalbe.Rows[i]["albumID"].ToString(), artistFm.mainScr.albumsScr));
            }
            artistFm.artistDetail.setAlbumInfo(albumContainers, this);
        }

        private DataTable albumTalbe;
        
        private List<AlbumContainer> albumContainers = new List<AlbumContainer>();

        #endregion load artist's albums
    }
}