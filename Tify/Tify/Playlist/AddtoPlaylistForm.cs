using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Tify
{
    public partial class AddtoPlaylistForm : Form
    {
        private SqlConnection sqlcon;
        private MainScreen mainScr;
        private CreatePlayList CreatePL;
        private string trackID;

        public AddtoPlaylistForm()
        {
            InitializeComponent();

            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        public AddtoPlaylistForm(MainScreen callForm, string trackid)
        {
            InitializeComponent();
            mainScr = callForm;
            trackID = trackid;
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        private void AddtoPlaylistForm_Load(object sender, EventArgs e)
        {
            loadPlaylist_InFlowPanel();
        }

        public void loadPlaylist_InFlowPanel()
        {
            flowLayoutPanel_showPL.Controls.Clear();
            sqlcon.Open();
            using (SqlCommand command = new SqlCommand("select playlistTitle,userID  from Playlist,UserHasPlaylist where Playlist.playlistID=UserHasPlaylist.playlistID and userID =" + mainScr.CurrentUser.UserID + "", sqlcon))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Button newbutton = new Button();
                            newbutton.Width = 233;
                            newbutton.Height = 45;
                            newbutton.BackColor = Color.FromArgb(36, 37, 40);
                            newbutton.ForeColor = Color.White;
                            newbutton.FlatStyle = FlatStyle.Flat;

                            newbutton.FlatAppearance.BorderSize = 0;
                            newbutton.Font = new Font("Nationale Light", 12);
                            newbutton.TextAlign = ContentAlignment.MiddleLeft;
                            newbutton.Text = reader[0].ToString();
                            newbutton.Click += Newbutton_Click;
                            flowLayoutPanel_showPL.FlowDirection = FlowDirection.TopDown;
                            hideScrollBar(flowLayoutPanel_showPL);

                            flowLayoutPanel_showPL.Controls.Add(newbutton);
                        }
                    }
                    else MessageBox.Show("No playlist found");
                }
            }
            sqlcon.Close();
        }

        //get choosenPL, playlist that clicked

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string choosenPL = button.Text;
            playlistchoseevent(choosenPL, trackID);
            this.Close();
        }

        //convert string choosenPL to ID
        private string choosenPLID;

        private void convert(string input)
        {
            sqlcon.Open();
            using (SqlCommand command = new SqlCommand("select playlistTitle,Playlist.playlistID,userID  from Playlist,UserHasPlaylist where Playlist.playlistID=UserHasPlaylist.playlistID and userID =" + mainScr.CurrentUser.UserID + "", sqlcon))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (input.Trim() == reader[0].ToString())
                                choosenPLID = reader[1].ToString();
                        }
                    }
                }
            }
        }

        static public void hideScrollBar(Control needHide)
        {
            {
                FlowLayoutPanel flowpanel = needHide as FlowLayoutPanel;
                flowpanel.AutoScroll = false;
                flowpanel.HorizontalScroll.Maximum = 0;
                flowpanel.AutoScroll = false;
                flowpanel.VerticalScroll.Visible = false;

                flowpanel.VerticalScroll.Maximum = 0;
                flowpanel.AutoScroll = false;
                flowpanel.HorizontalScroll.Visible = false;
                flowpanel.AutoScroll = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_createnewPL_Click(object sender, EventArgs e)
        {
            CreatePL = new CreatePlayList(mainScr, this);
            CreatePL.ShowDialog();
        }

        //add to playlist event

        private void playlistchoseevent(string input, string trackID)
        {
            convert(input);
            try
            {
                Database.AddTrackToPlaylist(trackID, choosenPLID);
                //add row to playlist
                mainScr.playlistScr.addTrackToPlaylistContainer(trackID, choosenPLID);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    //Violation of primary key. Handle Exception
                    MessageBox.Show("This track already exist in this playlist");
                }
                else throw;
            }

           
        }
    }
}