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
            load_worker.RunWorkerAsync();
        }

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable = new DataTable();
        private DataTable artistTable = new DataTable();
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
            trackTable = Database.loadTrackTableInTracks(mainScr.currentUser.UserID);
            foreach (DataRow item in trackTable.Rows)
            {
                TrackInfo tempTrack = new TrackInfo();
                string trackLink = item["trackLink"].ToString();
                using (PictureBox pb = new PictureBox())
                {
                    pb.Load(GetSongData.GetSongCover(trackLink));
                    tempTrack.Cover = pb.Image;
                }

                string artistName = "";
                artistTable = Database.getArtistOfTrack(item["trackID"].ToString());
                foreach (DataRow artist in artistTable.Rows)
                {
                    if(artist!=artistTable.Rows[artistTable.Rows.Count-1])
                    artistName += artist["artistName"].ToString() + ";";
                    else
                        artistName += artist["artistName"].ToString() ;

                }
                tempTrack.Title = item["trackTitle"].ToString();
                tempTrack.Artist = artistName;
                tempTrack.DateAdded = item["dateAdded"].ToString();

                int[] duration = GetSongData.GetSongDuration(item["trackLink"].ToString());
                if (duration[1] < 10)
                    tempTrack.Time = duration[0].ToString() + ":0" + duration[1].ToString();
                else
                    tempTrack.Time = duration[0].ToString() + ":" + duration[1].ToString();


                addTrackInfoToRow(tempTrack);
            }


        }

        private void addTrackInfoToRow(TrackInfo track)
        {
            DataGridViewRow temp = (DataGridViewRow)track_gridView.Rows[0].Clone();
            temp.Visible = true;

            temp.Cells[0].Value = track.Cover;
            temp.Cells[1].Value = track.Title;
            temp.Cells[2].Value = track.Artist;
            temp.Cells[3].Value = track.DateAdded;
            temp.Cells[5].Value = rightIconImgList.Images["add.png"];
            temp.Cells[6].Value = rightIconImgList.Images["liked.png"];
            temp.Cells[4].Value = track.Time;
            rows.Add(temp);
        }

        private void trackGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)//like
            {
            }
            else if (e.ColumnIndex == 5)//add to playlist
            {
            }
        }

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

        private void track_gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}