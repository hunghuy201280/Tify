﻿using System;
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
        private List<AlbumContainer> AlbumContainers = new List<AlbumContainer>();
        private AlbumDetail AlbumDetail;
        public Albums(MainScreen callform)
        {
            InitializeComponent();


            mainScr = callform;
            //Get user has album
            AlbumTable = Database.getAlbumTable_Album(mainScr.CurrentUser.UserID);
            AlbumDetail = new AlbumDetail(mainScr.CurrentUser.UserID.ToString());
            firstLoadChildForm();

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
