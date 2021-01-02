using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

         
        }

        Login loginScr;
        public Register(Login callFm)
        {
            InitializeComponent();

            this.BringToFront();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            userName_textBox.Focus();

            loginScr = callFm;
          
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
       

        }
        SqlConnection connection;


        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScr.BringToFront();
        }

        private void LoginLink_label_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScr.BringToFront();
        }
      

        private void Register_Button_Click(object sender, EventArgs e)
        {
            
            if (userName_textBox.Text==""||password_textBox.Text==""||phone_textBox.Text=="")
            {
                MessageBox.Show("Please enter your information ");
            }
            var match = new Regex(@"^[a-zA-Z0-9_-]{3,16}$");
            var std = new Regex(@"^\+?(\d.*){10,}$");
            if (!match.IsMatch(userName_textBox.Text))
            {
                MessageBox.Show("User name is string between 3 and 16 characters, allowing alphanumeric characters and hyphens and underscores");

            }
            if (!std.IsMatch(phone_textBox.Text))
            {
                MessageBox.Show("Oops, check your phone number again ?");
            }
            else
            {
                string sqlCommand = "insert into Account values(@username,@password,@phone,null,null)";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@username", userName_textBox.Text);
                        cmd.Parameters.AddWithValue("@password", password_textBox.Text);
                        cmd.Parameters.AddWithValue("@phone", phone_textBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign up successfully!\nPlease login your new account!");
                        this.Close();
                        loginScr.BringToFront();
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Your username already exists, please choose another one");
                    }
                }
                connection.Close();
            }
        }

     
    }
}
