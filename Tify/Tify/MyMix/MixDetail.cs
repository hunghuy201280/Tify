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
                tempRow.Tag = track;
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


        //datagridview Event
    
       
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

        //play
        private void track_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TrackInfo trackToPlay = track_dataGridView.Rows[e.RowIndex].Tag as TrackInfo;
           myMix.mainScr.changeSong(trackToPlay.TrackLink);

        }

        #region play button
        private void play_button_Click(object sender, EventArgs e)
        {
            myMix.mainScr.nextTrack.Clear();
            foreach (DataGridViewRow track in track_dataGridView.Rows)
            {
                
                TrackInfo trackToPlay = track.Tag as TrackInfo;
                myMix.mainScr.addTrackToQueue(trackToPlay.TrackLink);
              
            }
            myMix.mainScr.changeSong(myMix.mainScr.nextTrack.Dequeue() as string);
        }
        #endregion

        #region shuffle button
        private void playShuffle_Button_Click(object sender, EventArgs e)
        {
            myMix.mainScr.nextTrack.Clear();
            Random rnd = new Random(DateTime.Now.Second);
            int numOfTracks = track_dataGridView.Rows.Count;
           
            
            List<int> numbers = new List<int>();
            for (int i = 0; i < numOfTracks; i++)
            {
                int num = rnd.Next(0, numOfTracks );
                while (numbers.Contains(num))
                {
                    num = rnd.Next(0, numOfTracks );
                }
                numbers.Add(num);
                TrackInfo trackToPlay = track_dataGridView.Rows[num].Tag as TrackInfo;
                myMix.mainScr.addTrackToQueue(trackToPlay.TrackLink);
            }
            myMix.mainScr.changeSong(myMix.mainScr.nextTrack.Dequeue() as string);
        }
        #endregion 
    }
}
