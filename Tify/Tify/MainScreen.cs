﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;
using GetData;
using System.Drawing.Imaging;

namespace Tify
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            searchBar_textBox.GotFocus += RemoveText;
            searchBar_textBox.LostFocus +=AddText;
            soundPlayer.PlayStateChange += SoundPlayer_PlayStateChange;
           
          
        }

        #region test

        //test
        private string testURL = "https://chiasenhac.vn/nhac-hot/vietnam.html?playlist=1";

        private PictureBox songPicture = new PictureBox();
        private void testFunc()
        {
          
            //volume

            volume_trackBar.Maximum = 100;
            volume_trackBar.Value = 50;
            //
            soundPlayer.URL = GetSongData.GetStreamLink(testURL);
            soundPlayer.controls.stop();
            time = 0;
            
          
            songPicture.Load(GetSongData.GetSongCover(testURL));
            songCover_panel.BackgroundImage = songPicture.Image;
            string[] artists = GetSongData.GetSongArtist(testURL);
            artist_label.Text = string.Empty;
            foreach (string artist in artists)
            {
                artist_label.Text += artist + ";";
            }
            
            title_label.Text = GetSongData.GetSongName(testURL);

            //timer
            currentTime_label.Text = "0:00 /";
            int[] duration = GetSongData.GetSongDuration(testURL);
            int durationMin = duration[0];
            int durationSec = duration[1];
            
            
            
            if (durationSec < 10)
            {
                duration_label.Text = " "+ durationMin + ":0" + durationSec;
            }
            else
            {
                duration_label.Text =" "+  durationMin + ":" + durationSec;
            }
        }

        #endregion test

        private WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();
        #region Load form

        private void MainScreen_Load(object sender, EventArgs e)
        {
            openChildForm(new Home(this));

            volume_trackBar.Anchor = AnchorStyles.Right;

            //Hide  ScrollBar so menu_panel
            hideScrollBar(menu_panel, "panel");

            this.DoubleBuffered = true;

            //demo

            //testFunc();

            //set opacity for song cover
            songImgOpacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            songImgOpacity_panel.Hide();

            //add control to panel
        }

        #endregion Load form

        #region Đổi icon khi nhấn vào nút play/pause

       
        private double time;

        public void pause_button_Click(object sender, EventArgs e)
        {
            Button pause=sender as Button;
            if (pause.Tag.ToString()=="pause")
            {
                pause.BackgroundImage = player_imageList.Images["play.png"];
                time = soundPlayer.controls.currentPosition;
                soundPlayer.controls.pause();
                pause.Tag = "play";
                myToolTip.SetToolTip(pause, "Play");
            }
            else
            {
                pause.BackgroundImage = player_imageList.Images["pause.png"];
                soundPlayer.controls.currentPosition = time;
                soundPlayer.controls.play();

                pause.Tag = "pause";
                myToolTip.SetToolTip(pause, "Pause");

            }
            //
                

        }

        #endregion Đổi icon khi nhấn vào nút play/pause

        #region Đổi icon khi nhấn vào nút âm lượng


        int lastVolume=0;
        private void volume_button_Click(object sender, EventArgs e)
        {
           
            if (volume_button.Tag.ToString()=="off")
            {
                volume_button.BackgroundImage = player_imageList.Images["volume.png"];
                volume_trackBar.Value = lastVolume;
                volume_button.Tag = "on";
            }
            else
            {
                volume_button.BackgroundImage = player_imageList.Images["mute.png"];
                lastVolume = volume_trackBar.Value;
                volume_trackBar.Value = 0;
                
                volume_button.Tag = "off";
            }
            
        }



        #endregion Đổi icon khi nhấn vào nút âm lượng

        #region Volume trackbar

        private void volume_trackBar_ValueChanged(object sender, EventArgs e)
        {
            soundPlayer.settings.volume = volume_trackBar.Value;
            
        }
        #endregion

        #region Đổi icon khi nhấn vào nút shuffle

        private void shuffle_button_Click(object sender, EventArgs e)
        {
            if (shuffle_button.Tag.ToString()=="on")
            {
                shuffle_button.BackgroundImage = player_imageList.Images["shuffle_off.png"];
                shuffle_button.Tag = "off";
            }
            else
            {
                shuffle_button.BackgroundImage = player_imageList.Images["shuffle_on.png"];
                shuffle_button.Tag = "on";
            }
        }
        #endregion

        #region event khi Form size đổi

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Chỉnh lại vị trí của 3 dòng title,artist,playingFrom và ẩn hoặc hiện songImg
            if (this.Size.Width <= 975)
            {
                songCover_panel.Hide();
                //x=18
                title_label.Location = new Point(15, title_label.Location.Y);
                artist_label.Location = new Point(15, artist_label.Location.Y);
                playingFrom_label.Location = new Point(15, playingFrom_label.Location.Y);
            }
            else
            {
                songCover_panel.Show();
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

        public void openChildForm(Form childForm)
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
                
            }
            else if (type == "panel")
            {
                Panel panel = needHide as Panel;

                panel.AutoScroll = false;
                panel.HorizontalScroll.Maximum = 0;
                panel.AutoScroll = false;
                panel.VerticalScroll.Visible = false;

                panel.VerticalScroll.Maximum = 0;
                panel.AutoScroll = false;
                panel.HorizontalScroll.Visible = false;
                panel.AutoScroll = true;
            }
        }

        #endregion hide scrollbar for control

      


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


        #region mo form login/register khi click vao account button
        Login loginForm = new Login();
        private void account_button_Click(object sender, EventArgs e)
        {
            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.ShowDialog();
        }

        #endregion

        #region progressBar


        private void SoundPlayer_PlayStateChange(int NewState)
        {
            if (soundPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar.Properties.Maximum = (int)soundPlayer.currentMedia.duration;
                
               
                onesec.Start();
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsPaused)
            {
                onesec.Stop();
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsStopped)
            {
                onesec.Stop();
                progressBar.Position = 0;
            }
        }

        string curMin="0" , curSec ="0";
      

        private void progressBar_MouseHover(object sender, EventArgs e)
        {
            progressBar.Size = new Size(progressBar.Size.Width, 14);
        }

        private void progressBar_MouseLeave(object sender, EventArgs e)
        {
            progressBar.Size = new Size(progressBar.Size.Width, 7);
        }

        private void progressBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (progressBar.ClientRectangle.Contains(progressBar.PointToClient(Control.MousePosition)))
            {

                double MousePosition = e.X;
                double ratio = MousePosition / progressBar.Size.Width;
                double ProgressBarValue = ratio * progressBar.Properties.Maximum;

                progressBar.Position = (int)ProgressBarValue;
                soundPlayer.controls.currentPosition = (int)progressBar.Position;
            }
        }

        //Drag
        bool isDown = false;
        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void progressBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                double MousePosition = e.X;
                double ratio = MousePosition / progressBar.Size.Width;
                double ProgressBarValue = ratio * progressBar.Properties.Maximum;
                progressBar.Position = (int)ProgressBarValue;
                
            }
            
        }
        private void progressBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            if (!progressBar.ClientRectangle.Contains(progressBar.PointToClient(Control.MousePosition)))
                soundPlayer.controls.currentPosition = (int)progressBar.Position;
            
        }


        private void onesec_Tick(object sender, EventArgs e)
        {
            if (soundPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar.Position = (int)soundPlayer.controls.currentPosition;
                curMin = ((int)progressBar.Position / 60).ToString();
                if ((int)progressBar.Position % 60<10)
                    curSec = "0" + ((int)progressBar.Position % 60).ToString();
                else
                    curSec = ((int)progressBar.Position % 60).ToString();
               
                currentTime_label.Text = curMin + ":" + curSec + " /";
            }
        }




        #endregion

        #region event with music cover

   

        private void songCover_panel_MouseHover(object sender, EventArgs e)
        {
            songImgOpacity_panel.Show();
        }

        public void songCover_panel_MouseLeave(object sender, EventArgs e)
        {
            if (songCover_panel.ClientRectangle.Contains(songCover_panel.PointToClient(Control.MousePosition)))
                return;
            else
            {
                songImgOpacity_panel.Hide();
                base.OnMouseLeave(e); 
                
            }
            
        }

        public void songDetailMinimize_button_Click(object sender, EventArgs e)
        {
            songDetail_panel.SendToBack();
        }

      

        private void ShowSongDetailWhenClickPlayerPanel(object sender, EventArgs e)
        {
           /* SongDetail songDetail = new SongDetail();
            songDetail.TopLevel = false;

            songDetail_panel.Controls.Add(songDetail);
            songDetail.Dock = DockStyle.Fill;
            songDetail.BringToFront();
            songDetail.Show();
            songDetail_panel.BringToFront();*/

        }
        #endregion

    }
}