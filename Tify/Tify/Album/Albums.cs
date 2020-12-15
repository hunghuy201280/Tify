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

        public MainScreen mainScr;
        public AlbumDetail albumDetail;
        private DataTable temp = new DataTable();
        private DataTable AlbumTable = new DataTable();
        private List<AlbumContainer> AlbumContainers = new List<AlbumContainer>();
    
        public Albums(MainScreen callform)
        {
            InitializeComponent();




            temp = Database.getAlbumTable_Album(callform.CurrentUser.UserID);
            mainScr = callform;
            
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                AlbumContainers.Add(new AlbumContainer(temp.Rows[i]["albumID"].ToString(), this));
            }
            bottom_flowPanel.Controls.AddRange(AlbumContainers.ToArray());
            firstLoadChildForm();


            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        





        #region Mở childForm


        
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
