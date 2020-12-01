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
    public partial class Login : Form
    {
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            userName_textBox.Focus();


            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }



        }

        MainScreen mainScr;
        public Login(MainScreen callScr)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            userName_textBox.Focus();


            mainScr = callScr;


            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }



        }

        private void registerLink_label_Click(object sender, EventArgs e)
        {
            this.Close();
            new Register(mainScr).ShowDialog();

           
        }

        private void forgotPassLink_label_Click(object sender, EventArgs e)
        {
            this.Close();
            new ForgotPassword().ShowDialog();
            
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
            string username;
            int userID;

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
                username = login.Rows[0]["username"].ToString();
                userID = int.Parse(login.Rows[0]["userID"].ToString());
                MessageBox.Show("Login successfully !");
                mainScr.CurrentUser.UserID = userID;
                mainScr.CurrentUser.Username = username;
                mainScr.setAccountButtonUsername(username);
                this.Close();
            }
            login.Clear();
            connection.Close();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
