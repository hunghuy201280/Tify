using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Tify
{
    public partial class MyMixContainer : UserControl
    {
        public MyMixContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }

        public MyMixContainer(MyMix callform)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            opacity_panel.Click += callform.opacity_panel_Click;
        }
        public string mixID;
        SqlConnection connection;
        DataTable mixTable = new DataTable();
        private MyMix mixForm;
        public int index = 1;//row index

        public MyMixContainer(MyMix callform,string id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            mixForm = callform;
            mixID = id;
            connection.Open();
            cover_worker.RunWorkerAsync();
            artist_worker.RunWorkerAsync();
            

          



            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            opacity_panel.Click += callform.opacity_panel_Click;
        }

        

        private void myMixCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        private void MyMixContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }
        DataTable artistTable = new DataTable();
        private void artist_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string query= "select distinct artistName from  " +
                "MyMix join MyMixHasTrack on MyMix.myMixID = MyMixHasTrack.myMixID " +
                "join Track on Track.trackID = MyMixHasTrack.trackID " +
                "join ArtistHasTrack on Track.trackID = ArtistHasTrack.trackID " +
                "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
                "where MyMix.myMixID = @id; ";

            artist_label.Text = "";
            //connection.Open();
            using (SqlCommand cmd = new SqlCommand(query,connection))
            {
                cmd.Parameters.AddWithValue("@id", mixID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTable.Load(reader);
                }
            }
            //connection.Close();
          

        }

        private void artist_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error !=null)
            {
                MessageBox.Show(e.Error.Message + "My mix container, artist");
                return;
            }
            int maximum = 30;//max char in artist label
            foreach (DataRow row in artistTable.Rows)
            {
                if ((artist_label.Text + row["artistName"].ToString()).Length > 30)
                {
                    artist_label.Text += " and more...";
                    break;
                }
                else
                {
                    artist_label.Text += row["artistName"].ToString() + ", ";
                }
            }
        }

        private void cover_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //connection.Open();
            using (SqlCommand cmd = new SqlCommand("select * from UserHasMix where userID=@userid order by myMixID asc ",connection))
            {
                cmd.Parameters.AddWithValue("@userid", mixForm.mainScr.CurrentUser.UserID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    mixTable.Load(reader);
                }
            }
            //connection.Close();

            for (int i = 0; i < mixTable.Rows.Count; i++)
            {
                if (mixTable.Rows[i]["myMixID"].ToString() == mixID)
                {
                    index = i + 1;
                    break;
                }
            }
            opacity_panel.Tag = index - 1;
        }

        private void cover_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + "My mix container, cover");
                return;
            }
            switch (index)
            {
                case 1:
                    myMixCover_panel.BackgroundImage = Properties.Resources.mymix1;
                    break;
                case 2:
                    myMixCover_panel.BackgroundImage = Properties.Resources.mymix2;
                    break;
                case 3:
                    myMixCover_panel.BackgroundImage = Properties.Resources.mymix3;
                    break;
                case 4:
                    myMixCover_panel.BackgroundImage = Properties.Resources.mymix4;
                    break;
                default:
                    break;
            }
            playlistName_label.Text = "My Mix " + index;

        }
    }
}
