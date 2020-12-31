using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GetData;
using System.Threading;

namespace Tify
{
    public partial class SuggestSong : UserControl
    {
        public SuggestSong()
        {
            InitializeComponent();

            hideScrollBar();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        Home homeScr;
   


        string trackID;
        public void setInfo(Home homeScr, string trackID)
        {
            this.homeScr = homeScr;
            this.trackID = trackID;
            if (suggestedSong_worker.IsBusy)
            {
                return;
            }
            loading_SplashScreen1.BringToFront();
            suggestedSong_worker.RunWorkerAsync();
        }

        TrackInfo mainTrack = new TrackInfo();
        #region scroll Button
        private const int WM_SCROLL = 276; // Horizontal scroll
        private const int SB_LINELEFT = 0; // Scrolls one cell left
        private const int SB_LINERIGHT = 1; // Scrolls one line right

        private void hideScrollBar()
        {
            suggested_flowLayoutPanel.AutoScroll = false;
            suggested_flowLayoutPanel.HorizontalScroll.Maximum = 0;
            suggested_flowLayoutPanel.AutoScrollPosition = new Point(0, 0);
            suggested_flowLayoutPanel.AutoScroll = true;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);


        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                SendMessage(this.suggested_flowLayoutPanel.Handle, WM_SCROLL, (IntPtr)(int)timer1.Tag, IntPtr.Zero);
            }
        }

        private void scroll_Button_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            if (sender == forward_Button)
            {
                timer1.Tag = 1;
            }
            else
            {
                timer1.Tag = 0;
            }
        }

        private void scroll_Button_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }



        #endregion

        public TrackInfo loadTrackInfo(string trackID)
        {
            TrackInfo track = new TrackInfo();
            track.TrackID = trackID;
            DataTable infoTable = Database.getTrackBaseOnID(track.TrackID);
            string lastTrackID = "";
            foreach (DataRow Track in infoTable.Rows)
            {
                if (Track["trackID"].ToString() == lastTrackID && lastTrackID != "")
                {
                    track.Artist += ";" + Track["artistName"].ToString();
                }
                else
                {


                    track.Artist = Track["artistName"].ToString();
                    track.Title = Track["trackTitle"].ToString();
                    track.TrackLink = Track["trackLink"].ToString();
                    if (track.Artist == "")
                    {
                        track.Artist = GetSongData.loadArtist(track.TrackLink);
                    }
                    using (PictureBox pb = new PictureBox())
                    {
                        pb.Load(GetSongData.GetSongCover(track.TrackLink));
                        track.Cover = pb.Image;
                    }

                    if (Database.checkIfTrackLoved(track.TrackID, homeScr.mainScr.CurrentUser.UserID))
                    {
                        track.IsLoved = true;
                    }
                    else
                    {
                        track.IsLoved = false;
                    }

                    TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(track.TrackLink));

                    string timeString = time.ToString(@"mm\:ss");
                    track.Time = timeString;


                    lastTrackID = track.TrackID;
                }
            }


            return track;
        }

        ManualResetEvent mrse = new ManualResetEvent(false);
        private void suggestedSong_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            mainTrack = loadTrackInfo(trackID);
            this.BeginInvoke((Action)delegate ()
            {
                songName_label.Text = mainTrack.Title;
                songCover_picturebox.Image=(mainTrack.Cover);
            });
            string[] songUrl = GetSongData.GetSuggetSongs(mainTrack.TrackLink);
            e.Result = songUrl;

           
          
            TrackInfo track = new TrackInfo();
            for (int i = 0; i < 10; i++)
            {
                track.TrackLink = songUrl[i];

                if (!Database.checkTrackExisted(track.TrackLink))
                {
                  
                    track.TrackID = Database.addTrackToDatabase(track.TrackLink);
                    track.IsLoved = false;

                }
                else
                {
                    track.TrackID = Database.getTrackIdBaseOnTrackLink(track.TrackLink);

                }
                this.BeginInvoke((Action)delegate ()
                {
                    temp.Add(new TrackContainer_Home(track.TrackID, homeScr.mainScr));
                    mrse.Set();
                });
                mrse.WaitOne();

                
            }


        }
        List<TrackContainer_Home> temp = new List<TrackContainer_Home>();
      
        private void suggestedSong_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
         
            suggested_flowLayoutPanel.Controls.AddRange(temp.ToArray());
            loading_SplashScreen1.SendToBack();

        }
    }




}
