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

        private void MyMix_Load(object sender, EventArgs e)
        {
           
            //panel new
            panel_MyMix.Location = new Point(
            this.ClientSize.Width / 2 - panel_MyMix.Size.Width / 2,
            this.ClientSize.Height / 2 - panel_MyMix.Size.Height / 2);
            panel_MyMix.Anchor = AnchorStyles.None;

            

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (panel_MyMix.Visible == true)
            {
                groupBox1.Visible = true;
                panel_MyMix.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                panel_MyMix.Visible = true;
            }
          

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {

            groupBox1.Width = this.Width - 12;
            groupBox1.Height = this.Height - 12;
        }
    }
}
