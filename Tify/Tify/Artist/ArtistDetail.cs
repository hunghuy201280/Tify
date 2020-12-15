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






            track_worker.RunWorkerAsync();

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

        /*public void setDetailInfo(List<TrackInfo> trackInfos, Image[] cover, bool open, PlaylistContainer callFm)
        {
            this.trackInfo = trackInfos;
            playlistContainer = callFm;
            int indexCount = 1;
            track_dataGridView.Rows.Clear();
            track_dataGridView.Rows.Add();
            track_dataGridView.Rows[0].Visible = false;
            rows.Clear();
            foreach (TrackInfo track in trackInfos)
            {
                DataGridViewRow tempRow = (DataGridViewRow)track_dataGridView.Rows[0].Clone();
                tempRow.Visible = true;
                tempRow.Tag = track;
                tempRow.Cells[0].Value = indexCount++;
                tempRow.Cells[1].Value = track.Title;
                tempRow.Cells[2].Value = track.Artist;
                tempRow.Cells[3].Value = track.DateAdded;
                tempRow.Cells[4].Value = track.Time;
                tempRow.Cells[5].Value = Properties.Resources.add;
                if (track.IsLoved)
                {
                    tempRow.Cells[6].Value = Properties.Resources.liked;
                }
                else
                {
                    tempRow.Cells[6].Value = Properties.Resources.like;
                }
                rows.Add(tempRow);
            }

            track_dataGridView.Rows.AddRange(rows.ToArray());

            for (int i = 0; i < playlistCover_pictureBox.Controls.Count; i++)
            {
                try
                {
                    PictureBox tempPb = playlistCover_pictureBox.Controls[i] as PictureBox;
                    tempPb.Image = cover[i];
                }
                catch (Exception)
                {
                }
            }

            description_label.Text = callFm.description;
            playlistTitle_label.Text = callFm.playlistName;
            createdBy_label.Text = "Created by " + callFm.owner + " - " + trackInfos.Count + " Tracks";
            //Created by me - 10 Tracks - 1:24:00

            if (open)
                playlistForm.openChildForm(this);
            track_dataGridView.Rows.Remove(track_dataGridView.Rows[0]);
        }*/

    }
}
