using System;
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

        private MainScreen mainScr;

        private PlaylistContainer test;
        public Playlist(MainScreen callForm)
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
            mainScr = callForm;
           
            test = new PlaylistContainer(this);
            bottom_flowPanel.Controls.Add(test);
            firstLoadChildForm();
        }

        #region Mở childForm

      
        private PlaylistDetail playlistDetail;
        private void firstLoadChildForm()
        {
            playlistDetail = new PlaylistDetail();
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
                mainScr.activeForm.SendToBack();
            }

            mainScr.activeForm = childForm;

            childForm.BringToFront();
        }

        #endregion Mở childForm

        public void opacity_panel_Click(object sender, EventArgs e)
        {
            openChildForm(playlistDetail);
        }
    }
}