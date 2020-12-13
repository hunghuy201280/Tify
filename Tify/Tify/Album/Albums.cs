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
        public Albums()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private MainScreen mainScr;

        SqlConnection connection;

        
        private DataTable AlbumTable = new DataTable();
        public Albums(MainScreen callform)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            mainScr = callform;
            //Get user has mix table
            AlbumTable = Database.getMyMixTableInMyMix(mainScr.CurrentUser.UserID);
            albumDetail = new AlbumDetail(this);

            firstLoadChildForm();

            // initialize container and mixdetail
            for (int i = 0; i < mixTable.Rows.Count; i++)
            {
                mixContainers.Add(new MyMixContainer(this, mixTable.Rows[i]["myMixID"].ToString(), mixDetail));
            }
            mix_Flowpanel.Controls.AddRange(mixContainers.ToArray());


            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }


        }

        private List<MyMixContainer> mixContainers = new List<MyMixContainer>();
        private MixDetail mixDetail;


        public void reloadMixContainer(string MIXID)
        {
            foreach (MyMixContainer container in mixContainers)
            {
                if (container.mixID == MIXID)
                {
                    container.reloadStatus();
                    break;
                }
            }
        }

        public Albums(MainScreen callFm)
        {
            InitializeComponent();


            mainScr = callFm;


            firstLoadChildForm();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
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
