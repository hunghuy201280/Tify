using GetData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class AlbumDetail : Form
    {
        SqlConnection connection;

        public AlbumDetail()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private Albums albumsFm;
        public AlbumDetail(Albums albums)
        {
            InitializeComponent();

            albumsFm = albums;

           
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            album_gridView.Rows.Add();
            album_gridView.Rows[0].Visible = false;

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

     
        }

        private DataTable albumTab_Table = new DataTable();
        private List<DataGridViewRow> tracks = new List<DataGridViewRow>();
    
        private List<TrackInfo> albumInfo;
        private AlbumContainer albumContainer;
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        
        public void setDetailInfo(List<TrackInfo> trackInfos, PictureBox inputcover, AlbumContainer callFm)
        {
            this.albumInfo = trackInfos;
            albumContainer = callFm;
            int indexCount = 1;
            album_gridView.Rows.Clear();
            album_gridView.Rows.Add();
            album_gridView.Rows[0].Visible = false;
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)album_gridView.Rows[0].Clone();
                tempRow.Visible = true;
                tempRow.Tag = track;
                tempRow.Cells[0].Value = indexCount++;
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

            album_gridView.Rows.AddRange(rows.ToArray());
            callFm.AlbumForm.openChildForm(this);

            //set upper detail
            TimeSpan time = TimeSpan.FromSeconds(callFm.timeInSec);
            string str = time.ToString(@"hh\:mm\:ss");
            string artist = albumContainer.albumArtist_label.Text;
            string year = albumContainer.albumYear_label.Text;
            artist_track_time__label.Text = "by " + artist + " — " + albumInfo.Count +" Tracks — " + str;
            albumName_label.Text = albumContainer.albumName_label.Text;
            albumCover_pictureBox.Image = inputcover.Image;
            releaseYear_label.Text ="Released "+year ;

        }
      

        #region enter,leave row

        private void trackGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //change cursor
            album_gridView.Cursor = Cursors.Hand;


            //change back color
            if (album_gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(19, 19, 20))
            {
                return;
            }
            foreach (DataGridViewCell cell in album_gridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.FromArgb(19, 19, 20);
            }
        }

        private void trackGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //change cursor

            album_gridView.Cursor = Cursors.Default;

            //change back color

            if (album_gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
            {
                return;
            }
            foreach (DataGridViewCell cell in album_gridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.Black;
            }
        }



        #endregion enter,leave row

        #region cell click event
        private void album_gridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow selectedRow = album_gridView.Rows[e.RowIndex];
            TrackInfo selectedTrack = selectedRow.Tag as TrackInfo;
           
            if (e.ColumnIndex == 5)//like track
            {
                if (selectedTrack.IsLoved == false)
                {
                    Database.addTrackToUserLikeTrack(albumsFm.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = true;
                    selectedRow.Cells[5].Value = Properties.Resources.liked;
                    selectedRow.Tag = selectedTrack;
                    selectedTrack.DateAdded = DateTime.Now.ToShortDateString();
                    albumsFm.mainScr.tracksScr.addRow(selectedTrack);
                }
                else
                {
                    Database.deleteTrackInUserLikeTrack(albumsFm.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = false;
                    selectedRow.Cells[5].Value = Properties.Resources.like;
                    selectedRow.Tag = selectedTrack;
                    albumsFm.mainScr.tracksScr.deleteRow(selectedTrack.TrackID);
                }
                albumsFm.reloadAlbumContainer();
                albumsFm.mainScr.myMixScr.reloadMixContainer();
                albumsFm.mainScr.playlistScr.reloadPlaylistContainer();
                

            }
            else if (e.ColumnIndex == 4)// add to playlist
            {
                AddtoPlaylistForm addFm = new AddtoPlaylistForm(albumsFm.mainScr, selectedTrack.TrackID);
                addFm.ShowDialog();
            }
        }
        #endregion


        #region play track on clicking row
        private void track_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TrackInfo trackToPlay = album_gridView.Rows[e.RowIndex].Tag as TrackInfo;
            albumsFm.mainScr.changeSong(trackToPlay);
        }

        #endregion

        #region play button
        private void play_button_Click(object sender, EventArgs e)
        {
            albumsFm.mainScr.nextTrack.Clear();
            foreach (DataGridViewRow track in album_gridView.Rows)
            {

                TrackInfo trackToPlay = track.Tag as TrackInfo;
                albumsFm.mainScr.addTrackToQueue(trackToPlay);

            }
            albumsFm.mainScr.changeSong(albumsFm.mainScr.nextTrack.Dequeue() as TrackInfo);
        }
        #endregion


        #region shuffle button
        private void playShuffle_Button_Click(object sender, EventArgs e)
        {
            albumsFm.mainScr.nextTrack.Clear();
            Random rnd = new Random(DateTime.Now.Second);
            int numOfTracks = album_gridView.Rows.Count;


            List<int> numbers = new List<int>();
            for (int i = 0; i < numOfTracks; i++)
            {
                int num = rnd.Next(0, numOfTracks);
                while (numbers.Contains(num))
                {
                    num = rnd.Next(0, numOfTracks);
                }
                numbers.Add(num);
                TrackInfo trackToPlay = album_gridView.Rows[num].Tag as TrackInfo;
                albumsFm.mainScr.addTrackToQueue(trackToPlay);
            }
            albumsFm.mainScr.changeSong(albumsFm.mainScr.nextTrack.Dequeue() as TrackInfo);
        }
        #endregion
    }
}
