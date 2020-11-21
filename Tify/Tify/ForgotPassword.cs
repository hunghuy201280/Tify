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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            Forgotpwd_panel.Location = new Point(
            this.ClientSize.Width / 2 - Forgotpwd_panel.Size.Width / 2,
            this.ClientSize.Height / 2 - Forgotpwd_panel.Size.Height / 2);
            Forgotpwd_panel.Anchor = AnchorStyles.None;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.MaxLength = 10;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
