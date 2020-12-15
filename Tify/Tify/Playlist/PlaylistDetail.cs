﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tify
{
    public partial class PlaylistDetail : Form
    {
        public PlaylistDetail()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private Playlist playlistForm;
        private PlaylistContainer playlistContainer;
        private List<TrackInfo> trackInfo;
        public PlaylistDetail(Playlist callFm)
        {
            InitializeComponent();

            playlistForm = callFm;

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();

        public void setDetailInfo(List<TrackInfo> trackInfos, Image[] cover, bool open, PlaylistContainer callFm)
        {
            this.trackInfo = trackInfos;
            playlistContainer = callFm;
            int indexCount = 1;
            track_dataGridView.Rows.Clear();
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)track_dataGridView.Rows[0].Clone();
                tempRow.Visible = true;
                tempRow.Tag = track;
                tempRow.Cells[0].Value = indexCount++;
                tempRow.Cells[1].Value = track.Title;
                tempRow.Cells[2].Value = track.Artist;
                tempRow.Cells[3].Value = track.DateAdded;
                tempRow.Cells[4].Value = track.Time;
                tempRow.Cells[5].Value = Properties.Resources.add;
                if (track.IsLoved)
                {
                    tempRow.Cells[6].Value = Properties.Resources.liked;
                }
                else
                {
                    tempRow.Cells[6].Value = Properties.Resources.like;
                }
                rows.Add(tempRow);
            }

            track_dataGridView.Rows.AddRange(rows.ToArray());

            for (int i = 0; i < playlistCover_pictureBox.Controls.Count; i++)
            {
                try
                {
                    PictureBox tempPb = playlistCover_pictureBox.Controls[i] as PictureBox;
                    tempPb.Image = cover[i];
                }
                catch (Exception)
                {
                }
            }

            description_label.Text = callFm.description;
            playlistTitle_label.Text = callFm.playlistName;


            TimeSpan time = TimeSpan.FromSeconds(callFm.timeInSec);

            
            string str = time.ToString(@"hh\:mm\:ss");
            createdBy_label.Text = "Created by " + callFm.owner + " - " + trackInfos.Count + " Tracks - "+str;
            //Created by me - 10 Tracks - 1:24:00

            if (open)
                playlistForm.openChildForm(this);
            track_dataGridView.Rows.Remove(track_dataGridView.Rows[0]);
        }


        #region play track on clicking row
        private void track_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TrackInfo trackToPlay = track_dataGridView.Rows[e.RowIndex].Tag as TrackInfo;
            playlistForm.mainScr.changeSong(trackToPlay);
        }

        #endregion

        #region play button
        private void play_button_Click(object sender, EventArgs e)
        {
            playlistForm.mainScr.nextTrack.Clear();
            foreach (DataGridViewRow track in track_dataGridView.Rows)
            {
              
                TrackInfo trackToPlay = track.Tag as TrackInfo;
                playlistForm.mainScr.addTrackToQueue(trackToPlay);

            }
            playlistForm.mainScr.changeSong(playlistForm.mainScr.nextTrack.Dequeue() as TrackInfo);
        }
        #endregion


        #region shuffle button
        private void playShuffle_Button_Click(object sender, EventArgs e)
        {
            playlistForm.mainScr.nextTrack.Clear();
            Random rnd = new Random(DateTime.Now.Second);
            int numOfTracks = track_dataGridView.Rows.Count;


            List<int> numbers = new List<int>();
            for (int i = 0; i < numOfTracks; i++)
            {
                int num = rnd.Next(0, numOfTracks);
                while (numbers.Contains(num))
                {
                    num = rnd.Next(0, numOfTracks);
                }
                numbers.Add(num);
                TrackInfo trackToPlay = track_dataGridView.Rows[num].Tag as TrackInfo;
                playlistForm.mainScr.addTrackToQueue(trackToPlay);
            }
            playlistForm.mainScr.changeSong(playlistForm.mainScr.nextTrack.Dequeue() as TrackInfo);
        }
        #endregion

        #region enter,leave row

        private void trackGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //change cursor
            track_dataGridView.Cursor = Cursors.Hand;


            //change back color
            if (track_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(19, 19, 20))
            {
                return;
            }
            foreach (DataGridViewCell cell in track_dataGridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.FromArgb(19, 19, 20);
            }
        }

        private void trackGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //change cursor

            track_dataGridView.Cursor = Cursors.Default;

            //change back color

            if (track_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
            {
                return;
            }
            foreach (DataGridViewCell cell in track_dataGridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.Black;
            }
        }



        #endregion enter,leave row


        #region cell click event
        private void track_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow selectedRow = track_dataGridView.Rows[e.RowIndex];
            TrackInfo selectedTrack = selectedRow.Tag as TrackInfo;
            #region delete track from playlist
            if (e.ColumnIndex==7)
            {
                Database.deleteTrackFromPlaylist(playlistContainer.playlistID, selectedTrack.TrackID);
                trackInfo.Remove(selectedTrack);
                track_dataGridView.Rows.Remove(selectedRow);
                createdBy_label.Text = "Created by " + playlistContainer.owner + " - " + trackInfo.Count + " Tracks";
                playlistContainer.numberOfTracks_label.Text=--playlistContainer.trackCount + " Tracks";
            }
            #endregion
            else if (e.ColumnIndex == 6)//like track
            {
                if (selectedTrack.IsLoved == false)
                {
                    Database.addTrackToUserLikeTrack(playlistForm.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = true;
                    selectedRow.Cells[6].Value = Properties.Resources.liked;
                    selectedRow.Tag = selectedTrack;
                    selectedTrack.DateAdded = DateTime.Now.ToShortDateString();
                    playlistForm.mainScr.tracksScr.addRow(selectedTrack);
                }
                else
                {
                    Database.deleteTrackInUserLikeTrack(playlistForm.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = false;
                    selectedRow.Cells[6].Value = Properties.Resources.like;
                    selectedRow.Tag = selectedTrack;
                    playlistForm.mainScr.tracksScr.deleteRow(selectedTrack.TrackID);
                }
                playlistForm.reloadPlaylistContainer();
                playlistForm.mainScr.myMixScr.reloadMixContainer();
                playlistForm.mainScr.albumsScr.reloadAlbumContainer();

            }
            else if (e.ColumnIndex == 5)// add to playlist
            {
                AddtoPlaylistForm addFm = new AddtoPlaylistForm(playlistForm.mainScr, selectedTrack.TrackID);
                addFm.ShowDialog();
            }
        }
        #endregion
    }
}