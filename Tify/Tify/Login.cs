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

        

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
            
            Form register = new Register();
            register.ShowDialog();
            

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }


        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;

            
            Form forgotpwd = new ForgotPassword();
            forgotpwd.ShowDialog();


        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

       
    }
    }
