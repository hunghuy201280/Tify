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
            //set year
            textBox_year.GotFocus += TextBox_year_GotFocus;
            textBox_year.LostFocus += TextBox_year_LostFocus;
            textBox_year.Text = "Year";

            //set month
            textBox_month.GotFocus += TextBox_month_GotFocus;
            textBox_month.LostFocus += TextBox_month_LostFocus;
            textBox_month.Text = "Month";

            //set days
            textBox_days.GotFocus += TextBox_days_GotFocus;
            textBox_days.LostFocus += TextBox_days_LostFocus;
            textBox_days.Text = "Day";

            //nhap nam r moi nhap thang r moi nhap ngay
            textBox_month.Enabled = false;
            textBox_days.Enabled = false;

            



        }

    
        private void TextBox_days_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_days.Text))
            {
                textBox_days.Text = "Day";



            }
            else
            {
                if (int.Parse(textBox_days.Text) >= DateTime.DaysInMonth(int.Parse(textBox_year.Text),int.Parse(textBox_month.Text)))
                {
                    textBox_days.Text = "1";
                }

            }
        }

        private void TextBox_days_GotFocus(object sender, EventArgs e)
        {
            if (textBox_days.Text == "Day")
                textBox_days.Text = "";
        }

        private void TextBox_month_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_month.Text))
            {
                textBox_month.Text = "Month";

                

            }
            else
            {
                if (int.Parse(textBox_month.Text) > 12)
                {
                    textBox_month.Text = "1";
                    
                }
                textBox_days.Enabled = true;

            }
        }

        private void TextBox_month_GotFocus(object sender, EventArgs e)
        {
            if (textBox_month.Text == "Month")
                textBox_month.Text = "";
        }

        private void TextBox_year_LostFocus(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox_year.Text))
            {
                textBox_year.Text = "Year";

                

            }
            else
            {
                if (int.Parse(textBox_year.Text) >= DateTime.Now.Year)
                {
                    textBox_year.Text = DateTime.Now.Year.ToString();
                   
                }
                textBox_month.Enabled = true;

            }
        }

        private void TextBox_year_GotFocus(object sender, EventArgs e)
        {
            if (textBox_year.Text == "Year")
                textBox_year.Text = "";
        

        }

        private void textBox_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_year.MaxLength = 4;
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            

        }
        

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_Phone.MaxLength = 10;
           
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }

        private void textBox_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_days.MaxLength = 2;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_days.MaxLength = 2;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
        
        private void button_save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label_password.Text) && String.IsNullOrEmpty(label_phonenumber.Text) && String.IsNullOrEmpty(textBox_days.Text) && String.IsNullOrEmpty(label_password.Text))
            {
                MessageBox.Show("Notthing to save.");
            }
            else
            {
                if (!String.IsNullOrEmpty(Label_name.Text))
                {
                    Database.updateName(mainscr.CurrentUser.UserID, Label_name.Text);
                }
                if (!String.IsNullOrEmpty(label_phonenumber.Text))
                {
                    Database.updatePhone(mainscr.CurrentUser.UserID, label_phonenumber.Text);
                }
                var Date = textBox_days.Text + "/" + textBox_month.Text + "/" + textBox_year.Text;
                DateTime tesst;
                var DOB = DateTime.TryParse(Date, out tesst);
                if (!String.IsNullOrEmpty(textBox_days.Text))
                {
                    Database.updateDOB(mainscr.CurrentUser.UserID, DOB.ToString());
                }
                if (!String.IsNullOrEmpty(label_password.Text))
                {
                    if (textBox_retypepwd.Text == label_password.Text)
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
