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

            //
            container.Artist = "Yorushika";
            container.Time = "4:02";
            container.DateAdded = "29/11/2020";

            //addTrack(new trackContainer());
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);


            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }
        trackContainer container = new trackContainer();

       
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private DataTable trackTable=new DataTable();
        public void loadTrack(string trackID)
        {
            string sqlQuery = "Select * from Track where trackID=@id";
            connection.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", trackID);
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
                    DataGridViewRow temp = dataGridView1.RowTemplate;
                    using (PictureBox pb=new PictureBox())
                    {
                        pb.Load(GetSongData.GetSongCover(trackTable.Rows[0]["trackLink"].ToString()));
                        temp.Cells[0].Value = pb.Image;
                    }
                    rows.Add(temp);
                    
                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            connection.Close();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*  dataGridView1.Rows.Add(Image.FromFile(@"C:\Users\Admin\Downloads\Tailieu\C#\Tify\dummy_music_pic.png"), "Hole in the heart", "Yorushika",
                                      DateTime.Now.Date.ToString(), "3:42", Image.FromFile(@"C:\Users\Admin\Downloads\Tailieu\C#\Tify\dummy_music_pic.png"),
                                      Image.FromFile(@"C:\Users\Admin\Downloads\Tailieu\C#\Tify\dummy_music_pic.png"));*/
            loadTrack(textBox1.Text);
            dataGridView1.Rows.AddRange(rows.ToArray());
        }

        public void addTrack(trackContainer track)
        {
            


        }

    }
}
