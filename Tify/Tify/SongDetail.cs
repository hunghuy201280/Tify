using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Tify
{
    public partial class SongDetail : Form
    {
        public SongDetail()
        {
            InitializeComponent();
          
        }
        private MainScreen mainscr;
        private WindowsMediaPlayer soundPlayer;
        private Panel songDetail_panel;
        public SongDetail(MainScreen callForm)
        {
           
           
            InitializeComponent();
            mainscr = callForm;
            songDetail_panel = mainscr.getSongDetailPanel();
        }

        private void songDetailMinimize_button_Click(object sender, EventArgs e)
        {
            songDetail_panel.SendToBack();

        }
    }
}
