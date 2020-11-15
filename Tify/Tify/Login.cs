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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Login_Panel.Location = new Point(
            this.ClientSize.Width / 2 - Login_Panel.Size.Width / 2,
            this.ClientSize.Height / 2 - Login_Panel.Size.Height / 2);
            Login_Panel.Anchor = AnchorStyles.None;

        }

       
    }
}
