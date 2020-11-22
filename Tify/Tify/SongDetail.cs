using System;
using System.Drawing;
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
            songDetail_panel.Visible = false;
        }

        public Label getDuration_Label()
        {
            return duration_label;
        }

        public Label getCurrentTime_Label()
        {
            return currentTime_label;
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
    }
}