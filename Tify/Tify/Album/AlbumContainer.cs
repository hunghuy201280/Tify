﻿using GetData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
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

        public string albumID;
        public Albums AlbumForm;
        public int timeInSec = 0;
        public AlbumContainer(string albumID, Albums AlbumForm)
        {
            InitializeComponent();

            this.albumID = albumID;
            this.AlbumForm = AlbumForm;

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            //load track in album
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

        private DataTable trackTable = new DataTable();

        private void track_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            trackTable = Database.getTrack_Album(albumID);
            
        }
        private PictureBox PB = new PictureBox();

        private void setContainerUI()
        {
            //load cover,name,... cho album container
           
            albumName_label.Text = trackTable.Rows[0]["albumTitle"].ToString();
            albumYear_label.Text = trackTable.Rows[0]["albumYear"].ToString();
            if (albumYear_label.Text=="0")
            {
                albumYear_label.Text = "";
            }
            ThreadPool.QueueUserWorkItem(delegate {

                PB.Load(GetData.GetSongData.GetSongCover(trackTable.Rows[0]["albumLink"].ToString()));
                string artistText="";
                DataTable albumArtistTable;
                if (trackTable.Rows[0]["artistID"].ToString() == "")
                {
                    string[] artistArr = GetSongData.GetSongArtist(trackTable.Rows[0]["albumLink"].ToString());
                    foreach (string art in artistArr)
                    {
                        if (art!=artistArr[artistArr.Length-1])
                        {
                            artistText += art + ";";
                        }
                        else
                        {
                            artistText += art;
                        }
                    }
                   
                }
                else
                {
                    albumArtistTable = Database.getArtistBaseOnID(trackTable.Rows[0]["artistID"].ToString());
                    artistText = trackTable.Rows[0]["artistname"].ToString();
                }
                this.BeginInvoke((Action)delegate {
                    albumCover_panel.BackgroundImage = PB.Image;
                    albumArtist_label.Text = artistText;
                });
            });
           
        }
        private void track_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error!=null)
            {
                return;
            }

            setContainerUI();

        }

        private List<TrackInfo> trackInfos = new List<TrackInfo>();

        public void loadInfo()
        {
            AlbumForm.albumDetail.showLoading();
            //load cac track trong album khi click vao
            load_worker.RunWorkerAsync();
           
        }

        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string lastTrackID = "";

            foreach (DataRow track in trackTable.Rows)
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

                    if (temp.Artist == "")
                    {
                        string[] artists = GetSongData.GetSongArtist(temp.TrackLink);
                        for (int i = 0; i < artists.Length; i++)
                        {
                            if (i!=artists.Length-1)
                            {
                                temp.Artist += artists[i] + "; ";
                            }
                            else
                            {
                                temp.Artist += artists[i];
                            }
                        }
                    }
                    if (Database.checkIfTrackLoved(temp.TrackID, AlbumForm.mainScr.CurrentUser.UserID))
                    {
                        temp.IsLoved = true;
                    }
                    else
                    {
                        temp.IsLoved = false;
                    }

                    TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(temp.TrackLink));


                    string timeString = time.ToString(@"mm\:ss");
                    temp.Time = timeString;

                    timeInSec += (int)time.TotalSeconds;
                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
            isLoaded = true;
            
        }

        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                return;
            }
            AlbumForm.albumDetail.setDetailInfo(trackInfos, PB, this);
            AlbumForm.albumDetail.hideLoading();

        }

        private bool isLoaded = false;
        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            //load cac track trong album khi click vao
            AlbumForm.openChildForm(AlbumForm.albumDetail);
            if (isLoaded)
            {
                AlbumForm.albumDetail.setDetailInfo(trackInfos,PB, this);
                return;
            }

            if (load_worker.IsBusy)
            {
                return;
            }
            loadInfo();
        }



        #region reload when delete or add track to loved track

        public void reloadStatus()
        {
            //reload_worker.RunWorkerAsync();
            new Thread(() => {
                reload();
            }).Start();
        }

        private void reload()
        {
            foreach (var track in trackInfos)
            {
                if (Database.checkIfTrackLoved(track.TrackID, AlbumForm.mainScr.CurrentUser.UserID))
                {
                    track.IsLoved = true;
                }
                else if (!Database.checkIfTrackLoved(track.TrackID, AlbumForm.mainScr.CurrentUser.UserID))
                {
                    track.IsLoved = false;
                }
            }
        }
        #endregion
    }
}