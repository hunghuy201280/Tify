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
           
            //panel new
            panel_MyMix.Location = new Point(
            this.ClientSize.Width / 2 - panel_MyMix.Size.Width / 2,
            this.ClientSize.Height / 2 - panel_MyMix.Size.Height / 2);
            panel_MyMix.Anchor = AnchorStyles.None;
            if (Mixed == true)
            {
                MyMix_GroupBox.Visible = true;
                panel_MyMix.Visible = false;
            }
            else
            {
                MyMix_GroupBox.Visible = false;
                panel_MyMix.Visible = true;
            }




        }


       
        private void groupBox1_Resize(object sender, EventArgs e)
        {

            MyMix_GroupBox.Width = this.Width - 12;
            MyMix_GroupBox.Height = this.Height - 12;
        }
    }
}
