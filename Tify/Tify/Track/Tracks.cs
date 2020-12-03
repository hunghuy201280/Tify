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

            //addTrack(new trackContainer());
            
        }
        trackContainer container = new trackContainer();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Image.FromFile(@"C:\Users\Admin\Downloads\Tailieu\C#\Tify\dummy_music_pic.png"), "Hole in the heart", "Yorushika",
                                    DateTime.Now.Date.ToString(), "3:42", Image.FromFile(@"C:\Users\Admin\Downloads\Tailieu\C#\Tify\dummy_music_pic.png"),
                                    Image.FromFile(@"C:\Users\Admin\Downloads\Tailieu\C#\Tify\dummy_music_pic.png"));
        }

        public void addTrack(trackContainer track)
        {
            


        }

    }
}
