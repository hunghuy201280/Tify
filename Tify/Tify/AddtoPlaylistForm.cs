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
    public partial class AddtoPlaylistForm : Form
    {
        SqlConnection sqlcon;
        private MainScreen mainScr;
        private CreatePlayList CreatePL;
        public AddtoPlaylistForm()
        {
            InitializeComponent();

            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }
        public AddtoPlaylistForm(MainScreen callForm)
        {
            InitializeComponent();
            mainScr = callForm;
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        private void AddtoPlaylistForm_Load(object sender, EventArgs e)
        {

            sqlcon.Open();
            using (SqlCommand command = new SqlCommand("select playlistTitle,userID  from Playlist,UserHasPlaylist where Playlist.playlistID=UserHasPlaylist.playlistID and userID ="+mainScr.CurrentUser.UserID+"", sqlcon))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            Button newbutton = new Button();
                            newbutton.Width = 233;
                            newbutton.Height = 45;
                            newbutton.BackColor = Color.FromArgb(36, 37, 40);
                            newbutton.ForeColor = Color.White;
                            newbutton.FlatStyle = FlatStyle.Flat;
                            
                            newbutton.FlatAppearance.BorderSize = 0;
                            newbutton.Font = new Font("Nationale Light", 12);
                            newbutton.TextAlign = ContentAlignment.MiddleLeft;
                            newbutton.Text = reader[0].ToString();
                            flowLayoutPanel_showPL.FlowDirection = FlowDirection.TopDown;
                            hideScrollBar(flowLayoutPanel_showPL);
                            flowLayoutPanel_showPL.Controls.Add(newbutton);
                        }
                    }
                    else MessageBox.Show("No playlist found");
                }
            }
            sqlcon.Close();
        }
        static public void hideScrollBar(Control needHide)
        {
           
            {
                FlowLayoutPanel flowpanel = needHide as FlowLayoutPanel;
                flowpanel.AutoScroll = false;
                flowpanel.HorizontalScroll.Maximum = 0;
                flowpanel.AutoScroll = false;
                flowpanel.VerticalScroll.Visible = false;

                flowpanel.VerticalScroll.Maximum = 0;
                flowpanel.AutoScroll = false;
                flowpanel.HorizontalScroll.Visible = false;
                flowpanel.AutoScroll = true;
            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_createnewPL_Click(object sender, EventArgs e)
        {
            CreatePL = new CreatePlayList(mainScr);
            CreatePL.ShowDialog();
        }
    }
}
