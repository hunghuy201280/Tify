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
        private DataTable albumTable = new DataTable();
        private DataTable AlbumTable = new DataTable();
        private List<AlbumContainer> AlbumContainers = new List<AlbumContainer>();
    
        public Albums(MainScreen callform)
        {
            InitializeComponent();



            // get album id that user like
            albumTable = Database.getAlbumTable_Album(callform.CurrentUser.UserID);
            mainScr = callform;
            albumDetail = new AlbumDetail(this);
            firstLoadChildForm();
            for (int i = 0; i < albumTable.Rows.Count; i++)
            {
                AlbumContainers.Add(new AlbumContainer(albumTable.Rows[i]["albumID"].ToString(), this));
            }
            bottom_flowPanel.Controls.AddRange(AlbumContainers.ToArray());


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

        #region reload when add or delete album
        public void reloadAlbumTab()
        {
            albumTable = Database.getAlbumTable_Album(mainScr.CurrentUser.UserID);

            AlbumContainers.Clear();
            bottom_flowPanel.Controls.Clear();

            for (int i = 0; i < albumTable.Rows.Count; i++)
            {
                AlbumContainers.Add(new AlbumContainer(albumTable.Rows[i]["albumID"].ToString(), this));
            }
            bottom_flowPanel.Controls.AddRange(AlbumContainers.ToArray());
            
        }
        #endregion

    }
}
