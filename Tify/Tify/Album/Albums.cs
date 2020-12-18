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



            // get album id that user like
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





        #region reload after delete or add in loved tracks
        public void reloadAlbumContainer()
        {
            foreach (var container in AlbumContainers)
            {
                container.reloadStatus();
            }
        }
        #endregion


        #region Mở childForm



        private void firstLoadChildForm()
        {
        
            albumDetail = new AlbumDetail(this);
            albumDetail.TopLevel = false;
            albumDetail.FormBorderStyle = FormBorderStyle.None;
            albumDetail.Dock = DockStyle.Fill;
            mainScr.childForm_panel.Controls.Add(albumDetail);
            albumDetail.Show();
        }

        public void openChildForm(Form childForm)
        {
            mainScr.openChildForm(childForm);
        }

        #endregion Mở childForm

       

    }
}
