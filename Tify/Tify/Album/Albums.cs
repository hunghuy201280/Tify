using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Tify
{
    public partial class Albums : Form
    {
        SqlConnection sqlcon;
        public Albums()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        private MainScreen mainScr;

        private DataTable temp = new DataTable();
        private DataTable AlbumTable = new DataTable();
        private List<AlbumContainer> AlbumContainers = new List<AlbumContainer>();
        private AlbumDetail AlbumDetail;
        public Albums(MainScreen callform)
        {
            InitializeComponent();


            mainScr = callform;
            
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                AlbumContainers.Add(new AlbumContainer(mainScr.CurrentUser.UserID.ToString()));
            }
            bottom_flowPanel.Controls.AddRange(AlbumContainers.ToArray());

        }

        





        #region Mở childForm


        private AlbumDetail albumDetail;
        private void firstLoadChildForm()
        {
            //change album ID here
            albumDetail = new AlbumDetail(25.ToString());
            albumDetail.TopLevel = false;
            albumDetail.FormBorderStyle = FormBorderStyle.None;
            albumDetail.Dock = DockStyle.Fill;
            mainScr.childForm_panel.Controls.Add(albumDetail);
            albumDetail.Show();
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

        public void opacity_panel_Click(object sender, EventArgs e)
        {
            openChildForm(albumDetail);
        }

    }
}
