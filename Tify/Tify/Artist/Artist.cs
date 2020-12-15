using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class Artist : Form
    {
        public Artist()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        public MainScreen mainScr;
        DataTable artistsTable = new DataTable();
        public ArtistDetail artistDetail;
        private List<ArtistContainer> artistContainers = new List<ArtistContainer>();
        public Artist(MainScreen mainScreen)
        {
            InitializeComponent();



            mainScr = mainScreen;

            //load artist detail
            artistDetail = new ArtistDetail(this);

            artistDetail.TopLevel = false;
            artistDetail.FormBorderStyle = FormBorderStyle.None;
            artistDetail.Dock = DockStyle.Fill;
            mainScr.childForm_panel.Controls.Add(artistDetail);
            artistDetail.Show();

            //get artist User Follow
            artistsTable = Database.getArtistThatUserFollow(mainScr.CurrentUser.UserID);

            for (int i = 0; i < artistsTable.Rows.Count; i++)
            {
                artistContainers.Add(new ArtistContainer(this, artistsTable.Rows[i]["artistID"].ToString()));
            }
            bottom_flowPanel.Controls.AddRange(artistContainers.ToArray());


            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
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
    }
}
