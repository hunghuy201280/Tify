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
    public partial class Tracks : Form
    {
        SqlConnection connection;
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
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Visible = false;

            //MessageBox.Show(dataGridView1.Font.ToString());
            
        }
       

       
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable=new DataTable();
        public void loadTrack(string trackID)
        {
            trackTable.Clear();
            string sqlQuery = "Select Track.*,Artist.* from Track join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID " +
                "join Artist on Artist.artistID = ArtistHasTrack.artistID where Track.trackID = @id";
            connection.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id",trackID);
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        trackTable.Load(reader);
                    }
                }
                if (trackTable.Rows.Count==0)
                {
                    MessageBox.Show("Empty");
                    return;
                }
                else
                {
                    DataGridViewRow temp = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    string trackLink = trackTable.Rows[0]["trackLink"].ToString();
                    using (PictureBox pb=new PictureBox())
                    {
                        pb.Load(GetSongData.GetSongCover(trackLink));
                        temp.Cells[0].Value = pb.Image;
                    }

                    
                   
                    string artist="";
                    foreach (DataRow item in trackTable.Rows)
                    {
                        artist += item["artistName"].ToString() + ";";
                    }
                    temp.Cells[1].Value = trackTable.Rows[0]["trackTitle"].ToString();
                    temp.Cells[2].Value = artist;
                    temp.Cells[3].Value = DateTime.Now.ToShortDateString();
                    temp.Cells[5].Value = rightIconImgList.Images["add.png"];
                    temp.Cells[6].Value = rightIconImgList.Images["liked.png"];
                    int[] duration = GetSongData.GetSongDuration(trackTable.Rows[0]["trackLink"].ToString());
                    if (duration[1]<10)
                        temp.Cells[4].Value = duration[0].ToString() + ":0" + duration[1].ToString();
                    else
                        temp.Cells[4].Value = duration[0].ToString() + ":" + duration[1].ToString();

                    temp.Visible = true;
                    rows.Add(temp);
                 

                }
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
                 
            }

            connection.Close();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            loadTrack(textBox1.Text);
            try
            {
                foreach (DataGridViewRow item in rows.ToArray())
                {
                    try
                    {
                        dataGridView1.Rows.Add(item);

                    }
                    catch (Exception)
                    {

                        
                    }
                }

                //change to addrange
                //dataGridView1.Rows.AddRange(rows.ToArray());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<=0)
                return;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(19, 19, 20))
            {
                return;
            }
            foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.FromArgb(19, 19, 20);
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
            {
                return;
            }
            foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.Black;
            }
        }

        
    }
}
