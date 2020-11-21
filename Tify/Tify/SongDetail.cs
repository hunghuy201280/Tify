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
        public SongDetail(MainScreen callForm, WindowsMediaPlayer player)
        {
            mainscr = callForm;
            
            InitializeComponent();
            
        }

        private void songDetailMinimize_button_Click(object sender, EventArgs e)
        {
            mainscr.Controls["songDetail_panel"].SendToBack();

        }
       
        
    }
}
