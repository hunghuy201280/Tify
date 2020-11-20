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
    public partial class MyMix : Form
    {
        public MyMix()
        {
            InitializeComponent();
            
        }
         bool Mixed ;

        public MyMix(bool hasMix)
        {
            Mixed = hasMix;

            InitializeComponent();

        }

        private void MyMix_Load(object sender, EventArgs e)
        {

            MyMix_GroupBox.Visible = true;




        }


       
        private void groupBox1_Resize(object sender, EventArgs e)
        {

            MyMix_GroupBox.Width = this.Width - 12;
            MyMix_GroupBox.Height = this.Height - 12;
        }
    }
}
