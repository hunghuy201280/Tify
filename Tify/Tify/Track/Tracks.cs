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
    public partial class Tracks : Form
    {
        public Tracks()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            //
            container.Artist = "Yorushika";
            container.Time = "4:02";
            container.DateAdded = "29/11/2020";

            addTrack(new trackContainer());
            
        }
        trackContainer container = new trackContainer();
        
        public void addTrack(trackContainer track)
        { 
            //0=hinh+title,1=artist,2=date,3=time

            //thay container=track , container la demo
            track_tableLayoutPanel.RowCount = track_tableLayoutPanel.RowCount + 1;
            track_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
            track_tableLayoutPanel.Controls.Add(new trackContainer(), 0, track_tableLayoutPanel.RowCount - 1);
            track_tableLayoutPanel.Controls.Add(new Label() { Font =format_label.Font , Text = container.Artist, ForeColor = Color.White, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }
            , 1, track_tableLayoutPanel.RowCount - 1);
            track_tableLayoutPanel.Controls.Add(new Label() { Font = format_label.Font, Text = container.DateAdded, ForeColor = Color.White, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }
          , 2, track_tableLayoutPanel.RowCount - 1);
            track_tableLayoutPanel.Controls.Add(new Label() { Font = format_label.Font, Text = container.Time, ForeColor = Color.White, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }
          , 3, track_tableLayoutPanel.RowCount - 1);


        }
        private void button1_Click(object sender, EventArgs e)
        {

            addTrack(new trackContainer());
        }
    }
}
