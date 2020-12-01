using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class trackContainer : UserControl
    {
        public trackContainer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }
        private string title;
        private string artist;
        private string dateAdded;
        private string time;

        public string Artist { get => artist; set => artist = value; }
        public string DateAdded { get => dateAdded; set => dateAdded = value; }
        public string Time { get => time; set => time = value; }
        public string Title { get => title; set => title = value; }

        //hover
        private void Cover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }
    }
}
