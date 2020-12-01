﻿
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
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
            panel_default_playlist.Location = new Point(
           this.ClientSize.Width / 2 - panel_default_playlist.Size.Width / 2,
           this.ClientSize.Height / 2 - panel_default_playlist.Size.Height / 2);
            panel_default_playlist.Anchor = AnchorStyles.None;
            /*panel_default_playlist.BringToFront();*/
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        
    }
}