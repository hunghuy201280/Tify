using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace Tify
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            searchBar_textBox.GotFocus += RemoveText;
            searchBar_textBox.LostFocus +=AddText;
        }

        #region Load form

        private void MainScreen_Load(object sender, EventArgs e)
        {
            openChildForm(new Home(this));

            volume_trackBar.Anchor = AnchorStyles.Right;

            //Hide  ScrollBar so menu_panel
            hideScrollBar(menu_panel, "panel");

            this.DoubleBuffered = true;

            //demo

            soundPlayer.URL = @"https://data25.chiasenhac.com/download2/2126/1/2125711-e9320e2c/128/Giau%20Vi%20Ban_%20Sang%20Vi%20Vo%20-%20RPT%20MCK.mp3";
            time = soundPlayer.controls.currentPosition;
            soundPlayer.controls.stop();
        }

        #endregion Load form

        #region Đổi icon khi nhấn vào nút play/pause

        private bool isPause = true;
        private WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();
        private double time;

        private void pause_button_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                pause_button.BackgroundImage = byteArrayToImage(FileStore.Resource.play);
                soundPlayer.controls.currentPosition = time;
                soundPlayer.controls.play();
            }
            else
            {
                pause_button.BackgroundImage = byteArrayToImage(FileStore.Resource.pause);
                time = soundPlayer.controls.currentPosition;
                soundPlayer.controls.pause();
            }
            isPause = !isPause;
        }

        #endregion Đổi icon khi nhấn vào nút play/pause

        #region Đổi icon khi nhấn vào nút âm lượng

        private bool isMute = false;

     

        private void volume_button_Click(object sender, EventArgs e)
        {
            if (isMute)
                volume_button.BackgroundImage = byteArrayToImage(FileStore.Resource.volume);
            else
                volume_button.BackgroundImage = byteArrayToImage(FileStore.Resource.mute);
            isMute = !isMute;
        }

        #endregion Đổi icon khi nhấn vào nút âm lượng

        #region event khi Form size đổi

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Chỉnh lại vị trí của 3 dòng title,artist,playingFrom và ẩn hoặc hiện songImg
            if (this.Size.Width <= 975)
            {
                songImg_pictureBox.Hide();
                //x=18
                title_label.Location = new Point(15, title_label.Location.Y);
                artist_label.Location = new Point(15, artist_label.Location.Y);
                playingFrom_label.Location = new Point(15, playingFrom_label.Location.Y);
            }
            else
            {
                songImg_pictureBox.Show();
                //x=104
                title_label.Location = new Point(104, title_label.Location.Y);
                artist_label.Location = new Point(104, artist_label.Location.Y);
                playingFrom_label.Location = new Point(104, playingFrom_label.Location.Y);
            }

            //Chỉnh vị trí nút play/pause/shuffle...
            if (this.Size.Width < 975)
                play_pause_panel.Location = new Point(200, 0);
            else
            {
                //center 3 nut do
                play_pause_panel.Left = (player_panel.ClientSize.Width - play_pause_panel.Width) / 2;
                play_pause_panel.Top = (player_panel.ClientSize.Height - play_pause_panel.Height) / 2;
            }

            //Chỉnh lại vị trí của menu bar bên trái
            if (this.Size.Width >= 860)
            {
                changeMenuButtonStyle(false);
            }
            else
            {
                changeMenuButtonStyle(true);
            }
        }

        #endregion event khi Form size đổi

        #region Đổi màu icon và chữ khi click vào 1 menu button, mở child Form

        private void menu_button_Click(object sender, EventArgs e)
        {
            Button btt = sender as Button;
            if (btt.Image != null)
            {
                if (btt.ImageIndex % 2 == 0)
                    btt.ImageIndex += 1;
            }
            btt.ForeColor = Color.FromArgb(0, 255, 255);
            Button temp;
            foreach (var item in menu_panel.Controls)
            {
                if (item is Button && item != btt)
                {
                    temp = item as Button;

                    if (temp.Image != null)
                    {
                        if (temp.ImageIndex % 2 == 1)
                            temp.ImageIndex -= 1;
                    }
                    temp.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }

            //Mở childForm
            if (sender == home_button)
                openChildForm(new Home(this));
            else if (sender == myMix_button)
            {
                bool ismix = true;
                openChildForm(new MyMix(ismix));
            }
            else if (sender == playlist_button)
            {
                openChildForm(new PlayList());
            }
            else

                MessageBox.Show("Chuaco");
        }

        #endregion Đổi màu icon và chữ khi click vào 1 menu button, mở child Form

        #region Chuyển dạng byte[] trong file resources thành image

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #endregion Chuyển dạng byte[] trong file resources thành image

        #region Phóng to & thu nhỏ menu panel khi di chuột vào

        private void menu_panel_MouseHover(object sender, EventArgs e)
        {
            //240 65
            if (menu_panel.Width == 65 && this.Size.Width < 860)
                changeMenuButtonStyle(false);
        }

        private void menu_panel_MouseLeave(object sender, EventArgs e)
        {
            if (menu_panel.ClientRectangle.Contains(menu_panel.PointToClient(Control.MousePosition)))
                return;
            else
            {
                base.OnMouseLeave(e);
            }
            if (menu_panel.Width == 240 && this.Size.Width < 860)
                changeMenuButtonStyle(true);
        }

        #endregion Phóng to & thu nhỏ menu panel khi di chuột vào

        #region Đổi size của menu bên trái

        //Đổi kích thước, style của button trong menu bên trái
        private void changeMenuButtonStyle(bool change)
        {
            if (!change)
            {
                myMix_button.Text = myMix_button.Tag.ToString();
                playlist_button.Text = playlist_button.Tag.ToString();
                albums_button.Text = albums_button.Tag.ToString();
                tracks_button.Text = tracks_button.Tag.ToString();
                artists_button.Text = artists_button.Tag.ToString();
                createNewPlaylist_button.Text = createNewPlaylist_button.Tag.ToString();

                home_button.Show();
                home_pictureBox.Hide();

                menu_panel.Size = new Size(240, menu_panel.Size.Height);

                myCollection_label.Text = myCollection_label.Tag.ToString();
                myPlaylist_label.Text = myPlaylist_label.Tag.ToString();
            }
            else
            {
                myMix_button.Text = "";
                playlist_button.Text = "";
                albums_button.Text = "";
                tracks_button.Text = "";
                artists_button.Text = "";
                createNewPlaylist_button.Text = "";
                home_button.Hide();
                home_pictureBox.Show();

                menu_panel.Size = new Size(65, menu_panel.Size.Height);

                myCollection_label.Text = "M...";
                myPlaylist_label.Text = "M...";
            }
        }

        #endregion Đổi size của menu bên trái

        #region Mở childForm

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm_panel.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Mở childForm

        #region hide scrollbar for control

        static public void hideScrollBar(Control needHide, string type)
        {
            if (type == "flow")
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
            else if (type == "panel")
            {
                Panel panel = needHide as Panel;
                

                panel.VerticalScroll.Maximum = 0;
                panel.AutoScroll = false;
                panel.HorizontalScroll.Visible = false;
                panel.AutoScroll = true;
            }
        }

        #endregion hide scrollbar for control

        #region test

        //test

        #endregion test


        #region placeHolder for search bar

        public void RemoveText(object sender, EventArgs e)
        {
            if (searchBar_textBox.Text == "Search")
            {
                searchBar_textBox.Text = "";
                searchBar_textBox.ForeColor = Color.White;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBar_textBox.Text))
            {
                searchBar_textBox.Text = "Search";
                searchBar_textBox.ForeColor = Color.FromArgb(152, 162, 166);
            }
        }



        #endregion

        #region createplaylist
        private void createNewPlaylist_button_Click(object sender, EventArgs e)
        {
            var myForm = new CreatePlayList();
            myForm.Show();
        }

        #endregion createplaylist
    }
}