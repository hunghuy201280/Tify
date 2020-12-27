using DevExpress.XtraEditors;
using GetData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Tify
{
    public partial class MainScreen : Form
    {
        private SqlConnection connection;

        public Thread loading_thread;
        Loading loadingScr = new Loading();
        public MainScreen()
        {


            loading_thread = new Thread(new ThreadStart(loadingFunc));


            InitializeComponent();
            //Dang nhap
            loginForm = new Login(this);
            loginForm.ShowDialog();

            searchBar_textBox.GotFocus += RemoveText;
            searchBar_textBox.LostFocus += AddText;
            soundPlayer.PlayStateChange += SoundPlayer_PlayStateChange;
            songDetail = new SongDetail(this);

            CreatePL = new CreatePlayList(this);

            firstLoadChildForm();



            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                EnableDoubleBuferring(control);
            }
            string connectString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectString);

            //debug.Show();
        }
        private void loadingFunc()
        {
            Application.Run(loadingScr);
        }

        public Home homeScr;
        public MyMix myMixScr;
        public Playlist playlistScr;
        public Artist artistScr;
        public Albums albumsScr;
        public Tracks tracksScr;
        private Account currentUser;
        private SearchBox srchBox;
        public CreatePlayList CreatePL;
        private AddtoPlaylistForm add2PL;
        private UpdateInfo updatein4;

        public Account CurrentUser { get => currentUser; set => currentUser = value; }

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

        #endregion doublebuffered

        #region Load form

        private void MainScreen_Load(object sender, EventArgs e)
        {
            home_button.PerformClick();

            volume_trackBar.Anchor = AnchorStyles.Right;

            volume_trackBar.Maximum = 100;
            volume_trackBar.Value = 50;

            //Hide  ScrollBar so menu_panel
            hideScrollBar(menu_panel, "panel");

            this.DoubleBuffered = true;

            //demo
            this.ActiveControl = artist_label;

            //testFunc();
            songDetail.setVolume_Trackbar_Value(volume_trackBar.Value);
            //set opacity for song cover
            songImgOpacity_panel.BackColor = Color.FromArgb(125, Color.Black);
            songImgOpacity_panel.Hide();
            //Set Main Screen for RightClickUC


            //add playlist on low-left conner
            CreatePL.AddPlaylistButtonToMenuPanel(PlayList_FlowPanel);
            playlistScr.attachPlaylistContainerToPlaylistButtonInMenuPanel(PlayList_FlowPanel);






            if (homeScr.trackContainers.Count != 0)
            {
                currentTrack = homeScr.trackContainers[0].track;
                loadNewSong(currentTrack);
                setplayfrom("Home");
            }
            loopMode = LoopMode.Off;
            loadingScr.changePic();
            Thread.Sleep(2600);
            loading_thread.Abort();
        }


        #endregion Load form

        #region load nhac khi chuyen bai

        private string[] suggestedSong;
        public TrackInfo currentTrack;
        private PictureBox songPicture = new PictureBox();
        public void loadNewSong(TrackInfo track)
        {
            if (track==null)
            {
                return;
            }
            //kiểm tra track có trong dtb chưa nếu chưa add vào.
            if (track.TrackID == null)
            {
                if (!Database.checkTrackExisted(track.TrackLink))
                {
                    track.TrackID = Database.addTrackToDatabase(track.TrackLink);
                    track.IsLoved = false;

                }
                else
                {
                    track.TrackID = Database.getTrackIdBaseOnTrackLink(track.TrackLink);
                }
            }


            if (currentTrack != null)
            {
                Database.addTrackToRecentlyPlayed(track.TrackID, CurrentUser.UserID, currentTrack.TrackID);
            }

            //
            currentTrack = track;
            soundPlayer.URL = GetSongData.GetStreamLink(track.TrackLink);

            time = 0;

            if (track.Cover == null)
            {
                songPicture.Load(GetSongData.GetSongCover(track.TrackLink));
                songCover_panel.BackgroundImage = songPicture.Image;
                track.Cover = songPicture.Image;
            }
            else
            {
                songCover_panel.BackgroundImage = track.Cover;
            }

            //artist
            if (track.Artist == null)
            {
                string[] artists = GetSongData.GetSongArtist(track.TrackLink);
                artist_label.Text = string.Empty;
                foreach (string artist in artists)
                {
                    artist_label.Text += artist + ";";
                }
                track.Artist = artist_label.Text;
            }
            else
            {
                artist_label.Text = track.Artist;

            }

            //title

            if (track.Title == null)
            {
                title_label.Text = GetSongData.GetSongName(track.TrackLink);
                track.Title = title_label.Text;
            }
            else
            {
                title_label.Text = track.Title;
            }

            //time
            currentTime_label.Text = "0:00 /";

            if (track.Time == null)
            {
                TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(track.TrackLink));
                string timeString = time.ToString(@"mm\:ss");
                duration_label.Text = timeString;
                track.Time = timeString;
            }
            else
            {
                duration_label.Text = track.Time;
            }


            //check loved
            checkLoved();

            //check playpause
            //chua  lam
            //

            //lay suggest song
            suggestedSong = GetSongData.GetSuggetSongs(track.TrackLink);
            songDetail.setSuggestedSong(suggestedSong);


            if (activeForm == homeScr)
            {
                homeScr.loadRecentlyPlayed();
            }

            if (title_label.Text.Length > 24)
            {
                title_label.Text = title_label.Text.Substring(0, 24) + "...";
            }
            if (artist_label.Text.Length > 18)
            {
                artist_label.Text = artist_label.Text.Substring(0, 18) + "...";
            }

        }

        #endregion load nhac khi chuyen bai

        #region test




        #endregion test

        private WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();



        #region Đổi icon khi nhấn vào nút play/pause

        private double time;

        public void pause_button_Click(object sender, EventArgs e)
        {
            Button pause = sender as Button;
            if (pause.Tag.ToString() == "pause")
            {
                pause.BackgroundImage = player_imageList.Images["play.png"];
                time = soundPlayer.controls.currentPosition;
                pause.Tag = "play";
                myToolTip.SetToolTip(pause, "Play");

                //if(pause_button.Focused==true)
                songDetail.setPause_Button_Img(pause.BackgroundImage);
                soundPlayer.controls.pause();

            }
            else
            {
                pause.BackgroundImage = player_imageList.Images["pause.png"];
                soundPlayer.controls.currentPosition = time;

                pause.Tag = "pause";
                myToolTip.SetToolTip(pause, "Pause");

                //if (pause_button.Focused == true)
                songDetail.setPause_Button_Img(pause.BackgroundImage);
                soundPlayer.controls.play();
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

        #region random list nextrack

        private Random rng = new Random();

        public void Shuffle(IList<TrackInfo> list)
        {

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                TrackInfo value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        List<TrackInfo> originalNextTrack = new List<TrackInfo>();

        #endregion

        public void disableShuffle()
        {
            shuffle_button.BackgroundImage = player_imageList.Images["shuffle_off.png"];
            shuffle_button.Tag = "off";
            nextTrack = originalNextTrack.ConvertAll(track => new TrackInfo(track));
            songDetail.setShuffle_Button_Img(shuffle_button.BackgroundImage);

        }
       
        public void enableShuffle()
        {
            shuffle_button.BackgroundImage = player_imageList.Images["shuffle_on.png"];
            shuffle_button.Tag = "on";

            originalNextTrack = nextTrack.ConvertAll(track => new TrackInfo(track));
            Shuffle(nextTrack);
            songDetail.setShuffle_Button_Img(shuffle_button.BackgroundImage);

        }
        private void shuffle_button_Click(object sender, EventArgs e)
        {
            if (shuffle_button.Tag.ToString() == "on")
            {
                disableShuffle();
            }
            else
            {
                enableShuffle();
            }


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

                //Ẩn like,add button
                add_like_panel.Hide();
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

                //Hiện like,add button
                add_like_panel.Show();
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

        private void changeMenuButtonForeColor(Button btt)
        {
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
        }
        private void menu_button_Click(object sender, EventArgs e)
        {
            nextFormStack.Clear();
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
            {
                homeScr.loadRecentlyPlayed();
                openChildForm(homeScr);
            }
            else if (sender == myMix_button)
                openChildForm(myMixScr);
            else if (sender == playlist_button)
                openChildForm(playlistScr);
            else if (sender == artists_button)
                openChildForm(artistScr);
            else if (sender == albums_button)
                openChildForm(albumsScr);
            else if (sender == tracks_button)
                openChildForm(tracksScr);

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

        public Form activeForm = null;



        private void firstLoadChildForm()
        {
            artistScr = new Artist(this);
            homeScr = new Home(this);
            myMixScr = new MyMix(this);
            playlistScr = new Playlist(this);

            albumsScr = new Albums(this);
            tracksScr = new Tracks(this);

            srchBox = new SearchBox(this);

            updatein4 = new UpdateInfo(this);
            Form[] temp = { myMixScr, homeScr, playlistScr, artistScr, albumsScr, tracksScr, srchBox, updatein4 };
            foreach (Form item in temp)
            {
                item.TopLevel = false;
                item.FormBorderStyle = FormBorderStyle.None;
                item.Dock = DockStyle.Fill;
                childForm_panel.Controls.Add(item);
                item.Show();
            }
        }
        Stack previousFormStack = new Stack();
        Stack nextFormStack = new Stack();

        private bool pushToPrevious = true;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm == childForm)
                    return;
                if (pushToPrevious)
                {
                    previousFormStack.Push(activeForm);
                }
            }

            if (childForm == homeScr)
            {
                changeMenuButtonForeColor(home_button);
                homeScr.reAddMix();
            }
            else if (childForm == myMixScr)
            {
                changeMenuButtonForeColor(myMix_button);
                myMixScr.addMixToBottomFlowPanel();
            }
            else if (childForm == playlistScr)
            {
                changeMenuButtonForeColor(playlist_button);
            }
            else if (childForm == artistScr)
            {
                changeMenuButtonForeColor(artists_button);
            }
            else if (childForm == albumsScr)
            {
                changeMenuButtonForeColor(albums_button);
            }
            else if (childForm == tracksScr)
            {
                changeMenuButtonForeColor(tracks_button);
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

        #region Searchbar

        //place holder
        //Got focus
        public void RemoveText(object sender, EventArgs e)
        {
            if (searchBar_textBox.Text == "Search")
            {
                searchBar_textBox.Text = "";
                searchBar_textBox.ForeColor = Color.White;
            }
        }

        //lost focus
        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBar_textBox.Text))
            {
                searchBar_textBox.Text = "Search";
                searchBar_textBox.ForeColor = Color.FromArgb(152, 162, 166);
            }
        }

        //search event

        private void searchBar_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
            {

                srchBox.doSearch(searchBar_textBox.Text);
                /*loadSingleChildForm(srchBox);*/
                openChildForm(srchBox);

            }
        }



        #endregion Searchbar

        //

        #region createplaylist

        private void createNewPlaylist_button_Click(object sender, EventArgs e)
        {
            CreatePL.ShowDialog();
        }

        //test

        #endregion createplaylist

        #region mo form login/register khi click vao account button

        private Login loginForm;

        private void account_button_Click(object sender, EventArgs e)
        {
            openChildForm(updatein4);
        }

        #endregion mo form login/register khi click vao account button

        #region progressBar

        private bool isFirstLaunch = true;

        private void SoundPlayer_PlayStateChange(int NewState)
        {
            if (soundPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                if (pause_button.Tag.ToString() == "play")
                    soundPlayer.controls.pause();
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
                if (loopMode == LoopMode.RepeatOne)
                {
                    soundPlayer.URL = soundPlayer.URL;
                }
                else
                {
                    next_button.PerformClick();
                }

                progressBar.EditValue = 0;
                onesec.Stop();
            }
            else if (soundPlayer.playState == WMPPlayState.wmppsReady)
            {
                if (soundPlayer.controls.currentItem == null || isFirstLaunch)
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

        private void playingFrom_label_TextChanged(object sender, EventArgs e)
        {
            songDetail.playingFrom_label.Text = playingFrom_label.Text;
        }
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
            return PlayList_FlowPanel;
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

        public void setAccountButtonUsername(string usrn)
        {
            account_button.Text = usrn;
        }

        public void setAccount(Account account)
        {
            currentUser = account;
        }

        #endregion get/set control, perform event

        //

        #region next/previous button event, chuyen bai

        public Stack previousTracks = new Stack();

        private void previous_button_Click(object sender, EventArgs e)
        {
            if (previousTracks.Count == 0)
            {
                MessageBox.Show("There is no previous track");
                return;
            }
            TrackInfo lastTrack = previousTracks.Pop() as TrackInfo;
            loadNewSong(lastTrack);
        }

        public int currentTrackIndex;
        public TrackInfo Dequeue()
        {
            if (nextTrack.Count == currentTrackIndex)
            {
                return null;
            }
            TrackInfo temp = nextTrack[currentTrackIndex++];
            /*nextTrack.RemoveAt(0);*/
            return temp;
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            if (!(loopMode == LoopMode.On) && currentTrackIndex == nextTrack.Count)
            {
                loadNewSong(new TrackInfo() { TrackLink = suggestedSong[0] });
                setplayfrom("Suggests");
            }
            else
            {
              
                if (loopMode == LoopMode.On && currentTrackIndex == nextTrack.Count)
                {
                    currentTrackIndex = 0;
                    
                    changeSong(Dequeue());
                }
                else
                {
                    changeSong(Dequeue());
                }
            }
        }


        public List<TrackInfo> nextTrack = new List<TrackInfo>();
        public void addTrackToQueue(TrackInfo track)
        {
            nextTrack.Add(track);
        }
        public void changeSong(TrackInfo track)
        {
            previousTracks.Push(currentTrack);
            loadNewSong(track);
            originalNextTrack = nextTrack;
        }


        #endregion next/previous button event
        //
        #region addplaylist
        private void addToPlaylist_Player_Button_Click(object sender, EventArgs e)
        {
            add2PL = new AddtoPlaylistForm(this, currentTrack.TrackID);
            add2PL.Show();
        }


        #endregion

        #region click event for playlist button

        public void menuPanelPlaylists_button_MouseClick(object sender, MouseEventArgs e)
        {
            PlaylistContainer playlistContainer = (sender as Button).Tag as PlaylistContainer;
            playlistContainer.opacity_panel_MouseClick(playlistContainer.opacity_panel, e);
        }




        #endregion

        #region next,back form button
        private void forwardForm_button_Click(object sender, EventArgs e)
        {
            if (nextFormStack.Count != 0)
            {
                if (activeForm != null)
                {
                    previousFormStack.Push(activeForm);
                }
                pushToPrevious = false;
                openChildForm(nextFormStack.Pop() as Form);
                pushToPrevious = true;
            }
        }


        private void backForm_button_Click(object sender, EventArgs e)
        {
            if (previousFormStack.Count == 0)
            {
                return;
            }
            if (activeForm != null)
            {
                nextFormStack.Push(activeForm);
            }
            pushToPrevious = false;
            openChildForm(previousFormStack.Pop() as Form);
            pushToPrevious = true;
        }

        #endregion

        #region add to loved track
        private void like_Player_Button_Click(object sender, EventArgs e)
        {


            if (currentTrack.IsLoved == false)
            {
                Database.addTrackToUserLikeTrack(CurrentUser.UserID, currentTrack.TrackID);
                currentTrack.IsLoved = true;
                like_Player_Button.BackgroundImage = Properties.Resources.liked;
                songDetail.like_Player_Button.BackgroundImage = Properties.Resources.liked;
                currentTrack.DateAdded = DateTime.Now.ToShortDateString();
                tracksScr.addRow(currentTrack);
            }
            else
            {
                Database.deleteTrackInUserLikeTrack(CurrentUser.UserID, currentTrack.TrackID);
                currentTrack.IsLoved = false;
                like_Player_Button.BackgroundImage = Properties.Resources.like;
                songDetail.like_Player_Button.BackgroundImage = Properties.Resources.like;
                tracksScr.deleteRow(currentTrack.TrackID);
            }


            //sau khi add vao track reload lai cac track trong  cacform
            myMixScr.reloadMixContainer();
            playlistScr.reloadPlaylistContainer();
            albumsScr.reloadAlbumContainer();
            artistScr.reloadArtistContainer();


        }



        public void checkLoved()
        {
            if (currentTrack == null)
            {
                return;
            }
            if (Database.checkIfTrackLoved(currentTrack.TrackID, CurrentUser.UserID))
            {
                currentTrack.IsLoved = true;
                like_Player_Button.BackgroundImage = Properties.Resources.liked;
                songDetail.like_Player_Button.BackgroundImage = Properties.Resources.liked;
            }
            else
            {
                currentTrack.IsLoved = false;
                like_Player_Button.BackgroundImage = Properties.Resources.like;
                songDetail.like_Player_Button.BackgroundImage = Properties.Resources.like;
            }
        }


        #endregion

        #region playfrom

        public void setplayfrom(string input)
        {

            playingFrom_label.Text = "Playing From : " + input;
            if (playingFrom_label.Text.Length > 24)
            {
                playingFrom_label.Text = playingFrom_label.Text.Substring(0, 24) + "...";
            }



        }
        #endregion

        #region repeatButton


        enum LoopMode
        {
            On,
            Off,
            RepeatOne

        }
        LoopMode loopMode;



        private void repeate_button_Click(object sender, EventArgs e)
        {
            if (repeat_button.Tag.ToString() == "off")
            {
                repeat_button.BackgroundImage = player_imageList.Images["repeat_on.png"];
                repeat_button.Tag = "on";
                loopMode = LoopMode.On;
            }
            else if (repeat_button.Tag.ToString() == "on")
            {
                repeat_button.BackgroundImage = player_imageList.Images["repeat1.png"];
                repeat_button.Tag = "1";
                loopMode = LoopMode.RepeatOne;

            }
            else if (repeat_button.Tag.ToString() == "1")
            {
                repeat_button.BackgroundImage = player_imageList.Images["repeat_off.png"];
                repeat_button.Tag = "off";
                loopMode = LoopMode.Off;

            }

            songDetail.repeat_button.BackgroundImage = repeat_button.BackgroundImage;

        }

        #endregion
    }
}