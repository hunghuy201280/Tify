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
    public partial class ArtistDetail : Form
    {
        public ArtistDetail()
        {
            InitializeComponent();


           

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        public ArtistDetail(Artist artistFm)
        {
            InitializeComponent();


            artistForm = artistFm;



        

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        private Artist artistForm;
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        public void setDetailInfo(List<TrackInfo> trackInfos, ArtistContainer callFm)
        {
            this.trackInfos = trackInfos;
        
            track_gridView.Rows.Clear();
            track_gridView.Rows.Add();
            track_gridView.Rows[0].Visible = false;
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)track_gridView.Rows[0].Clone();
                tempRow.Visible = true;
                tempRow.Tag = track;
                tempRow.Cells[0].Value = track.Cover;
                tempRow.Cells[1].Value = track.Title;
                tempRow.Cells[2].Value = track.Artist;
                tempRow.Cells[3].Value = track.Time;
                tempRow.Cells[4].Value = Properties.Resources.add;
                if (track.IsLoved)
                {
                    tempRow.Cells[5].Value = Properties.Resources.liked;
                }
                else
                {
                    tempRow.Cells[5].Value = Properties.Resources.like;
                }
                rows.Add(tempRow);
            }

            track_gridView.Rows.AddRange(rows.ToArray());


            artistName_label.Text = callFm.artistName_Label.Text;
            cover_pictureBox.Image = callFm.artistCover_panel.BackgroundImage;
           
        

            artistForm.openChildForm(this);
            track_gridView.Rows.Remove(track_gridView.Rows[0]);
        }

    }
}
