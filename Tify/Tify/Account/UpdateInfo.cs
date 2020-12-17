using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }
        MainScreen mainscr;
        public UpdateInfo(MainScreen input)
        {
            InitializeComponent();
             mainscr=input;
          
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {


        }


        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_Phone.MaxLength = 10;
           
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }


        
        private void button_save_Click(object sender, EventArgs e)
        {
            int myAge =DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (myAge<=6)
            {
                MessageBox.Show("Wrong age");
                return;
            }
            else
            {
                string theDate = dateTimePicker1.Value.ToShortDateString();
                Database.updateDOB(mainscr.CurrentUser.UserID, theDate);
            }
            if (String.IsNullOrEmpty(textbox_name.Text) && String.IsNullOrEmpty(textBox_Phone.Text) && String.IsNullOrEmpty(textBox_pwd.Text))
            {
                MessageBox.Show("Notthing to save.");
            }
            else
            {
                if (!String.IsNullOrEmpty(textbox_name.Text))
                {
                    Database.updateName(mainscr.CurrentUser.UserID, textbox_name.Text);
                }
                if (!String.IsNullOrEmpty(textBox_Phone.Text))
                {
                    Database.updatePhone(mainscr.CurrentUser.UserID, textBox_Phone.Text);
                }
               
                if (!String.IsNullOrEmpty(textBox_pwd.Text))
                {
                    if (textBox_retypepwd.Text == textBox_pwd.Text)
                    {
                        Database.updatePassword(mainscr.CurrentUser.UserID, textBox_retypepwd.Text);
                    }
                    else
                        MessageBox.Show("Oops ,seem that your password didnt match,may be give it a check?");

                }
            }
            

        }

        private void UpdateInfo_Resize(object sender, EventArgs e)
        {
            panel6.Location = new Point(this.ClientSize.Width / 2 - panel6.Size.Width / 2,this.ClientSize.Height / 2 - panel6.Size.Height / 2);
            panel6.Anchor = AnchorStyles.None;
        }
    }
}
