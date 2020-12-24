using GetData;
using ReccomendTrackContainer;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Tify
{
    public partial class SongDetail : Form
    {
        public SongDetail()
        {
            InitializeComponent();
        }

        private MainScreen mainscr;
        private WindowsMediaPlayer soundPlayer;
        private Panel songDetail_panel;

        public SongDetail(MainScreen callForm)
        {
            InitializeComponent();
            mainscr = callForm;
            songDetail_panel = mainscr.getSongDetailPanel();
            soundPlayer = mainscr.getSoundPlayer();
            MainScreen.hideScrollBar(suggestedTracks_flowPanel, "flow");

            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        #region progressBar

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
            double MousePosition = e.X;
            double ratio = MousePosition / progressBar.Size.Width;
            double ProgressBarValue = ratio * progressBar.Properties.Maximum;

            progressBar.EditValue = (int)ProgressBarValue;
            soundPlayer.controls.currentPosition = (int)progressBar.EditValue;
            mainscr.setProgressBar_Value(ratio);
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

        #endregion progressBar

        private void songDetailMinimize_button_Click(object sender, EventArgs e)
        {
            songDetail_panel.SendToBack();
            mainscr.MinimumSize = new Size(774, 361);
        }

 

        public void setDuration_Label(string text)
        {
            duration_label.Text = text;
        }

        public void setCurrentTime_Label(string text)
        {
            currentTime_label.Text = text;
        }

        public void setTitle_Label(string text)
        {
            title_label.Text = text;
        }

        public void setArtist_Label(string text)
        {
            artist_label.Text = text;
        }

        public void setPositionOfProgessBar(double ratio)
        {
            double ProgressBarValue = ratio * progressBar.Properties.Maximum;

            progressBar.EditValue = (int)ProgressBarValue;
        }

        public void setPause_Button_Img(Image img)
        {
            pause_button.BackgroundImage = img;
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            mainscr.pause_button_PerformClick();
        }

        private void shuffle_button_Click(object sender, EventArgs e)
        {
            mainscr.shuffle_button_PerformClick();
        }

        public void setShuffle_Button_Img(Image img)
        {
            shuffle_button.BackgroundImage = img;
        }

        public void setVolume_Button_Img(Image img)
        {
            volume_detailButton.BackgroundImage = img;
        }

        private void volume_detailButton_Click(object sender, EventArgs e)
        {
            mainscr.volume_button_PerformClick();
        }

        public void setVolume_Trackbar_Value(int value)
        {
            volume_trackBar.Value = value;
        }

        private void volume_trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (volume_trackBar.Focused == true)
                mainscr.setVolume_trackBarVolume(volume_trackBar.Value);
        }

        public void setProgressBar_Maximum(int val)
        {
            progressBar.Properties.Maximum = val;
        }

        public void setSongCover_detailPictureBox(Image img)
        {
            songCover_detailPictureBox.Image = img;
        }

        //form resize
        private void SongDetail_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width < 1250)
            {
                songDetail_rightPanel.Visible = false;
                separator_panel.Hide();
            }
            else
            {
                songDetail_rightPanel.Visible = true;
                separator_panel.Show();
            }
        }

        #region setSuggestedSong

        public void setSuggestedSong(string[] songUrl)
        {
            suggestedTracks_flowPanel.Controls.Clear();
            if (loadSuggestedTracks_backgroundWorker.IsBusy==false)
            {
                loading_SplashScreen1.BringToFront();
                loadSuggestedTracks_backgroundWorker.RunWorkerAsync(songUrl);

            }
        }

        #endregion setSuggestedSong

        private void next_button_Click(object sender, EventArgs e)
        {
            mainscr.getNext_Button().PerformClick();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            mainscr.getPrevious_Button().PerformClick();
        }

 

        private void loadSuggestedTracks_backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ReccommendTrackControl[] temp = new ReccommendTrackControl[10];
            string[] songUrl = e.Argument as string[];
            for (int i = 0; i < 10; i++)
            {
                //debug

              /*  mainscr.debug.BeginInvoke((Action)delegate () {
                    mainscr.debug.richTextBox1.Text += songUrl[i] + "\n\n";

                });*/

                //
                string url = songUrl[i];
                temp[i] = new ReccommendTrackControl(mainscr);
                string[] artists = GetSongData.GetSongArtist(url);
                string name = string.Empty;
                foreach (string artist in artists)
                {
                    name += artist + ";";
                }
                temp[i].setSongArtist(name);
                temp[i].Url = url;
                PictureBox tempbx = new PictureBox();
                tempbx.Load(GetSongData.GetSongCover(url));
                temp[i].setSongCover(tempbx.Image);
                temp[i].setSongName(GetSongData.GetSongName(url));


               
            }
            e.Result = temp;
        }

        private void loadSuggestedTracks_backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error==null)
            {
                
                if (suggestedTracks_flowPanel.Controls.Count != 0)
                {
                    suggestedTracks_flowPanel.Controls.Clear();
                }
                suggestedTracks_flowPanel.Controls.AddRange(e.Result as ReccommendTrackControl[]);
            }
            loading_SplashScreen1.SendToBack();
        }

        private void addToPlaylist_Player_Button_Click(object sender, EventArgs e)
        {
            mainscr.addToPlaylist_Player_Button.PerformClick();
        }

        private void like_Player_Button_Click(object sender, EventArgs e)
        {
            mainscr.like_Player_Button.PerformClick();
        }

        private void repeat_button_Click(object sender, EventArgs e)
        {
            mainscr.repeat_button.PerformClick();
        }
    }
}