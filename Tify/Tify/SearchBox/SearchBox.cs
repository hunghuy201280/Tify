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
        private SqlConnection connection;
        private MainScreen mainScr;

        public SearchBox(string keyword, MainScreen callForm)
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
            connection.Open();

            search_worker.RunWorkerAsync();
            artist_worker.RunWorkerAsync();
        }



        #region load artist

        private DataTable artistTab_Table = new DataTable();
        private List<ArtistContainer> artists = new List<ArtistContainer>();
        private void loadArtist()
        {
           
            artistTab_Table.Clear();
            string sqlQuery = "select * from Artist where artistName like '%"+searchKeyWord+"%'";

            try
            {
                using (SqlCommand artist_cmd = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader artist_reader = artist_cmd.ExecuteReader())
                    {
                        artistTab_Table.Load(artist_reader);
                    }
                }
                if (artistTab_Table.Rows.Count == 0)
                {
                    MessageBox.Show("Empty");
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
                MessageBox.Show(e.Message);
            }

        }
        private void artist_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadArtist();
        }

        private void artist_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            artistResult_flowPanel.Controls.AddRange(artists.ToArray());
            if (!search_worker.IsBusy)
            {
                connection.Close();
            }
        }

        #endregion


        #region load track
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable = new DataTable();
        private DataTable artistTable = new DataTable();
        public void loadTrack()
        {
            trackTable.Clear();
            string sqlQuery = "select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn " +
                "from Track where trackTitle like '%" + searchKeyWord + "%') as temp where rn = 1";

           
            try
            {
                using (SqlCommand track_cmd = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader track_reader = track_cmd.ExecuteReader())
                    {
                        trackTable.Load(track_reader);
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
                            " = ArtistHasTrack.artistID where trackID =" + item["trackID"].ToString();
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
                MessageBox.Show(e.Message);
            }

        }


        private void search_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            loadTrack();
        }

        private void search_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            track_gridView.Rows.AddRange(rows.ToArray());
            if (!artist_worker.IsBusy)
            {
                connection.Close();
            }
        }
        #endregion
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

            if (btn.Tag.ToString()=="track_button")
                track_gridView.BringToFront();
            else if (btn.Tag.ToString()=="artist_button")
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
            mainScr.changeSong(track_gridView.Rows[e.RowIndex].Tag.ToString());
        }

        
    }
}