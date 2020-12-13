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
    public partial class PlaylistDetail : Form
    {
        public PlaylistDetail()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private Playlist playlistForm;
        public PlaylistDetail(Playlist callFm)
        {
            InitializeComponent();

            playlistForm = callFm;
            
            
            
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        public void setDetailInfo(List<TrackInfo> trackInfos, Image[] cover, bool open, PlaylistContainer callFm)
        {
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
                    tempRow.Cells[4].Value = Properties.Resources.liked;
                }
                else
                {
                    tempRow.Cells[4].Value = Properties.Resources.like;
                }
                rows.Add(tempRow);
            }
            
            track_dataGridView.Rows.AddRange(rows.ToArray());
            for (int i = 0; i < playlistCover_pictureBox.Controls.Count; i++)
            {
                PictureBox tempPb = playlistCover_pictureBox.Controls[i] as PictureBox;
                tempPb.Image = cover[i];
            }
            createdBy_label.Text="Created by "+callFm.owner + " - "+trackInfos.Count+" Tracks";
            //Created by me - 10 Tracks - 1:24:00
     

            if (open)
                playlistForm.openChildForm(this);
        }



        #region enter,leave row

        private void trackGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
            if (track_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(19, 19, 20))
            {
                return;
            }
            foreach (DataGridViewCell cell in track_dataGridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.FromArgb(19, 19, 20);
            }
        }

        private void trackGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
            if (track_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
            {
                return;
            }
            foreach (DataGridViewCell cell in track_dataGridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.Black;
            }
        }

        #endregion enter,leave row
    }
}
