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
       
            Register reg = new Register(this);
            
            reg.ShowDialog();
            


        }

        private void forgotPassLink_label_Click(object sender, EventArgs e)
        {
            
            new ForgotPassword(this).ShowDialog();
            
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
                Account account = new Account(login.Rows[0]["username"].ToString(), int.Parse(login.Rows[0]["userID"].ToString()),
                                              login.Rows[0]["phone"].ToString(), login.Rows[0]["name"].ToString(),
                                              login.Rows[0]["DOB"].ToString()
                                             );
                MessageBox.Show("Login successfully !");
                mainScr.loading_thread.Start();
                mainScr.setAccount(account);
                mainScr.setAccountButtonUsername(login.Rows[0]["username"].ToString());
                /*this.Hide();
                var temp = new MainScreen(account);
                temp.Show();*/
                this.Close();
               

            }
            login.Clear();
            connection.Close();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
            {

                Login_Button_Click(Login_Button, new EventArgs());

            }
        }
    }
    }
