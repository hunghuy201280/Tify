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
    public partial class MixDetail : Form
    {


        public MixDetail()
        {
            InitializeComponent();







            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;

        }

        MyMix myMix;
        public MixDetail(MyMix callform)
        {
            InitializeComponent();


            myMix = callform;




            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
           

        }

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();


        public void showLoading()
        {
            loading_SplashScreen1.BringToFront();
        }
        public void hideLoading()
        {
            loading_SplashScreen1.SendToBack();
        }

        private List<TrackInfo> trackInfos = new List<TrackInfo>();

        public void SetDetailInfo(List<TrackInfo> trackInfos,Image cover,bool open,MyMixContainer callFm)
        {
            track_dataGridView.Rows.Clear();
            this.trackInfos = trackInfos;
            //create template row
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)track_dataGridView.Rows[0].Clone();
                tempRow.Visible = true;
                tempRow.Tag = track;
                tempRow.Cells[0].Value = track.Title;
                tempRow.Cells[1].Value = track.Artist;
                tempRow.Cells[2].Value = track.Time;
                tempRow.Cells[3].Value = Properties.Resources.add;
                if (track.IsLoved)
                {
                    tempRow.Cells[4].Value = Properties.Resources.liked;
                }
                else
                {
                    tempRow.Cells[4].Value = Properties.Resources.like;
                }
                rows.Add(tempRow);
            }
            
            track_dataGridView.Rows.AddRange(rows.ToArray());
            cover_pictureBox.Image = cover;
            mixTitle_label.Text = callFm.playlistName_label.Text;
            mixArtist_label.Text = callFm.artist_label.Text;


            if(open)
            myMix.openChildForm(this);
            //remove template row
            track_dataGridView.Rows.Remove(track_dataGridView.Rows[0]);
        }

        #region like,add to playlist
        private void track_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex==-1)
                return;
            DataGridViewRow selectedRow = track_dataGridView.Rows[e.RowIndex];
            TrackInfo selectedTrack = selectedRow.Tag as TrackInfo;
            //love
            if (e.ColumnIndex==4)
            {
                if (selectedTrack.IsLoved==false)
                {
                    Database.addTrackToUserLikeTrack(myMix.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = true;
                    selectedRow.Cells[4].Value = Properties.Resources.liked;
                    selectedRow.Tag = selectedTrack;
                    selectedTrack.DateAdded = DateTime.Now.ToShortDateString();
                    myMix.mainScr.tracksScr.addRow(selectedTrack);
                }
                else
                {
                    Database.deleteTrackInUserLikeTrack(myMix.mainScr.CurrentUser.UserID, selectedTrack.TrackID);
                    selectedTrack.IsLoved = false;
                    selectedRow.Cells[4].Value = Properties.Resources.like;
                    selectedRow.Tag = selectedTrack;
                    myMix.mainScr.tracksScr.deleteRow(selectedTrack.TrackID);
                }


                myMix.mainScr.albumsScr.reloadAlbumContainer();
                myMix.mainScr.playlistScr.reloadPlaylistContainer();
                myMix.reloadMixContainer();
                myMix.mainScr.artistScr.reloadArtistContainer();
                myMix.mainScr.checkLoved();
            }
            else if (e.ColumnIndex==3)// add to playlist
            {
                AddtoPlaylistForm addFm = new AddtoPlaylistForm(myMix.mainScr, selectedTrack.TrackID);
                addFm.ShowDialog();
            }
        }
        #endregion

        //datagridview Event


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

        #region play track on clicking row
        private void track_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            TrackInfo trackToPlay = track_dataGridView.Rows[e.RowIndex].Tag as TrackInfo;
            myMix.mainScr.nextTrack.Clear();
            myMix.mainScr.currentTrackIndex = 0;
            for (int i = e.RowIndex; i < track_dataGridView.Rows.Count; i++)
            {
                myMix.mainScr.addTrackToQueue((track_dataGridView.Rows[i].Tag as TrackInfo));
            }
            if (myMix.mainScr.shuffle_button.Tag.ToString() == "on")
            {
                myMix.mainScr.enableShuffle();
            }
            else
            {
                myMix.mainScr.disableShuffle();
            }
            myMix.mainScr.changeSong(myMix.mainScr.Dequeue());
            myMix.mainScr.setplayfrom(mixTitle_label.Text);
        }


        #endregion

        #region play,shuffle button
        private void play_button_Click(object sender, EventArgs e)
        {
            myMix.mainScr.nextTrack.Clear();

            myMix.mainScr.currentTrackIndex = 0;
            foreach (DataGridViewRow track in track_dataGridView.Rows)
            {
             
                TrackInfo trackToPlay = track.Tag as TrackInfo;
                myMix.mainScr.addTrackToQueue(trackToPlay);
            }
            if (sender == playShuffle_Button)
            {
                myMix.mainScr.enableShuffle();
            }
            else
            {
                myMix.mainScr.disableShuffle();
            }
            myMix.mainScr.changeSong(myMix.mainScr.Dequeue());
            myMix.mainScr.setplayfrom(mixTitle_label.Text);
        }
        #endregion

    

        private void addToPlaylist_Button_Click(object sender, EventArgs e)
        {
            AddtoPlaylistForm add2PL = new AddtoPlaylistForm(myMix.mainScr, true, trackInfos);
            add2PL.ShowDialog();
            //add reload form here
            //->
        }
    }
}
