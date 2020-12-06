using GetData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TiengVietKhongDau;
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
        SqlConnection connection;
        MainScreen mainScr;
        public SearchBox(string keyword,MainScreen callForm)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            mainScr = callForm;
            track_gridView.Rows.Add();
            track_gridView.Rows[0].Visible = false;
            searchKeyWord = TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(keyword);

            search_worker.RunWorkerAsync();
        }


        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable = new DataTable();
        private DataTable artistTable = new DataTable();

        public void loadTrack()
        {
            trackTable.Clear();
            string sqlQuery = "select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn " +
                "from Track where trackTitle like '%"+searchKeyWord+"%') as temp where rn = 1";

            connection.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        trackTable.Load(reader);
                    }
                }
                if (trackTable.Rows.Count == 0)
                {
                    MessageBox.Show("Empty");
                    return;
                }
                else
                {
                    foreach (DataRow item in trackTable.Rows)
                    {
                        DataGridViewRow temp = (DataGridViewRow)track_gridView.Rows[0].Clone();
                        string trackLink = item["trackLink"].ToString();
                        using (PictureBox pb = new PictureBox())
                        {
                            pb.Load(GetSongData.GetSongCover(trackLink));
                            temp.Cells[0].Value = pb.Image;
                        }
                        string artistQuery = "select artistName from ArtistHasTrack join Artist on Artist.artistID" +
                            " = ArtistHasTrack.artistID where trackID ="+item["trackID"].ToString();
                        using (SqlCommand cmd = new SqlCommand(artistQuery, connection))
                        {
                            artistTable.Clear();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                artistTable.Load(reader);
                            }
                        }


                        string artist = "";
                        foreach (DataRow artistName in artistTable.Rows)
                        {
                            artist += artistName["artistName"].ToString() + ";";
                        }
                        temp.Cells[1].Value = item["trackTitle"].ToString();
                        temp.Cells[2].Value = artist;
                        temp.Cells[4].Value = rightIconImgList.Images["add.png"];
                        temp.Cells[5].Value = rightIconImgList.Images["liked.png"];
                        temp.Tag = item["trackLink"].ToString();
                        int[] duration = GetSongData.GetSongDuration(item["trackLink"].ToString());
                        if (duration[1] < 10)
                            temp.Cells[3].Value = duration[0].ToString() + ":0" + duration[1].ToString();
                        else
                            temp.Cells[3].Value = duration[0].ToString() + ":" + duration[1].ToString();

                        temp.Visible = true;
                        rows.Add(temp);
                    }
                 


                }
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);

            }

            connection.Close();

        }
        private void search_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadTrack();
        }

        private void search_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            track_gridView.Rows.AddRange(rows.ToArray());
        }
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

            //track tab
            track_gridView.BringToFront();


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
        #endregion

        private void track_gridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mainScr.changeSong(track_gridView.Rows[e.RowIndex].Tag.ToString());
        }
    }
}