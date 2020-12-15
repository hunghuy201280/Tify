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
        int countRow = 1;
    
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
