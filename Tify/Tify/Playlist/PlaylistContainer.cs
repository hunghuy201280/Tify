using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetData;

namespace Tify
{
    public partial class PlaylistContainer : UserControl
    {
        public PlaylistContainer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }
        public Playlist playlistFm;
        public string playlistID;
        public string description;
        public string playlistName;
        public string owner;
        private int trackCount;
        public PlaylistContainer(Playlist callform,string PLAYLIST_ID)
        {
            InitializeComponent();
            playlistID = PLAYLIST_ID;
            playlistFm = callform;
         



            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            //load trước track table
            trackTable_woker.RunWorkerAsync();
        }
        private bool isLoaded = false;

        //khi click vào opacity panel mới bắt đầu load các track trong playlist
        private void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (isLoaded)
            {
                playlistFm.playlistDetail.setDetailInfo(trackInfos, cover.ToArray(), true, this);
                return;
            }
            
            if (load_worker.IsBusy)
            {
                return;
            }
            loadInfo(playlistID);
        }


        private void trackTable_woker_DoWork(object sender, DoWorkEventArgs e)
        {
            trackTable = Database.getTrackInPlaylist(playlistID);
        }

        //load cover, tên playlist lúc chưa click vào
        private void trackTable_woker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (trackTable.Rows.Count != 0)
            {
                owner = trackTable.Rows[0]["name"].ToString();
                //number of tracks
                trackCount = trackTable
       .AsEnumerable()
       .Select(r => r.Field<string>("trackTitle"))
       .Distinct()
       .Count();
                numberOfTracks_label.Text = trackCount + " Tracks";


                createdBy_label.Text = "Created by " + owner;
                playlistName= trackTable.Rows[0]["playlistTitle"].ToString();
                playlistName_label.Text = playlistName;
                description = trackTable.Rows[0]["description"].ToString();
            }
        }


        //load các track trong playlist vào list trackinfos
        public void loadInfo(string playlistid)
        {
            load_worker.RunWorkerAsync();
        }
        private DataTable trackTable = new DataTable();
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private List<Image> cover = new List<Image>();

        //load các track trong playlist vào list trackinfos
        private void load_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string lastTrackID = "";
          
            foreach (DataRow track in trackTable.Rows)
            {

                if (track["trackID"].ToString() == lastTrackID && lastTrackID != "")
                {
                    trackInfos[trackInfos.Count - 1].Artist += ";" + track["artistName"].ToString();
                    
                }
                else
                {
                    TrackInfo temp = new TrackInfo();

                    if (cover.Count<4)
                    {
                        using (PictureBox pb = new PictureBox())
                        {
                            pb.Load(GetSongData.GetSongCover(track["trackLink"].ToString()));
                            cover.Add(pb.Image);
                        }
                    }
                 

                    temp.TrackID = track["trackID"].ToString();
                    temp.Artist = track["artistName"].ToString();
                    temp.Title = track["trackTitle"].ToString();
                    temp.TrackLink = track["trackLink"].ToString();
                    DateTime dateAdded = DateTime.Parse(track["dateAdded"].ToString());
                    temp.DateAdded = dateAdded.ToShortDateString();
                    if (Database.checkIfTrackLoved(temp.TrackID, playlistFm.mainScr.CurrentUser.UserID))
                    {
                        temp.IsLoved = true;
                    }
                    else
                    {
                        temp.IsLoved = false;
                    }

                    int[] duration = GetSongData.GetSongDuration(track["trackLink"].ToString());

                    //neu giay >=10
                    if (duration[1] >= 10)
                        temp.Time = duration[0] + ":" + duration[1];
                    else
                        temp.Time = duration[0] + ":0" + duration[1];
                    if (temp.Time == "0:00")
                    {
                        continue;
                    }

                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
            while (cover.Count < 4)
            {
                cover.Add(Properties.Resources.emptyplaylist);
            }
            isLoaded = true;
        }



        //sau khi load xong thì kiểm tra xem có lỗi không, nếu không thì set data vào playlist detail rồi mở form detail lên
        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                return;
            }

            playlistFm.playlistDetail.setDetailInfo(trackInfos, cover.ToArray(), true, this);
        }

       

        private void PlaylistContainer_Load(object sender, EventArgs e)
        {
            opacity_panel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void playlistCover_panel_MouseHover(object sender, EventArgs e)
        {
            opacity_panel.Visible = true;
        }

        private void opacity_panel_MouseLeave(object sender, EventArgs e)
        {
            opacity_panel.Visible = false;
        }

        #region addtrack to playlist
        DataTable tempTrackTable = new DataTable();
        public void addTrack(string trackID)
        {
            tempTrackTable = Database.getTrackBaseOnID(trackID);
            string lastTrackID = "";
            foreach (DataRow track in tempTrackTable.Rows)
            {

                if (track["trackID"].ToString() == lastTrackID && lastTrackID != "")
                {
                    trackInfos[trackInfos.Count - 1].Artist += ";" + track["artistName"].ToString();

                }
                else
                {
                    TrackInfo temp = new TrackInfo();

                    temp.TrackID = track["trackID"].ToString();
                    temp.Artist = track["artistName"].ToString();
                    temp.Title = track["trackTitle"].ToString();
                    temp.TrackLink = track["trackLink"].ToString();

                    temp.DateAdded = DateTime.Now.ToShortDateString();
                    if (Database.checkIfTrackLoved(temp.TrackID, playlistFm.mainScr.CurrentUser.UserID))
                    {
                        temp.IsLoved = true;
                    }
                    else
                    {
                        temp.IsLoved = false;
                    }

                    int[] duration = GetSongData.GetSongDuration(track["trackLink"].ToString());

                    //neu giay >=10
                    if (duration[1] >= 10)
                        temp.Time = duration[0] + ":" + duration[1];
                    else
                        temp.Time = duration[0] + ":0" + duration[1];
                    if (temp.Time == "0:00")
                    {
                        continue;
                    }

                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
            numberOfTracks_label.Text = ++trackCount + " Tracks";
        }
        #endregion

    }
}
