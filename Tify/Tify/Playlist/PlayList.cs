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
                playlistContainers.Add(new PlaylistContainer(this, playlistTable.Rows[i]["playlistID"].ToString(),true));
            }
            bottom_flowPanel.Controls.AddRange(playlistContainers.ToArray());
            if (playlistContainers.Count==0)
            {
                panel_default_playlist.BringToFront();
            }
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        #region reload when create new playlist
        public void reload_createNew()
        {
            playlistTable = Database.getPlaylistTable_Playlist(mainScr.CurrentUser.UserID);

            playlistContainers.Clear();
            bottom_flowPanel.Controls.Clear();

            for (int i = 0; i < playlistTable.Rows.Count; i++)
            {
                playlistContainers.Add(new PlaylistContainer(this, playlistTable.Rows[i]["playlistID"].ToString(),true));
            }
            bottom_flowPanel.Controls.AddRange(playlistContainers.ToArray());
            attachPlaylistContainerToPlaylistButtonInMenuPanel(mainScr.PlayList_FlowPanel);

            if (playlistContainers.Count == 0)
            {
                panel_default_playlist.BringToFront();
            }
            else
            {
                panel_default_playlist.SendToBack();
            }
        }
        #endregion

        #region reload after add or delete in loved tracks
        public void reloadPlaylistContainer()
        {
            foreach (var container in playlistContainers)
            {
                    container.reloadStatus();
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
        public void addTrackToPlaylistContainer(List<TrackInfo> tracks, string playlistID)
        {
            foreach (var playlist in playlistContainers)
            {
                if (playlist.playlistID == playlistID)
                {
                    playlist.addTrack(tracks);
                }
            }
        }

        #endregion


        #region Mở childForm

        public void attachPlaylistContainerToPlaylistButtonInMenuPanel(FlowLayoutPanel playlist_panel)
        {
            int countButton = playlist_panel.Controls.Count;
            for (int i = 0; i < countButton; i++)
            {
                Button button = playlist_panel.Controls[i] as Button;
                button.Tag = playlistContainers[i];
            }
        }


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
            mainScr.openChildForm(childForm);
        }

        #endregion Mở childForm


    }
}