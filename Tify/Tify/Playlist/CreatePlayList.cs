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
        public CreatePlayList()
        {
            InitializeComponent();
           
        }
        private FlowLayoutPanel PlaylistMenu_panel;
        private MainScreen mainScr;
        public CreatePlayList(MainScreen callForm)
        {
            InitializeComponent();
            mainScr = callForm;
            PlaylistMenu_panel = mainScr.getCreatePlayList_FlowPanel();
            
            Description_TextBox.GotFocus += Description_TextBox_GotFocus;
            Description_TextBox.LostFocus += Description_TextBox_LostFocus;
            Title_TextBox.GotFocus += Title_TextBox_GotFocus;
            Title_TextBox.LostFocus += Title_TextBox_LostFocus;



            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private AddtoPlaylistForm addtoPlaylistForm=null;
        public CreatePlayList(MainScreen callForm,AddtoPlaylistForm addtoPlaylistForm)
        {
            InitializeComponent();
            mainScr = callForm;
            this.addtoPlaylistForm = addtoPlaylistForm;
            PlaylistMenu_panel = mainScr.getCreatePlayList_FlowPanel();

            Description_TextBox.GotFocus += Description_TextBox_GotFocus;
            Description_TextBox.LostFocus += Description_TextBox_LostFocus;
            Title_TextBox.GotFocus += Title_TextBox_GotFocus;
            Title_TextBox.LostFocus += Title_TextBox_LostFocus;



            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
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
            newbutton.Cursor = Cursors.Hand;
            newbutton.TextAlign = ContentAlignment.MiddleLeft;
            newbutton.ForeColor = Color.White;
            newbutton.Width = 210;
            newbutton.Height = 46;
            PlaylistMenu_panel.FlowDirection = FlowDirection.TopDown;
            newbutton.MouseClick += mainScr.menuPanelPlaylists_button_MouseClick;
            newbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 78, 84);
            

            if (string.IsNullOrWhiteSpace(Title_TextBox.Text)|| Title_TextBox.ForeColor==Color.Gray)
            {
                MessageBox.Show("PlayList name cannot be a blank");
            }
            if (!Database.checkIfPlaylistExisted(Title_TextBox.Text,mainScr.CurrentUser.UserID))
            {
                MessageBox.Show("Name existed , may be try another name ?");
            }
            else
            {
                Database.createPlaylist(mainScr.CurrentUser.UserID, Title_TextBox.Text, Description_TextBox.Text);
                PlaylistMenu_panel.Controls.Add(newbutton);
                //reload playlist form when created new playlist
                if (addtoPlaylistForm!=null)
                {
                    addtoPlaylistForm.loadPlaylist_InFlowPanel();
                }
                mainScr.playlistScr.reload_createNew();
                this.Close();
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

        public void AddPlaylistButtonToMenuPanel(FlowLayoutPanel CreatePlayList_FlowPanel)
        {
            CreatePlayList_FlowPanel.Controls.Clear();

            DataTable playlisTable = Database.getPlaylistTable_Playlist(mainScr.CurrentUser.UserID);

            foreach (DataRow playlist in playlisTable.Rows)
            {
                Button newbutton = new Button();
                newbutton.Width = 210;
                newbutton.Height = 46;
                newbutton.BackColor = Color.FromArgb(36, 37, 40);
                newbutton.ForeColor = Color.White;
                newbutton.FlatStyle = FlatStyle.Flat;

                newbutton.FlatAppearance.BorderSize = 0;
                newbutton.Font = new Font("Nationale", 12);
                newbutton.TextAlign = ContentAlignment.MiddleLeft;
                newbutton.Text = playlist["playlistTitle"].ToString();
                newbutton.Cursor = Cursors.Hand;
                newbutton.MouseClick += mainScr.menuPanelPlaylists_button_MouseClick;
                CreatePlayList_FlowPanel.FlowDirection = FlowDirection.TopDown;
                hideScrollBar(CreatePlayList_FlowPanel);
                CreatePlayList_FlowPanel.Controls.Add(newbutton);
            }
           
            
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
    }
}
