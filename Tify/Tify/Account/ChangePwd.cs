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
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
        }
        MainScreen mainscr;
        public ChangePwd(MainScreen input)
        {
            InitializeComponent();
            mainscr = input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Database.checkPassword(mainscr.CurrentUser.UserID.ToString(),textBox_oldPwd.Text))
            {
                textBox_oldPwd.Clear();
                MessageBox.Show("Wrong password, please try again !");
                return;
            }
            if (!String.IsNullOrEmpty(textBox_newpwd.Text) && !String.IsNullOrEmpty(textBox_oldPwd.Text) && !String.IsNullOrEmpty(textBox_retypenewpwd.Text))
            {
                if (textBox_oldPwd.Text == textBox_newpwd.Text)
                {
                    MessageBox.Show("They are the same, you sure you want to change your password ?");
                    return;
                }
               

                if (textBox_retypenewpwd.Text == textBox_newpwd.Text /*&& nhet cai ham vo*/)
                {
                    Database.updatePassword(mainscr.CurrentUser.UserID, textBox_retypenewpwd.Text);
                    MessageBox.Show("Done. They will know nothing about this.");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Oops ,seem that your password didn't match,may be give it a check?");
                }
                
                    
            }
            else
            {
                MessageBox.Show("Password cannot be blank, try again ?");
            }
        }
    }
}
