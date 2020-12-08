using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Tify
{
    public partial class CreatePlayList : Form
    {
        SqlConnection sqlcon;
        public CreatePlayList()
        {
            InitializeComponent();
         

        }
        private FlowLayoutPanel menu_pnl;
        private MainScreen mainScr;
        public CreatePlayList(MainScreen callForm)
        {
            InitializeComponent();
            mainScr = callForm;
            menu_pnl = mainScr.getCreatePlayList_FlowPanel();
            
            this.DoubleBuffered = true;
            Description_TextBox.GotFocus += Description_TextBox_GotFocus;
            Description_TextBox.LostFocus += Description_TextBox_LostFocus;
            Title_TextBox.GotFocus += Title_TextBox_GotFocus;
            Title_TextBox.LostFocus += Title_TextBox_LostFocus;
            
           


            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        private void Title_TextBox_LostFocus(object sender, EventArgs e)
        {
            panel_title_underline.BackColor = Color.FromArgb(56, 57, 61);
            if (string.IsNullOrWhiteSpace(Title_TextBox.Text))
                Title_TextBox.Text = "Give it a name ...";
        }

        private void Title_TextBox_GotFocus(object sender, EventArgs e)
        {
            panel_title_underline.BackColor = Color.Cyan;
            if (Title_TextBox.Text == "Give it a name ...")
            { Title_TextBox.Text = ""; }
            
        }

        private void Description_TextBox_LostFocus(object sender, EventArgs e)
        {
            panel_description_underline.BackColor = Color.FromArgb(56, 57, 61);
            if (string.IsNullOrWhiteSpace(Description_TextBox.Text))
            Description_TextBox.Text = "Describe something ...";
        }

        private void Description_TextBox_GotFocus(object sender, EventArgs e)
        {
            panel_description_underline.BackColor = Color.Cyan;
            if (Description_TextBox.Text == "Describe something ...")
                Description_TextBox.Text = "";

        }


        private void CreatePlayList_Button_Click(object sender, EventArgs e)
        {

            Button newbutton = new Button();
            newbutton.FlatStyle = FlatStyle.Flat;
            newbutton.FlatAppearance.BorderSize = 0;
            newbutton.Text = Title_TextBox.Text;
            newbutton.Font = new Font("Nationale", 12);
            newbutton.AutoSize = false;
            newbutton.MouseHover += mainScr.menu_panel_MouseHover;
            newbutton.MouseLeave += mainScr.menu_panel_MouseLeave;
            newbutton.TextAlign = ContentAlignment.MiddleLeft;
            newbutton.ForeColor = Color.White;
            newbutton.Width = 210;
            newbutton.Height = 46;
            menu_pnl.FlowDirection = FlowDirection.TopDown;
            newbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 78, 84);
            menu_pnl.Controls.Add(newbutton);

            if (string.IsNullOrWhiteSpace(Title_TextBox.Text)|| Title_TextBox.ForeColor==Color.Gray)
            {
                MessageBox.Show("PlayList name cannot be a blank");
            }
            else
            {
                sqlcon.Open();
                string playlistname = Title_TextBox.Text;

                using (SqlCommand command = new SqlCommand("INSERT INTO Playlist (playlistTitle) OUTPUT inserted.playlistID VALUES('" + playlistname + "')", sqlcon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            if (reader.Read())
                            {
                                string id = reader[0].ToString();
                                using (SqlCommand command1 = new SqlCommand("insert into UserHasPlaylist values(" + mainScr.CurrentUser.UserID + ",'" + id.ToString() + "')", sqlcon))
                                {
                                    command1.ExecuteNonQuery();
                                }
                            }

                        }
                    }
                }
                sqlcon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePlayList_Load(object sender, EventArgs e)
        {
            Description_TextBox.Text = "Describe something ...";
            Description_TextBox.ForeColor = Color.Gray;
            Title_TextBox.Text = "Give it a name ..."; 
            Title_TextBox.ForeColor= Color.Gray; ;
            panel_description_underline.BackColor = Color.FromArgb(56, 57, 61);
            panel_title_underline.BackColor = Color.FromArgb(56, 57, 61);


        }

        private void Description_TextBox_TextChanged(object sender, EventArgs e)
        {
            Description_TextBox.ForeColor = Color.White;
            if (Description_TextBox.Text == "Describe something ...")
            {
                Description_TextBox.ForeColor = Color.Gray;
            }
        }

        private void Title_TextBox_TextChanged(object sender, EventArgs e)
        {
            Title_TextBox.ForeColor = Color.White;
            if (Title_TextBox.Text == "Give it a name ...")
            {
                Title_TextBox.ForeColor = Color.Gray; ;
            }

        }
    }
}
