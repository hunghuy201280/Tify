using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Tify
{
    public partial class AlbumContainer : UserControl
    {
        SqlConnection sqlcon;
        DataTable temp1 = new DataTable();
        string inputalbumid;
        public AlbumContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_worker.RunWorkerAsync();
        }

        public AlbumContainer(string imgUrl, string title, string artist, string year)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            PictureBox temp = new PictureBox();
            temp.Load(imgUrl);
            albumCover_panel.BackgroundImage = temp.Image;
            albumName_label.Text = title;
            albumArtist_label.Text = artist;
            if (year != "0")
            {
                albumYear_label.Text = year;
            }
            else
            {
                albumYear_label.Text = "Unknown";
            }

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_worker.RunWorkerAsync();
        }
        string albumid1;
        public AlbumContainer(string inputid)
        {
            InitializeComponent();

            albumid1 = inputid;

            track_worker.RunWorkerAsync();


            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_worker.RunWorkerAsync();
        }


        private void AlbumContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void albumCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        private void track_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            temp1 = Database.getTrack_Album(albumid1); 
            
        }
        
        PictureBox PB;
        private void track_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            
                albumName_label.Text = temp1.Rows[0]["albumTitle"].ToString();
                albumYear_label.Text = temp1.Rows[0]["albumYear"].ToString();
                PB.Load(GetData.GetSongData.GetSongCover(temp1.Rows[0]["albumLink"].ToString()));
                albumCover_panel.BackgroundImage = PB.Image;
                MessageBox.Show("1");
                if (temp1.Rows[0]["albumTitle"].ToString() == null)
                {
                    albumArtist_label.Text = "unknown";
                }
                else
                    albumArtist_label.Text = temp1.Rows[0]["artistname"].ToString();



            
        }

        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
