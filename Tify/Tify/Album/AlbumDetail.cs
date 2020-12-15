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

        private string albumID;
        public AlbumDetail(string id)
        {
            InitializeComponent();

            albumID = id;


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            album_gridView.Rows.Add();
            album_gridView.Rows[0].Visible = false;
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            album_worker.RunWorkerAsync();
        }

        private DataTable albumTab_Table = new DataTable();
        private List<DataGridViewRow> tracks = new List<DataGridViewRow>();
        int countRow = 1;
        private void loadAlbum()
        {

            albumTab_Table.Clear();


            albumTab_Table = Database.getTrack_Album(albumID);


            try
            {

                if (albumTab_Table.Rows.Count == 0)
                {
                    MessageBox.Show("Empty");
                    return;
                }
                else
                {
                    foreach (DataRow item in albumTab_Table.Rows)
                    {
                        DataGridViewRow row = (DataGridViewRow)album_gridView.Rows[0].Clone();
                        row.Visible = true;
                        //#
                        row.Cells[0].Value = countRow++;
                        //title
                        row.Cells[1].Value = item["trackTitle"].ToString();
                        //artist
                        row.Cells[2].Value = item["artistName"].ToString();
                        //time
                        int[] duration = GetSongData.GetSongDuration(item["trackLink"].ToString());
                        if (duration[1] < 10)
                            row.Cells[3].Value = duration[0] + ":0" + duration[1];
                        else
                            row.Cells[3].Value = duration[0] + ":" + duration[1];
                        //add pic
                        row.Cells[4].Value = Properties.Resources.add_white;
                        //like pic
                        row.Cells[5].Value = Properties.Resources.like;


                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "album");
            }

        }

        private void album_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            loadAlbum();
        }

        private void album_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            album_gridView.Rows.AddRange(tracks.ToArray());
        }
        private List<TrackInfo> albumInfo;
        private AlbumContainer AlbumContainer;
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        public void setDetailInfo(List<TrackInfo> trackInfos, PictureBox inputcover, AlbumContainer callFm)
        {
            this.albumInfo = trackInfos;
            AlbumContainer = callFm;
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
            albumCover_pictureBox = inputcover;
            callFm.album.openChildForm(this);

        }

    }
}
