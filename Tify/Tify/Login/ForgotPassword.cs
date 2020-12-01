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
    public partial class ForgotPassword : Form
    {

        SqlConnection connection;

        public ForgotPassword()
        {
            InitializeComponent();
            userName_textBox.Focus();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

        }

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

        DataTable login = new DataTable();
        Account account=new Account();
        private void done_button_Click(object sender, EventArgs e)
        {
            if (userName_textBox.Text == "" || phone_textBox.Text == "")
            {
                MessageBox.Show("Please enter your username and phone");
                userName_textBox.Focus();
                return;
            }
            string sqlCommand = "Select * from Account where username=@usrname and phone=@phone";
            connection.Open();
            string username;
            string phone;

            using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
            {
                cmd.Parameters.AddWithValue("@usrname", userName_textBox.Text);

                cmd.Parameters.AddWithValue("@phone", phone_textBox.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    login.Load(reader);
                  

                }

            }
            //Ko dang nhap dc
            if (login.Rows.Count == 0)
            {
                MessageBox.Show("Wrong username or password, try again");
                userName_textBox.Clear();
                phone_textBox.Clear();
                userName_textBox.Focus();

            }
            else //Dang nhap thanh cong
            {
                username = login.Rows[0]["username"].ToString();
                phone = login.Rows[0]["phone"].ToString();
                account.Phone = phone;
                account.Username = username;
                this.Close();
                new resetPassword(account);
            }
            login.Clear();
            connection.Close();
        }
    }
}
