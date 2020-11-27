using DevExpress.XtraEditors;
using GetData;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Threading;
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
            searchBar_textBox.LostFocus += AddText;
            soundPlayer.PlayStateChange += SoundPlayer_PlayStateChange;
            home_button.Focus();
            songDetail = new SongDetail(this);
            firstLoadChildForm();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                EnableDoubleBuferring(control);
            }


        }

        private Home homeScr;
        private MyMix myMixScr;
        private Playlist playlistScr;
        private Artist artistScr;

        #region doublebuffered

       
        public static void EnableDoubleBuferring(Control control)
        {
           
            foreach (Control item in control.Controls)
            {
                EnableDoubleBuferring(item);
            }
            if (control.Name == "volume_trackBar")
                return;


            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(control, true, null);
        }

        #endregion doublebufferd

        #region load nhac khi chuyen bai

        private string[] suggestedSong;
        public string currentTrack;

        public void loadNewSong(string Url)
        {
            currentTrack = Url;
            soundPlayer.URL = GetSongData.GetStreamLink(Url);

          

            time = 0;

            songPicture.Load(GetSongData.GetSongCover(Url));
            songCover_panel.BackgroundImage = songPicture.Image;
            string[] artists = GetSongData.GetSongArtist(Url);
            artist_label.Text = string.Empty;
            foreach (string artist in artists)
            {
                artist_label.Text += artist + ";";
            }

            title_label.Text = GetSongData.GetSongName(Url);

            //timer
            currentTime_label.Text = "0:00 /";
            int[] duration = GetSongData.GetSongDuration(Url);
            int durationMin = duration[0];
            int durationSec = duration[1];

            if (durationSec < 10)
            {
                duration_label.Text = " " + durationMin + ":0" + durationSec;
            }
            else
            {
                duration_label.Text = " " + durationMin + ":" + durationSec;
            }

            //lay suggest song
            suggestedSong = GetSongData.GetSuggetSongs(Url);
            songDetail.setSuggestedSong(suggestedSong);

        }

        #endregion load nhac khi chuyen bai

        #region test

        //test
        private string testURL = "https://vi.chiasenhac.vn/mp3/nah/dmcs-tsvrrt5bqaafhq.html";

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
                duration_label.Text = " " + durationMin + ":0" + durationSec;
            }
            else
            {
                duration_label.Text = " " + durationMin + ":" + durationSec;
            }

            //lay suggest song
            suggestedSong = GetSongData.GetSuggetSongs(testURL);
            songDetail.setSuggestedSong(suggestedSong);
            currentTrack = testURL;
        }

        #endregion test

        private WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();

        #region Load form

        private void MainScreen_Load(object sender, EventArgs e)
        {
            home_button.PerformClick();

            volume_trackBar.Anchor = AnchorStyles.Right;

            //Hide  ScrollBar so menu_panel
            hideScrollBar(menu_panel, "panel");

            this.DoubleBuffered = true;

            //demo

            testFunc();
            songDetail.setVolume_Trackbar_Value(volume_trackBar.Value);
            //set opacity for song cover
            songImgOpacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            songImgOpacity_panel.Hide();
        }

        #endregion Load form

        #region Đổi icon khi nhấn vào nút play/pause

        private double time;

        public void pause_button_Click(object sender, EventArgs e)
        {
            Button pause = sender as Button;
            if (pause.Tag.ToString() == "pause")
            {
                pause.BackgroundImage = player_imageList.Images["play.png"];
                time = soundPlayer.controls.currentPosition;
                soundPlayer.controls.pause();
                pause.Tag = "play";
                myToolTip.SetToolTip(pause, "Play");

                //if(pause_button.Focused==true)
                songDetail.setPause_Button_Img(pause.BackgroundImage);
            }
            else
            {
                pause.BackgroundImage = player_imageList.Images["pause.png"];
                soundPlayer.controls.currentPosition = time;
                soundPlayer.controls.play();

                pause.Tag = "pause";
                myToolTip.SetToolTip(pause, "Pause");

                //if (pause_button.Focused == true)
                songDetail.setPause_Button_Img(pause.BackgroundImage);
            }
            //
        }

        #endregion Đổi icon khi nhấn vào nút play/pause

        #region Đổi icon khi nhấn vào nút âm lượng

        private int lastVolume = 0;

        private void volume_button_Click(object sender, EventArgs e)
        {
            if (volume_button.Tag.ToString() == "off")
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
            songDetail.setVolume_Button_Img(volume_button.BackgroundImage);
        }

        #endregion Đổi icon khi nhấn vào nút âm lượng

        #region Volume trackbar

        private void volume_trackBar_ValueChanged(object sender, EventArgs e)
        {
            soundPlayer.settings.volume = volume_trackBar.Value;
            if (volume_trackBar.Focused == true || volume_button.Focused == true || songDetail.volume_detailButton.Focused == true)
                songDetail.setVolume_Trackbar_Value(volume_trackBar.Value);
            if (volume_trackBar.Value == 0)
            {
                volume_button.BackgroundImage = player_imageList.Images["mute.png"];

                volume_button.Tag = "off";
                songDetail.setVolume_Button_Img(volume_button.BackgroundImage);
            }
            else
            {
                if (volume_button.Tag.ToString() == "off")
                {
                    volume_button.BackgroundImage = player_imageList.Images["volume.png"];

                    volume_button.Tag = "on";
                    songDetail.setVolume_Button_Img(volume_button.BackgroundImage);
                }
            }
        }

        #endregion Volume trackbar

        #region Đổi icon khi nhấn vào nút shuffle

        private void shuffle_button_Click(object sender, EventArgs e)
        {
            if (shuffle_button.Tag.ToString() == "on")
            {
                shuffle_button.BackgroundImage = player_imageList.Images["shuffle_off.png"];
                shuffle_button.Tag = "off";
            }
            else
            {
                shuffle_button.BackgroundImage = player_imageList.Images["shuffle_on.png"];
                shuffle_button.Tag = "on";
            }
            songDetail.setShuffle_Button_Img(shuffle_button.BackgroundImage);
        }

        #endregion Đổi icon khi nhấn vào nút shuffle

        #region event khi Form size đổi

        private bool checkResize = false;
        private bool checkResize1 = false;

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Chỉnh lại vị trí của 3 dòng title,artist,playingFrom và ẩn hoặc hiện songImg
            if (this.Size.Width <= 975 && checkResize == false)
            {
                checkResize = true;

                songCover_panel.Hide();
                //x=18
                title_label.Location = new Point(15, title_label.Location.Y);
                artist_label.Location = new Point(15, artist_label.Location.Y);
                playingFrom_label.Location = new Point(15, playingFrom_label.Location.Y);

                //Chỉnh vị trí nút play/pause/shuffle...
                play_pause_panel.Location = new Point(200, 0);
            }
            else if (this.Size.Width > 975 && checkResize == true)
            {
                checkResize = false;

                songCover_panel.Show();
                //x=104
                title_label.Location = new Point(104, title_label.Location.Y);
                artist_label.Location = new Point(104, artist_label.Location.Y);
                playingFrom_label.Location = new Point(104, playingFrom_label.Location.Y);

                //center 3 nut play/pause/shuffle
                play_pause_panel.Left = (player_panel.ClientSize.Width - play_pause_panel.Width) / 2;
                play_pause_panel.Top = (player_panel.ClientSize.Height - play_pause_panel.Height) / 2;
            }

         

            //Chỉnh lại vị trí của menu bar bên trái
            if (this.Size.Width >= 860 && checkResize1 == false)
            {
                checkResize1 = true;

                changeMenuButtonStyle(false);
            }
            else if (this.Size.Width < 860 && checkResize1 == true)
            {
                checkResize1 = false;
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
                openChildForm(homeScr);
            else if (sender == myMix_button)
                openChildForm(myMixScr);
            else if (sender == playlist_button)
                openChildForm(playlistScr);
            else if (sender == artists_button)
                openChildForm(artistScr);
            else
                MessageBox.Show("Chuaco");
        }

        #endregion Đổi màu icon và chữ khi click vào 1 menu button, mở child Form

        #region Phóng to & thu nhỏ menu panel khi di chuột vào

        public void menu_panel_MouseHover(object sender, EventArgs e)
        {
            //240 65

            if (menu_panel.Width == 65 && this.Size.Width < 860)
                changeMenuButtonStyle(false);
        }

        public void menu_panel_MouseLeave(object sender, EventArgs e)
        {
            if (menu_panel.Width == 240 && this.Size.Width < 860)
            {
                if (menu_panel.ClientRectangle.Contains(menu_panel.PointToClient(Control.MousePosition)))
                    return;
                else
                {
                    changeMenuButtonStyle(true);

                    base.OnMouseLeave(e);
                }
            }
            else
            {
                return;
            }
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

        private void firstLoadChildForm()
        {
            artistScr = new Artist();
            homeScr = new Home(this);
            myMixScr = new MyMix();
            playlistScr = new Playlist();
            Form[] temp = { myMixScr, homeScr, playlistScr, artistScr };
            foreach (Form item in temp)
            {
                item.TopLevel = false;
                item.FormBorderStyle = FormBorderStyle.None;
                item.Dock = DockStyle.Fill;
                childForm_panel.Controls.Add(item);
                item.Show();
            }
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm == childForm)
                    return;
                activeForm.SendToBack();
            }

            activeForm = childForm;

            childForm.BringToFront();
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

        #endregion placeHolder for search bar

        #region createplaylist

        private void createNewPlaylist_button_Click(object sender, EventArgs e)
        {
            var myForm = new CreatePlayList(this);
            myForm.ShowDialog();
        }

        #endregion createplaylist

        #region mo form login/register khi click vao account button

        private Login loginForm = new Login();

        private void account_button_Click(object sender, EventArgs e)
        {
            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.ShowDialog();
        }

        #endregion mo form login/register khi click vao account button

        #region progressBar

        private bool isFirstLaunch = true;
        private void SoundPlayer_PlayStateChange(int NewState)
        {

            if (soundPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar.Properties.Maximum = (int)soundPlayer.currentMedia.duration;
                songDetail.setProgressBar_Maximum(progressBar.Properties.Maximum);
                onesec.Start();
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsPaused)
            {
                onesec.Stop();
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsStopped)
            {
                onesec.Stop();
                progressBar.EditValue = 0;
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsMediaEnded)
            {
                next_button.PerformClick();
                progressBar.EditValue = 0;
                onesec.Stop();
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsReady)
            {
                if (soundPlayer.controls.currentItem==null || isFirstLaunch)
                {
                    if (isFirstLaunch)
                    {
                        isFirstLaunch = false;
                    }
                    return;
                }
                soundPlayer.controls.play();

            }

        }

        private string curMin = "0", curSec = "0";

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

                progressBar.EditValue = (int)ProgressBarValue;
                soundPlayer.controls.currentPosition = (int)progressBar.EditValue;
            }
        }

        //Drag
        private bool isDown = false;

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
                progressBar.EditValue = (int)ProgressBarValue;
            }
        }

        private void progressBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            if (!progressBar.ClientRectangle.Contains(progressBar.PointToClient(Control.MousePosition)))
                soundPlayer.controls.currentPosition = (int)progressBar.EditValue;
        }

        private void onesec_Tick(object sender, EventArgs e)
        {
            if (soundPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar.EditValue = (int)soundPlayer.controls.currentPosition;
                curMin = ((int)progressBar.EditValue / 60).ToString();
                if ((int)progressBar.EditValue % 60 < 10)
                    curSec = "0" + ((int)progressBar.EditValue % 60).ToString();
                else
                    curSec = ((int)progressBar.EditValue % 60).ToString();

                currentTime_label.Text = curMin + ":" + curSec + " /";
            }
        }

        #endregion progressBar

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

        private SongDetail songDetail;

        private void ShowSongDetailWhenClickPlayerPanel(object sender, EventArgs e)
        {
            //774, 361
            this.MinimumSize = new Size(774, 710);
            if (songDetail_panel.Controls.Count == 0)
            {
                songDetail.TopLevel = false;
                songDetail_panel.Controls.Add(songDetail);
                songDetail.Dock = DockStyle.Fill;
                songDetail.BringToFront();
                songDetail.Show();
            }

            songDetail_panel.BringToFront();
            songImgOpacity_panel.Visible = false;
        }

        #endregion event with music cover

        #region sync 2 form

        private void currentTime_label_TextChanged(object sender, EventArgs e)
        {
            songDetail.setCurrentTime_Label(currentTime_label.Text);
        }

        private void duration_label_TextChanged(object sender, EventArgs e)
        {
            songDetail.setDuration_Label(duration_label.Text);
        }

        private void title_label_TextChanged(object sender, EventArgs e)
        {
            songDetail.setTitle_Label(title_label.Text);
        }

        private void artist_label_TextChanged(object sender, EventArgs e)
        {
            songDetail.setArtist_Label(artist_label.Text);
        }

        private void progressBar_EditValueChanged(object sender, EventArgs e)
        {
            double ratio = (int)progressBar.EditValue * 1.0f / progressBar.Properties.Maximum;

            songDetail.setPositionOfProgessBar(ratio);
        }

        private void songCover_panel_BackgroundImageChanged(object sender, EventArgs e)
        {
            songDetail.setSongCover_detailPictureBox(songCover_panel.BackgroundImage);
        }

        #endregion sync 2 form

        #region get/set control, perform event

        public FlowLayoutPanel getCreatePlayList_FlowPanel()
        {
            return CreatePlayList_FlowPanel;
        }

        public WindowsMediaPlayer getSoundPlayer()
        {
            return soundPlayer;
        }

        public Button getPause_button()
        {
            return pause_button;
        }

        public Panel getSongDetailPanel()
        {
            return songDetail_panel;
        }

        public MediaSlider.MediaSlider getVolume_trackBar()
        {
            return volume_trackBar;
        }

        public Button getNext_Button()
        {
            return next_button;
        }

        public Button getPrevious_Button()
        {
            return previous_button;
        }

        public Button getShuffle_Button()
        {
            return shuffle_button;
        }

        public Label getDuration_Label()
        {
            return duration_label;
        }

        public void pause_button_PerformClick()
        {
            pause_button.PerformClick();
        }

        public void shuffle_button_PerformClick()
        {
            shuffle_button.PerformClick();
        }

        public void volume_button_PerformClick()
        {
            volume_button.PerformClick();
        }

        public void setVolume_trackBarVolume(int val)
        {
            volume_trackBar.Value = val;
        }

        public void setProgressBar_Value(double ratio)
        {
            double ProgressBarValue = ratio * progressBar.Properties.Maximum;

            progressBar.EditValue = (int)ProgressBarValue;
        }

        public ProgressBarControl getProgressBar()
        {
            return progressBar;
        }

        #endregion get/set control, perform event

        #region next/previous button event

        public Stack previousTracks = new Stack();

        private void previous_button_Click(object sender, EventArgs e)
        {
            if (previousTracks.Count == 0)
            {
                MessageBox.Show("There is no previous track");
                return;
            }
            string lastTrack = previousTracks.Pop() as string;
            loadNewSong(lastTrack);
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (previousTracks.Count == 0)
            {
                previousTracks.Push(testURL);
            }
            else
            {
                previousTracks.Push(currentTrack);
            }
            loadNewSong(suggestedSong[0]);
        }

        #endregion next/previous button event
    }
}