using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Tify
{
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
            panel_default_playlist.Location = new Point(
           this.ClientSize.Width / 2 - panel_default_playlist.Size.Width / 2,
           this.ClientSize.Height / 2 - panel_default_playlist.Size.Height / 2);
            panel_default_playlist.Anchor = AnchorStyles.None;
            /*panel_default_playlist.BringToFront();*/
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }

        public MainScreen mainScr;

        private PlaylistContainer test;
        private DataTable playlistTable = new DataTable();
        private List<PlaylistContainer> playlistContainers = new List<PlaylistContainer>();
        public Playlist(MainScreen callForm)
        {
            InitializeComponent();
            panel_default_playlist.Location = new Point(
           this.ClientSize.Width / 2 - panel_default_playlist.Size.Width / 2,
           this.ClientSize.Height / 2 - panel_default_playlist.Size.Height / 2);
            panel_default_playlist.Anchor = AnchorStyles.None;
            /*panel_default_playlist.BringToFront();*/
           
            mainScr = callForm;

            //get user has playlist table
            playlistTable = Database.getPlaylistTable_Playlist(mainScr.CurrentUser.UserID);
            playlistDetail = new PlaylistDetail(this);



            firstLoadChildForm();
           
            for (int i = 0; i < playlistTable.Rows.Count; i++)
            {
                playlistContainers.Add(new PlaylistContainer(this, playlistTable.Rows[i]["playlistID"].ToString()));
            }
            bottom_flowPanel.Controls.AddRange(playlistContainers.ToArray());

            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        #region reload after delete in loved tracks
        public void reloadPlaylistContainer(/*string PLAYLISTID*/)
        {
            foreach (var container in playlistContainers)
            {
              /*  if (container.playlistID == PLAYLISTID)
                {*/
                    container.reloadStatus();
               /*     break;
                }*/
            }
        }
        #endregion

        #region addrow to playlist 

        public void addTrackToPlaylistContainer(string trackID,string playlistID)
        {
            foreach (var playlist in playlistContainers)
            {
                if (playlist.playlistID== playlistID)
                {
                    playlist.addTrack(trackID);
                }
            }
        }

        #endregion


        #region Mở childForm




        public PlaylistDetail playlistDetail;
        private void firstLoadChildForm()
        {
            playlistDetail.TopLevel = false;
            playlistDetail.FormBorderStyle = FormBorderStyle.None;
            playlistDetail.Dock = DockStyle.Fill;
            mainScr.childForm_panel.Controls.Add(playlistDetail);
            playlistDetail.Show();
        }

        public void openChildForm(Form childForm)
        {
            if (mainScr.activeForm != null)
            {
                if (mainScr.activeForm == childForm)
                    return;
            }

            mainScr.activeForm = childForm;

            childForm.BringToFront();
        }

        #endregion Mở childForm

        
    }
}