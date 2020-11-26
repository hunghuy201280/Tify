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
    public partial class Login : Form
    {
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            string connectionString = "Server=tcp:hunghuy2009.database.windows.net,1433;Initial Catalog=Tify;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connectionString);
            
           

        }

        private void registerLink_label_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void forgotPassLink_label_Click(object sender, EventArgs e)
        {
            new ForgotPassword().Show();
            this.Hide();
        }

        DataTable login = new DataTable();
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (userName_textBox.Text =="" || password_textBox.Text=="")
            {
                MessageBox.Show("Please enter your username and password");
                userName_textBox.Focus();
                return;
            }
            string sqlCommand = "Select * from Account where username=@usrname and password=@passwd";
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
            {
                cmd.Parameters.AddWithValue("@usrname", userName_textBox.Text);
                cmd.Parameters.AddWithValue("@passwd", password_textBox.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    login.Load(reader);
                }

            }
            //Ko dang nhap dc
            if (login.Rows.Count==0)
            {
                MessageBox.Show("Wrong username or password, try again");
                userName_textBox.Clear();
                password_textBox.Clear();
                userName_textBox.Focus();
            }
            else //Dang nhap thanh cong
            {

            }
            connection.Close();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
