﻿using System;
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
    public partial class ArtistDetail : Form
    {
        public ArtistDetail()
        {
            InitializeComponent();


           

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        public void showLoading()
        {
            loading_SplashScreen1.BringToFront();
        }
        public void hideLoading()
        {
            loading_SplashScreen1.SendToBack();
        }
        public ArtistDetail(Artist artistFm)
        {
            InitializeComponent();


            artistForm = artistFm;



        

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        private Artist artistForm;
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();


        #region set detail info

        private ArtistContainer artistContainers;
        public void setTrackDetailInfo(List<TrackInfo> trackInfos, ArtistContainer callFm)
        {
            this.trackInfos = trackInfos;
            artistContainers = callFm;
            track_gridView.Rows.Clear();
            track_gridView.Rows.Add();
            track_gridView.Rows[0].Visible = false;
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)track_gridView.Rows[0].Clone();
                tempRow.Visible = true;
                tempRow.Tag = track;
                tempRow.Cells[0].Value = track.Cover;
                tempRow.Cells[1].Value = track.Title;
                tempRow.Cells[2].Value = track.Artist;
                tempRow.Cells[3].Value = track.Time;
                tempRow.Cells[4].Value = Properties.Resources.add;
                if (track.IsLoved)
                {
                    tempRow.Cells[5].Value = Properties.Resources.liked;
                }
                else
                {
                    tempRow.Cells[5].Value = Properties.Resources.like;
                }
                rows.Add(tempRow);
            }

            track_gridView.Rows.AddRange(rows.ToArray());


            artistName_label.Text = callFm.artistName_Label.Text;
            cover_pictureBox.Image = callFm.artistCover_panel.BackgroundImage;
           
        

            artistForm.openChildForm(this);
            track_gridView.Rows.Remove(track_gridView.Rows[0]);
            checkLoved();
            hideLoading();
        }



        public void setAlbumInfo(List<AlbumContainer> albumContainers, ArtistContainer callFm)
        {
            artistAlbum_container.clearItem();
            artistAlbum_container.setContainerName("Albums");
            artistAlbum_container.addRangeItem(albumContainers.ToArray());
        }
        #endregion


        #region enter,leave row

        private void trackGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //change cursor
            track_gridView.Cursor = Cursors.Hand;


            //change back color
            if (track_gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(19, 19, 20))
            {
                return;
            }
            foreach (DataGridViewCell cell in track_gridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.FromArgb(19, 19, 20);
            }
        }

        private void trackGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //change cursor

            track_gridView.Cursor = Cursors.Default;

            //change back color

            if (track_gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
            {
                return;
            }
            foreach (DataGridViewCell cell in track_gridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.Black;
            }
        }



        #endregion enter,leave row

        #region cell click event

        private void track_gridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow selectedRow = track_gridView.Rows[e.RowIndex];
            TrackInfo selectedTrack = selectedRow.Tag as TrackInfo;
         
            if (e.ColumnIndex == 5)//like track
            {
                if (selectedTrack.IsLoved == false)
                {
                    Database.addTrackToUserLikeTrack(artistForm.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = true;
                    selectedRow.Cells[5].Value = Properties.Resources.liked;
                    selectedRow.Tag = selectedTrack;
                    selectedTrack.DateAdded = DateTime.Now.ToShortDateString();
                    artistForm.mainScr.tracksScr.addRow(selectedTrack);
                }
                else
                {
                    Database.deleteTrackInUserLikeTrack(artistForm.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = false;
                    selectedRow.Cells[5].Value = Properties.Resources.like;
                    selectedRow.Tag = selectedTrack;
                    artistForm.mainScr.tracksScr.deleteRow(selectedTrack.TrackID);
                }
                
                artistForm.reloadArtistContainer();
                artistForm.mainScr.myMixScr.reloadMixContainer();
                artistForm.mainScr.albumsScr.reloadAlbumContainer();
                artistForm.mainScr.playlistScr.reloadPlaylistContainer();
                artistForm.mainScr.checkLoved();
            }
            else if (e.ColumnIndex == 4)// add to playlist
            {
                AddtoPlaylistForm addFm = new AddtoPlaylistForm(artistForm.mainScr, selectedTrack.TrackID);
                addFm.ShowDialog();
            }
        }
        #endregion


        #region play track on clicking row
        private void track_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TrackInfo trackToPlay = track_gridView.Rows[e.RowIndex].Tag as TrackInfo;

            artistForm.mainScr.nextTrack.Clear();
            artistForm.mainScr.currentTrackIndex = 0;
            for (int i = e.RowIndex; i < track_gridView.Rows.Count; i++)
            {
                artistForm.mainScr.addTrackToQueue((track_gridView.Rows[i].Tag as TrackInfo));
            }
            if (artistForm.mainScr.shuffle_button.Tag.ToString() == "on")
            {
                artistForm.mainScr.enableShuffle();
            }
            else
            {
                artistForm.mainScr.disableShuffle();
            }
            artistForm.mainScr.changeSong(artistForm.mainScr.Dequeue());
            artistForm.mainScr.setplayfrom(artistName_label.Text);
        }

        #endregion

        #region like artist
        private void like_button_Click(object sender, EventArgs e)
        {
            if (Database.checkUserLikeArtist(artistContainers.artistID, artistForm.mainScr.CurrentUser.UserID))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to unfollow this Artist ?", "Unfollow Artist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Database.deleteArtistFromUserFollowArtist(artistContainers.artistID, artistForm.mainScr.CurrentUser.UserID);
                    artistForm.mainScr.backForm_button.PerformClick();
                    like_button.BackgroundImage = Properties.Resources.like;
                    artistForm.reloadArtistTab();
                }
            }
            else
            {
                Database.addArtistToUserFollowArtist(artistContainers.artistID, artistForm.mainScr.CurrentUser.UserID);
                like_button.BackgroundImage = Properties.Resources.liked;
                artistForm.reloadArtistTab();
            }
        }
        public void checkLoved()
        {
            if (Database.checkUserLikeArtist(artistContainers.artistID, artistForm.mainScr.CurrentUser.UserID))
            {
                like_button.BackgroundImage = Properties.Resources.liked;
            }
            else
            {
                like_button.BackgroundImage = Properties.Resources.like;
            }
        }

        #endregion

        private void play_button_Click(object sender, EventArgs e)
        {
            artistForm.mainScr.nextTrack.Clear();
            if (track_gridView.Rows.Count == 0)
            {
                MessageBox.Show("Nothing to play");
                return;
            }
            //
            artistForm.mainScr.currentTrackIndex = 0;
            //
            foreach (DataGridViewRow track in track_gridView.Rows)
            {

                TrackInfo trackToPlay = track.Tag as TrackInfo;
                artistForm.mainScr.addTrackToQueue(trackToPlay);

            }
            //
            if (sender == playShuffle_Button)
            {
                artistForm.mainScr.enableShuffle();
            }
            else
            {
                artistForm.mainScr.disableShuffle();
            }
            //
            artistForm.mainScr.changeSong(artistForm.mainScr.Dequeue());
            artistForm.mainScr.setplayfrom(artistName_label.Text);
        }
    }
}
