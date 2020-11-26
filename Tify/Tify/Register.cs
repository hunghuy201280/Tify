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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Register_Panel.Location = new Point(
            this.ClientSize.Width / 2 - Register_Panel.Size.Width / 2,
            this.ClientSize.Height / 2 - Register_Panel.Size.Height / 2);
            Register_Panel.Anchor = AnchorStyles.None;
        }
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.MaxLength = 10;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            

          
        }

        
    }
}
