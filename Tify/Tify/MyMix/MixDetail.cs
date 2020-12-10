using GetData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class MixDetail : Form
    {


        public MixDetail()
        {
            InitializeComponent();







            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;

        }

        MyMix myMix;
        public MixDetail(MyMix callform)
        {
            InitializeComponent();


            myMix = callform;




            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;

        }

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
  
       

      

        
        public void SetDetailInfo(List<TrackInfo> trackInfos,Image cover)
        {
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)track_dataGridView.Rows[0].Clone();
                tempRow.Visible = true;

                tempRow.Cells[0].Value = track.Title;
                tempRow.Cells[1].Value = track.Artist;
                tempRow.Cells[2].Value = track.Time;
                tempRow.Cells[3].Value = Properties.Resources.add;
                tempRow.Cells[4].Value = Properties.Resources.like;
                rows.Add(tempRow);
            }
            track_dataGridView.Rows.Clear();
            track_dataGridView.Rows.AddRange(rows.ToArray());
            cover_pictureBox.Image = cover;
            myMix.openChildForm(this);
        }
    }
}
