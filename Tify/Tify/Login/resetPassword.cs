using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class resetPassword : Form
    {

        SqlConnection connection;
        public resetPassword()
        {
            InitializeComponent();
        }

        Account user;
        public resetPassword(Account account)
        {
            InitializeComponent();
            user = account;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            password_textBox.Focus();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            if (password_textBox.Text==""||passwordAgain_textBox.Text=="")
            {
                MessageBox.Show("Please type all the information ! ");
                return;
            }
            if (passwordAgain_textBox.Text!=password_textBox.Text)
            {
                MessageBox.Show("Two passwords are not match, please try again ");
                password_textBox.Clear();
                passwordAgain_textBox.Clear();
                return;
            }


            string sqlCommand = "update Account set password=@newpass where username=@usrname and phone=@phone";
            connection.Open();

            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@usrname", user.Username);
                    cmd.Parameters.AddWithValue("@newpass", password_textBox.Text);
                    cmd.Parameters.AddWithValue("@phone", user.Phone);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Your password is updated successfully !");
            }
            catch (Exception)
            {
                throw;
            }
         
            connection.Close();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
