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
    public partial class Loading : Form
    {

        public Loading()
        {
            InitializeComponent();
        }

        public void changePic()
        {
            loading_pictureBox.Image = Properties.Resources.finish_load;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
