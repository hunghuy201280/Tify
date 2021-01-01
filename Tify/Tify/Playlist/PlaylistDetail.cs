using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
        public PlaylistContainer playlistContainer;
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

        public void setCover(Image[] cover)
        {

            int coverIndex = 0;
            for (int i = 0; i < playlistCover_pictureBox.Controls.Count; i++)
            {
             
            
                if (coverIndex >= cover.Length)
                {
                    break;
                }
                if (playlistCover_pictureBox.Controls[i] is PictureBox)
                {
                    PictureBox tempPb = playlistCover_pictureBox.Controls[i] as PictureBox;
                   
                    tempPb.Image = cover[coverIndex++];


                }
                else
                {
                    continue;
                }
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

        public void setDetailInfo(List<TrackInfo> trackInfos, Image[] cover, PlaylistContainer callFm, bool isChart)
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

            int coverIndex = 0;

            for (int i = 0; i < playlistCover_pictureBox.Controls.Count; i++)
            {

                if (coverIndex >= cover.Length)
                {
                    break;
                }
                if (playlistCover_pictureBox.Controls[i] is PictureBox)
                {
                    PictureBox tempPb = playlistCover_pictureBox.Controls[i] as PictureBox;
                    tempPb.Image = cover[coverIndex++];
                }
                else
                {
                    continue;
                }
            }

            description_label.Text = callFm.description;
            playlistTitle_label.Text = callFm.playlistName;

            TimeSpan time = TimeSpan.FromSeconds(callFm.timeInSec);

            string str = time.ToString(@"hh\:mm\:ss");
            createdBy_label.Text = "Created by " + callFm.owner + " - " + trackInfos.Count + " Tracks - " + str;
            //Created by me - 10 Tracks - 1:24:00

            track_dataGridView.Rows.Remove(track_dataGridView.Rows[0]);

            if (isChart)
            {
                deletePlaylist_button.Hide();
                chartCover_panel.BackgroundImage = callFm.playlistCover_panel.BackgroundImage;
                chartCover_panel.Show();
                chartCover_panel.BringToFront();
                //ẩn nút xóa
                track_dataGridView.Columns[7].Visible = false;

                editPlaylist_button.Hide();

            }
            else
            {
                deletePlaylist_button.Show();
                chartCover_panel.Hide();
                //hiện nút xóa
                track_dataGridView.Columns[7].Visible = true;

                editPlaylist_button.Show();

            }
            if (callFm.canDelete)
            {
                deletePlaylist_button.Show();
                editPlaylist_button.Show();
            }
            else
            {
                deletePlaylist_button.Hide();
                editPlaylist_button.Hide();
            }

            hideLoading();
        }

        #region play track on clicking row

        private void track_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //khi double click row trong grid view, clear nextrack, add tất cả các track phía sau vào nexttrack, kiểm tra random,...
            if (e.ColumnIndex == 7 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                return;
            }
            TrackInfo trackToPlay = track_dataGridView.Rows[e.RowIndex].Tag as TrackInfo;
            //
            playlistForm.mainScr.nextTrack.Clear();
            playlistForm.mainScr.currentTrackIndex = 0;
            for (int i = e.RowIndex; i < track_dataGridView.Rows.Count; i++)
            {
                playlistForm.mainScr.addTrackToQueue((track_dataGridView.Rows[i].Tag as TrackInfo));
            }
            if (playlistForm.mainScr.shuffle_button.Tag.ToString() == "on")
            {
                playlistForm.mainScr.enableShuffle();
            }
            else
            {
                playlistForm.mainScr.disableShuffle();
            }

            //

            playlistForm.mainScr.changeSong(playlistForm.mainScr.Dequeue());
            playlistForm.mainScr.setplayfrom(playlistTitle_label.Text);
        }

        #endregion play track on clicking row

        #region play button,shuffle button

        private void play_button_Click(object sender, EventArgs e)
        {
            playlistForm.mainScr.nextTrack.Clear();
            if (track_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nothing to play");
                return;
            }
            //
            playlistForm.mainScr.currentTrackIndex = 0;
            //
            foreach (DataGridViewRow track in track_dataGridView.Rows)
            {
                TrackInfo trackToPlay = track.Tag as TrackInfo;
                playlistForm.mainScr.addTrackToQueue(trackToPlay);
            }
            //
            if (sender == playShuffle_Button)
            {
                playlistForm.mainScr.enableShuffle();
            }
            else
            {
                playlistForm.mainScr.disableShuffle();
            }
            //
            playlistForm.mainScr.changeSong(playlistForm.mainScr.Dequeue());
            playlistForm.mainScr.setplayfrom(playlistTitle_label.Text);
        }

        #endregion play button,shuffle button

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

            if (e.ColumnIndex == 7)
            {
                Database.deleteTrackFromPlaylist(playlistContainer.playlistID, selectedTrack.TrackID);
                trackInfo.Remove(selectedTrack);

                track_dataGridView.Rows.Remove(selectedRow);

                TimeSpan duration = TimeSpan.ParseExact(selectedTrack.Time, "mm\\:ss", CultureInfo.InvariantCulture);
                int seconds = (int)duration.TotalSeconds;
                playlistContainer.timeInSec -= seconds;
                TimeSpan time = TimeSpan.FromSeconds(playlistContainer.timeInSec);

                string str = time.ToString(@"hh\:mm\:ss");
                createdBy_label.Text = "Created by " + playlistContainer.owner + " - " + trackInfo.Count + " Tracks - " + str;
                playlistContainer.numberOfTracks_label.Text = --playlistContainer.trackCount + " Tracks";
                playlistContainer.loadCover(true);
            }

            #endregion delete track from playlist

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
                playlistForm.mainScr.artistScr.reloadArtistContainer();
                playlistForm.mainScr.checkLoved();
            }
            else if (e.ColumnIndex == 5)// add to playlist
            {
                AddtoPlaylistForm addFm = new AddtoPlaylistForm(playlistForm.mainScr, selectedTrack.TrackID);
                addFm.ShowDialog();
            }
        }

        #endregion cell click event

        #region delete playlist button click

        private void deletePlaylist_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this playlist ?", "Delete Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Database.deletePlaylist(playlistContainer.playlistID);

                playlistForm.mainScr.backForm_button.PerformClick();
                playlistForm.mainScr.CreatePL.AddPlaylistButtonToMenuPanel(playlistForm.mainScr.PlayList_FlowPanel);

                playlistForm.reload_createNew();
            }
        }

        #endregion delete playlist button click

        #region add button

        private void addToPlaylist_Button_Click(object sender, EventArgs e)
        {
            AddtoPlaylistForm add2PL = new AddtoPlaylistForm(playlistForm.mainScr, true, trackInfo);
            add2PL.ShowDialog();
            //add reload form here
            //->
        }

        #endregion add button

        #region edit playlist
        private void editPlaylist_button_Click(object sender, EventArgs e)
        {
            UpdatePlaylist updatePlaylist = new UpdatePlaylist(playlistContainer);
            updatePlaylist.ShowDialog();
        }
        #endregion
    }
}