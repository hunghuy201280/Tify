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

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            textBox_year.GotFocus += TextBox_year_GotFocus;
            textBox_year.LostFocus += TextBox_year_LostFocus;
            textBox_year.Text = "Year";
            addmonth();
        }

        private void TextBox_year_LostFocus(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox_year.Text))
            {
                textBox_year.Text = "Year";
               
                comboBox_month.Enabled = false;

            }
            else
            {
                if (int.Parse(textBox_year.Text) >= DateTime.Now.Year)
                {
                    textBox_year.Text = DateTime.Now.Year.ToString();
                }
                if (!string.IsNullOrWhiteSpace(textBox_year.Text))
                {
                    
                    comboBox_month.Enabled = true;

                }
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
        void addmonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox_month.Items.Add(i);
            }
            
        }

        private void comboBox_month_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_month.Text != "")
                comboBox_day.Enabled = true;
            addday();
        }
        void addday()
        {
           int days= DateTime.DaysInMonth(int.Parse(textBox_year.Text), int.Parse(comboBox_month.Text));
            for (int i = 1; i <= days; i++)
            {
                comboBox_day.Items.Add(i);
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
    }
}
