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
        SqlConnection connection;

        public MixDetail()
        {
            InitializeComponent();




            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);




            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;

        }

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable = new DataTable();
        string mixID;
        int coverNum;
        public void loadMixDetailContent(string id,int num)
        {
            mixID = id;
            coverNum = num;
            load_worker.RunWorkerAsync();
        }

        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //cover
            switch (coverNum)
            {
                case 1:
                    cover_pictureBox.Image = Properties.Resources.mymix1;
                    break;
                case 2:
                    cover_pictureBox.Image = Properties.Resources.mymix2;
                    break;
                case 3:
                    cover_pictureBox.Image = Properties.Resources.mymix3;
                    break;
                case 4:
                    cover_pictureBox.Image = Properties.Resources.mymix4;
                    break;
                default:
                    break;
            }

            //
            DataGridViewRow tempRow = (DataGridViewRow)track_dataGridView.Rows[0].Clone();
            tempRow.Visible = true;
            string sqlQuery = "select * from  " +
                "MyMix join MyMixHasTrack on MyMix.myMixID = MyMixHasTrack.myMixID " +
                "join Track on Track.trackID = MyMixHasTrack.trackID " +
                "join ArtistHasTrack on Track.trackID = ArtistHasTrack.trackID " +
                "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
                "where MyMix.myMixID = @id order by trackTitle; ";
            trackTable.Clear();
            //load trackTable
            using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
            {
                cmd.Parameters.AddWithValue("@id", mixID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    trackTable.Load(reader);
                }
            }

            //duyet tung track trong trackTable
            string lastTrackID = "";
            foreach (DataRow track in trackTable.Rows)
            {
                //neu trung trackID thi add them artist
                if (track["trackID"].ToString() == lastTrackID && lastTrackID != "")
                {
                    rows[rows.Count - 1].Cells[1].Value += ";" + track["artistName"].ToString();
                }
                else
                {
                    tempRow.Tag = track["trackID"].ToString();
                    string title = track["trackTitle"].ToString();
                    string artist = track["artistName"].ToString();
                    int[] duration = GetSongData.GetSongDuration(track["trackLink"].ToString());
                    string time;

                    //neu giay >=10
                    if (duration[10] >= 10)
                        time = duration[0] + ":" + duration[1];
                    else
                        time = duration[0] + ":0" + duration[1];
                    tempRow.Cells[0].Value = title;
                    tempRow.Cells[1].Value = artist;
                    tempRow.Cells[2].Value = time;
                    tempRow.Cells[3].Value = Properties.Resources.add;
                    tempRow.Cells[4].Value = Properties.Resources.like;

                }
            }

        }

        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            track_dataGridView.Rows.AddRange(rows.ToArray());
        }
    }
}
