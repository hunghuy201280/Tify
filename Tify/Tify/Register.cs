using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            this.BringToFront();
            string connectionString = "Server=tcp:hunghuy2009.database.windows.net,1433;Initial Catalog=Tify;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connectionString);
            userName_textBox.Focus();


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
        }

        private void forgotPassLink_label_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().ShowDialog();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (userName_textBox.Text==""||password_textBox.Text==""||phone_textBox.Text=="")
            {
                MessageBox.Show("Please enter your information ");
            }
         
            string sqlCommand = "insert into Account values(@username,@password,@phone)";
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
                    new Login().ShowDialog();
                }
                catch (SqlException ex) when (ex.Number==2627)
                {
                    MessageBox.Show("Your username already exists, please choose another one");
                }
            }
            connection.Close();
        }
    }
}
