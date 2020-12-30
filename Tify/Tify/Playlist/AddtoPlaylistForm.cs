using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Tify
{
    public partial class AddtoPlaylistForm : Form
    {
        private MainScreen mainScr;
        private CreatePlayList CreatePL;
        private string trackID;

        public AddtoPlaylistForm()
        {
            InitializeComponent();
        }

        private bool isnotsingletrack = false;
        List<TrackInfo> tracks;
        public AddtoPlaylistForm(MainScreen callForm, bool input, List<TrackInfo> inputTrack)
        {
            InitializeComponent();
            isnotsingletrack = input;
            mainScr = callForm;
            this.DoubleBuffered = true;
            tracks = inputTrack;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        public AddtoPlaylistForm(MainScreen callForm, string trackid)
        {
            InitializeComponent();
            mainScr = callForm;
            trackID = trackid;
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private void AddtoPlaylistForm_Load(object sender, EventArgs e)
        {
            loadPlaylist_InFlowPanel();
        }

        public void loadPlaylist_InFlowPanel()
        {
            flowLayoutPanel_showPL.Controls.Clear();

            DataTable playlisTable = Database.getPlaylistTable_Playlist(mainScr.CurrentUser.UserID);

            foreach (DataRow playlist in playlisTable.Rows)
            {
                Button newbutton = new Button();
                newbutton.Width = 233;
                newbutton.Height = 45;
                newbutton.BackColor = Color.FromArgb(36, 37, 40);
                newbutton.ForeColor = Color.White;
                newbutton.FlatStyle = FlatStyle.Flat;
                newbutton.Cursor = Cursors.Hand;
                newbutton.FlatAppearance.BorderSize = 0;
                newbutton.Font = new Font("Nationale Light", 12);
                newbutton.TextAlign = ContentAlignment.MiddleLeft;
                newbutton.Text = playlist["playlistTitle"].ToString();
                newbutton.Tag = playlist["playlistID"].ToString();
                newbutton.Click += Newbutton_Click;
                flowLayoutPanel_showPL.FlowDirection = FlowDirection.TopDown;
                hideScrollBar(flowLayoutPanel_showPL);

                flowLayoutPanel_showPL.Controls.Add(newbutton);
            }
        }

        //get choosenPL, playlist that clicked

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //ten playlist
            choosenPlaylistID = button.Tag as string;
            playlistchoseevent(choosenPlaylistID, trackID);
            this.Close();
        }

        //convert string choosenPL to ID
        private string choosenPlaylistID;//ten playlist

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

        //exit button
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
            if (isnotsingletrack == false)
            {
                try
                {
                    Database.AddTrackToPlaylist(trackID, choosenPlaylistID);

                    //add row to playlist

                    mainScr.playlistScr.addTrackToPlaylistContainer(trackID, choosenPlaylistID);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        //Violation of primary key. Handle Exception
                        MessageBox.Show("This track already exist in this playlist");
                    }
                }
            }
            else
            {
                Database.addPlaylistToOtherPlaylist(tracks, choosenPlaylistID);
            }
        }
    }
}