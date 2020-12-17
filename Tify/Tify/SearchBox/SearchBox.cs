using GetData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Tify
{
    public partial class SearchBox : Form
    {
        public SearchBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private string searchKeyWord;
        private MainScreen mainScr;
        private AddtoPlaylistForm add2PL;

        public SearchBox(MainScreen callForm)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            mainScr = callForm;
        }

        public void doSearch(string keyword)
        {
            track_gridView.Rows.Clear();
            trackInfos.Clear();
            if (search_worker.IsBusy || artist_worker.IsBusy || album_worker.IsBusy)
            {
                return;
            }
            searchKeyWord = TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(keyword);

            search_worker.RunWorkerAsync();
            //artist_worker.RunWorkerAsync();
            //album_worker.RunWorkerAsync();
        }

        #region load album

        private DataTable albumTab_Table = new DataTable();
        private List<AlbumContainer> albums = new List<AlbumContainer>();

        private void loadAlbum()
        {
            try
            {
                albumTab_Table = Database.getAlbumTable_Search(searchKeyWord);
                if (albumTab_Table.Rows.Count == 0)
                {
                    MessageBox.Show("Empty album");
                    return;
                }
                else
                {
                    foreach (DataRow item in albumTab_Table.Rows)
                    {
                        /*AlbumContainer container = new AlbumContainer(GetSongData.GetSongCover(item["albumLink"].ToString()), item["albumTitle"].ToString(),
                                     item["artistName"].ToString(), item["albumYear"].ToString());
                        albums.Add(container);*/
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "album");
            }
        }

        private void album_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadAlbum();
        }

        private void album_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            albumResult_flowPanel.Controls.AddRange(albums.ToArray());
        }

        #endregion load album

        #region load artist

        private DataTable artistTab_Table = new DataTable();
        private List<ArtistContainer> artists = new List<ArtistContainer>();

        private void loadArtist()
        {
            try
            {
                artistTab_Table = Database.getArtistTable_Search(searchKeyWord);
                if (artistTab_Table.Rows.Count == 0)
                {
                    MessageBox.Show("Empty artist");
                    return;
                }
                else
                {
                    foreach (DataRow item in artistTab_Table.Rows)
                    {
                        ArtistContainer container = new ArtistContainer(GetSongData.getArtistCover(item["artistName"].ToString())
                            , item["artistName"].ToString());
                        artists.Add(container);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "artist");
            }
        }

        private void artist_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadArtist();
        }

        private void artist_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            artistResult_flowPanel.Controls.AddRange(artists.ToArray());
        }

        #endregion load artist

        #region load track

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable = new DataTable();
        private DataTable artistTable = new DataTable();
        private List<TrackInfo> trackInfos = new List<TrackInfo>();


        
        public void loadTrack()
        {
            try
            {
                trackTable = Database.getTrackTable_Search(searchKeyWord);

                if (trackTable.Rows.Count == 0)
                {
                    MessageBox.Show("Empty track");
                    return;
                }
                else
                {
                    foreach (DataRow item in trackTable.Rows)
                    {
                        TrackInfo tempTrack = new TrackInfo();

                        string trackLink = item["trackLink"].ToString();
                        tempTrack.TrackLink = trackLink;
                        tempTrack.TrackID = item["trackID"].ToString();
                        
                            using (PictureBox pb = new PictureBox())
                            {
                                pb.Load(GetSongData.GetSongCover(tempTrack.TrackLink));
                                tempTrack.Cover = pb.Image;
                            }
                            TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(tempTrack.TrackLink));
                            string timeString = time.ToString(@"mm\:ss");
                            tempTrack.Time = timeString;
                        



                        artistTable = Database.getArtistOfTrack(item["trackID"].ToString());
                        string artist = "";
                        foreach (DataRow artistName in artistTable.Rows)
                        {
                            artist += artistName["artistName"].ToString() + ";";
                        }
                        tempTrack.Title = item["trackTitle"].ToString();
                        tempTrack.Artist = artist;


                        //check if loved
                        if (Database.checkIfTrackLoved(tempTrack.TrackID, mainScr.CurrentUser.UserID))
                            tempTrack.IsLoved = true;
                        else
                            tempTrack.IsLoved = false;

                        trackInfos.Add(tempTrack);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "track");
            }
        }


        public void SetGridViewRows(List<TrackInfo> trackInfos)
        {
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
                    tempRow.Cells[5].Value = Properties.Resources.liked;
                else
                    tempRow.Cells[5].Value = Properties.Resources.like;
                rows.Add(tempRow);
            }
                track_gridView.Rows.AddRange(rows.ToArray());
        }

        private void search_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadTrack();
        }

        private void search_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            SetGridViewRows(trackInfos);
            SearchBox_Tracks.PerformClick();
          
        }

        #endregion load track

        private void SearchBox_Button_Click(object sender, EventArgs e)
        {
            //top button
            Button btn = (Button)sender;
            foreach (var item in top_panel.Controls)
            {
                Button currentBtn;
                if (item is Button)
                    currentBtn = item as Button;
                else
                    continue;
                if (currentBtn.Tag == btn.Tag)
                {
                    currentBtn.BackColor = Color.White;
                    currentBtn.ForeColor = Color.Black;
                }
                else
                {
                    currentBtn.BackColor = Color.Black;
                    currentBtn.ForeColor = Color.White;
                }
            }

            if (btn.Tag.ToString() == "track_button")
                track_gridView.BringToFront();
            else if (btn.Tag.ToString() == "artist_button")
                artistResult_flowPanel.BringToFront();
            else if (btn.Tag.ToString() == "album_button")
                albumResult_flowPanel.BringToFront();
            else if (btn.Tag.ToString() == "playlist_button")
                playlistResult_flowPanel.BringToFront();
        }

        #region enter,leave row

        private void trackGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
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
            if (e.RowIndex <= 0)
                return;
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

        private void track_gridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            TrackInfo trackToPlay = track_gridView.Rows[e.RowIndex].Tag as TrackInfo;
            mainScr.changeSong(trackToPlay);
        }

        private void track_gridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow selectedRow = track_gridView.Rows[e.RowIndex];
            TrackInfo selectedTrack = selectedRow.Tag as TrackInfo;
            //love
            if (e.ColumnIndex == 5)
            {
                if (selectedTrack.IsLoved == false)
                {
                    Database.addTrackToUserLikeTrack(mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = true;
                    selectedRow.Cells[5].Value = Properties.Resources.liked;
                    selectedRow.Tag = selectedTrack;
                    selectedTrack.DateAdded = DateTime.Now.ToShortDateString();
                    mainScr.tracksScr.addRow(selectedTrack);
                }
                else
                {
                    Database.deleteTrackInUserLikeTrack(mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = false;
                    selectedRow.Cells[5].Value = Properties.Resources.like;
                    selectedRow.Tag = selectedTrack;
                    mainScr.tracksScr.deleteRow(selectedTrack.TrackID);
                }
            }
            //add to playlist
            if (e.ColumnIndex == 4)
            {
                add2PL = new AddtoPlaylistForm(mainScr, selectedTrack.TrackID);
                add2PL.ShowDialog();
            }
        }

       
    }
}