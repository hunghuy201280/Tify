using GetData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Tify
{
    public partial class Tracks : Form
    {
        private SqlConnection connection;
        private AddtoPlaylistForm add2PL;
        

        public Tracks()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //enable doublebuffered
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            //dummy row
            track_gridView.Rows.Add();
            track_gridView.Rows[0].Visible = false;

            //MessageBox.Show(dataGridView1.Font.ToString());
        }

        private MainScreen mainScr;

        public Tracks(MainScreen callFm)
        {
            InitializeComponent();
            mainScr = callFm;
        

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //enable doublebuffered
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            //dummy row
            track_gridView.Rows.Add();
            track_gridView.Rows[0].Visible = false;

            //MessageBox.Show(dataGridView1.Font.ToString());
            load_worker.RunWorkerAsync();
        }

        public void addRow(TrackInfo track)
        {
            if (track.Cover==null)
            {
                PictureBox pb = new PictureBox();
                pb.Load(GetSongData.GetSongCover(track.TrackLink));
                track.Cover = pb.Image;
            }
            addTrackInfoToRow(new TrackInfo[1] { track });
            track_gridView.Rows.Add(rows[rows.Count - 1]);
        }
        public void deleteRow(string trackID)
        {
            foreach (DataGridViewRow row in track_gridView.Rows)
            {
                if (row.Index == 0)
                    continue;
                TrackInfo temp=row.Tag as TrackInfo;

                if (temp.TrackID==trackID)
                {
                    track_gridView.Rows.Remove(row);
                    break;
                }
            }
        }

        #region load track
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable = new DataTable();
        private DataTable artistTable = new DataTable();
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private void load_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadTrack();
        }

        private void load_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error==null)
            {
                track_gridView.Rows.AddRange(rows.ToArray());
            }
        }
        public void loadTrack()
        {
            string lastTrackID = "";
            trackTable = Database.loadTrackTableInTracks(mainScr.CurrentUser.UserID);
            foreach (DataRow item in trackTable.Rows)
            {
                if (lastTrackID==item["trackID"].ToString() && lastTrackID!="")
                {
                    trackInfos[trackInfos.Count - 1].Artist += "; " + item["artistName"].ToString();
                }
                else
                {
                    TrackInfo tempTrack = new TrackInfo();
                    string trackLink = item["trackLink"].ToString();
                    tempTrack.TrackLink = trackLink;
                    tempTrack.TrackID = item["trackID"].ToString();
                    using (PictureBox pb = new PictureBox())
                    {
                        pb.Load(GetSongData.GetSongCover(trackLink));
                        tempTrack.Cover = pb.Image;
                    }

                    tempTrack.Title = item["trackTitle"].ToString();
                    tempTrack.Artist = item["artistName"].ToString();
                    DateTime dateAdded = DateTime.Parse(item["dateAdded"].ToString());
                    tempTrack.DateAdded = dateAdded.ToShortDateString();


                    if (Database.checkIfTrackLoved(tempTrack.TrackID, mainScr.CurrentUser.UserID))
                    {
                        tempTrack.IsLoved = true;
                    }
                    else
                    {
                        tempTrack.IsLoved = false;
                    }

                    int[] duration = GetSongData.GetSongDuration(item["trackLink"].ToString());
                    if (duration[1] < 10)
                        tempTrack.Time = duration[0].ToString() + ":0" + duration[1].ToString();
                    else
                        tempTrack.Time = duration[0].ToString() + ":" + duration[1].ToString();

                    lastTrackID = tempTrack.TrackID;
                    trackInfos.Add(tempTrack);
                }
              
            }
            addTrackInfoToRow(trackInfos.ToArray());


        }

        private void addTrackInfoToRow(TrackInfo[] trackinfos)
        {
            foreach (var track in trackinfos)
            {
                DataGridViewRow temp = (DataGridViewRow)track_gridView.Rows[0].Clone();
                temp.Visible = true;

                temp.Tag = track;
                temp.Cells[0].Value = track.Cover;
                temp.Cells[1].Value = track.Title;
                temp.Cells[2].Value = track.Artist;
                temp.Cells[3].Value = track.DateAdded;
                temp.Cells[5].Value = rightIconImgList.Images["add.png"];
                if (track.IsLoved)
                {
                    temp.Cells[6].Value = rightIconImgList.Images["liked.png"];
                }
                else
                {
                    temp.Cells[6].Value = rightIconImgList.Images["like.png"];
                }
                temp.Cells[4].Value = track.Time;
                rows.Add(temp);
            }
          
        }

        #endregion  


        #region event cell click 
        private void trackGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==-1)
            {
                return;
            }
            DataGridViewRow selectedRow = track_gridView.Rows[e.RowIndex];
            TrackInfo selectedTrack = selectedRow.Tag as TrackInfo;
            if (e.ColumnIndex == 6)//unlike
            {
                DataTable checkMixChangesTable = Database.checkRelationshipWithMyMixWhenDeleteLovedTrack(selectedTrack.TrackID, mainScr.CurrentUser.UserID);
                if (checkMixChangesTable.Rows.Count!=0)
                {
                    foreach (DataRow mixID in checkMixChangesTable.Rows)
                    {
                        mainScr.myMixScr.reloadMixContainer(mixID[0].ToString());
                    }
                }
                selectedTrack.IsLoved = false;
                track_gridView.Rows.Remove(selectedRow);
                Database.deleteTrackInUserLikeTrack(mainScr.CurrentUser.UserID, selectedTrack.TrackID);
            }
            else if (e.ColumnIndex == 5)//add to playlist
            {
                add2PL = new AddtoPlaylistForm(mainScr);
                add2PL.ShowDialog();
            }
        }
        private void track_gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            TrackInfo trackToPlay = track_gridView.Rows[e.RowIndex].Tag as TrackInfo;
            mainScr.changeSong(trackToPlay);
        }
        #endregion
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

       
    }
}