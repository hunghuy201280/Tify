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
    public partial class MyMixContainer : UserControl
    {
        public MyMixContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }


        public string mixID;

        private DataTable mixTable = new DataTable();
        private MyMix mixForm;
        public int index = 1;//row index
        private MixDetail mixDetail;

      
        public MyMixContainer(MyMix callform, string id, MixDetail detail)
        {
            InitializeComponent();

            //mixForm to get userID from mainscreen
            mixForm = callform;
            mixID = id;
            //load mixdetail on clicking opacity panel
            mixDetail = detail;

            cover_worker.RunWorkerAsync();
            artist_worker.RunWorkerAsync();
            

            artist_label.Text = "";

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private void myMixCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        private void MyMixContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private DataTable artistTable = new DataTable();

        private void artist_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            artistTable = Database.getArtistInMyMixContainer(mixID);
        }

        private void artist_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + "My mix container, artist");
                return;
            }
            //max char in artist label
            foreach (DataRow row in artistTable.Rows)
            {
                if ((artist_label.Text + row["artistName"].ToString()).Length > 30)
                {
                    artist_label.Text += " and more...";
                    break;
                }
                else
                {
                    if (row==artistTable.Rows[artistTable.Rows.Count-1])
                    {
                        artist_label.Text += row["artistName"].ToString() ;
                    }
                    else
                        artist_label.Text += row["artistName"].ToString() + ", ";
                }
            }
        }

        private void cover_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            index = Database.getMyMixOrder(mixForm.mainScr.CurrentUser.UserID, mixID);
            //index in mixcontainers
            opacity_panel.Tag = index - 1;
        }

        private void cover_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + "My mix container, cover");
                return;
            }
            myMixCover_panel.BackgroundImage = MixCover_ImageList.Images[index - 1];
            playlistName_label.Text = "My Mix " + index;
        }

        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            mixForm.openChildForm(mixForm.mixDetail);
            loadMixDetailContent(mixID);
            

        }

        private bool isLoaded = false;

      

        public void loadMixDetailContent(string id)
        {
            if (isLoaded)
            {
                mixDetail.SetDetailInfo(trackInfos, myMixCover_panel.BackgroundImage,true,this);
                return;
            }
            mixID = id;
            if (load_worker.IsBusy)
            {
                return;
            }
            load_worker.RunWorkerAsync();
            mixDetail.showLoading();




        }

        private DataTable trackTable = new DataTable();
        private List<TrackInfo> trackInfos = new List<TrackInfo>();

        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            trackTable.Clear();
            //load trackTable
            trackTable = Database.getTrackInMyMix(mixID);

            //duyet tung track trong trackTable
            string lastTrackID = "";
            foreach (DataRow track in trackTable.Rows)
            {
                //neu trung trackID thi add them artist
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
                    if (Database.checkIfTrackLoved(temp.TrackID,mixForm.mainScr.CurrentUser.UserID))
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


                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
            isLoaded = true;
           
        }

        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mixDetail.SetDetailInfo(trackInfos, myMixCover_panel.BackgroundImage,true,this);
           
            mixDetail.hideLoading();
        }


        #region reload when unlike track
        public void reloadStatus()
        {
            //reload_worker.RunWorkerAsync();
            new Thread(() =>
            {
                reload();
            }).Start();
        }

        private void reload()
        {
            foreach (var track in trackInfos)
            {
                if (Database.checkIfTrackLoved(track.TrackID, mixForm.mainScr.CurrentUser.UserID))
                {
                    track.IsLoved = true;
                }
                else if (!Database.checkIfTrackLoved(track.TrackID, mixForm.mainScr.CurrentUser.UserID))
                {
                    track.IsLoved = false;
                }
            }

        }
        private void reload_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var track in trackInfos)
            {
                if (Database.checkIfTrackLoved(track.TrackID, mixForm.mainScr.CurrentUser.UserID) )
                {
                    track.IsLoved = true;
                }
                else if (!Database.checkIfTrackLoved(track.TrackID, mixForm.mainScr.CurrentUser.UserID))
                {
                    track.IsLoved = false;
                }
            }
        }

        private void reload_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
        }
        #endregion

    }
}