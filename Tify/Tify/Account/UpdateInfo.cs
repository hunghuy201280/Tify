using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Tify
{
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private MainScreen mainscr;

        public UpdateInfo(MainScreen input)
        {
            InitializeComponent();
            mainscr = input;
        }

        private string getdob()
        {
            string[] dob = mainscr.CurrentUser.Dob.Split(' ');
            string finaldob = dob[0];
            finaldob = Convert.ToDateTime(finaldob).ToString("dd/MM/yyyy");
            MessageBox.Show(finaldob);
            return finaldob;
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            textbox_name.Text = mainscr.CurrentUser.Name;
            textBox_Phone.Text = mainscr.CurrentUser.Phone;

            dateTimePicker1.Value = DateTime.Parse(getdob());
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
            bool changedAge = false;
            string Name = "";
            string Phone = "";
            string DOB = "";
            string Pwd = "";
            int myAge = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (myAge <= 6)
            {
                MessageBox.Show("Wrong age");
                return;
            }
            else
            {
                string theDate = dateTimePicker1.Value.ToShortDateString();
                Database.updateDOB(mainscr.CurrentUser.UserID, theDate);

                changedAge = true;
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
                    Name = "name";
                }
                if (!String.IsNullOrEmpty(textBox_Phone.Text))
                {
                    Database.updatePhone(mainscr.CurrentUser.UserID, textBox_Phone.Text);
                    Phone = ", phone";
                }

                if (!String.IsNullOrEmpty(textBox_pwd.Text))
                {
                    if (textBox_retypepwd.Text == textBox_pwd.Text)
                    {
                        Database.updatePassword(mainscr.CurrentUser.UserID, textBox_retypepwd.Text);
                        Pwd = ", pass word";
                    }
                    else
                        MessageBox.Show("Oops ,seem that your password didnt match,may be give it a check?");
                }
                if (changedAge == true)
                    DOB = ", date of birth";
                MessageBox.Show("Changed " + Name + Phone + DOB + Phone + Pwd + " succesfully");
            }
        }

        private void UpdateInfo_Resize(object sender, EventArgs e)
        {
            panel6.Location = new Point(this.ClientSize.Width / 2 - panel6.Size.Width / 2, this.ClientSize.Height / 2 - panel6.Size.Height / 2);
            panel6.Anchor = AnchorStyles.None;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            /* Environment.Exit(0);*/
        }
    }
}