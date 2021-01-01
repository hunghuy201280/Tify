using GetData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

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
        public int trackCount;

        public PlaylistContainer(Playlist callform, string PLAYLIST_ID,bool canDelete)
        {
            InitializeComponent();
            playlistID = PLAYLIST_ID;
            playlistFm = callform;

            this.DoubleBuffered = true;
            //load trước track table
            trackTable_woker.RunWorkerAsync();
            this.canDelete = canDelete;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

          
        }
        
        public PlaylistContainer(Playlist callform, string PLAYLIST_ID,Image chartCover)
        {
            InitializeComponent();
            playlistID = PLAYLIST_ID;
            playlistFm = callform;
            playlistCover_panel.BackgroundImage = chartCover;
            this.DoubleBuffered = true;
            //load trước track table
            isChart = true;
            canDelete = false;
            trackTable_woker.RunWorkerAsync();

            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }

        private bool isLoaded = false;
        bool isChart = false;
        public bool canDelete = false;

        //khi click vào opacity panel mới bắt đầu load các track trong playlist
        public void opacity_panel_MouseClick(object sender, MouseEventArgs e)
        {
            //khi click vào container, mở detail fm lên sau đó bring to front loading trong detail trong hàm loadinfo
            playlistFm.openChildForm(playlistFm.playlistDetail);

            if (isLoaded)
            {
                playlistFm.playlistDetail.setDetailInfo(trackInfos, cover.ToArray(), this,isChart);
                return;
            }

            if (load_worker.IsBusy)
            {
                return;
            }
            loadInfo();
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
                playlistName = trackTable.Rows[0]["playlistTitle"].ToString();
                playlistName_label.Text = playlistName;
                description = trackTable.Rows[0]["description"].ToString();
            }
            else if (trackTable.Rows.Count == 0)
            {
                DataTable PlaylistInfoTable = Database.getPlaylistInfo_NotIncludeDetail(playlistID);
                owner = PlaylistInfoTable.Rows[0]["name"].ToString();
                //number of tracks

                numberOfTracks_label.Text = 0 + " Tracks";

                createdBy_label.Text = "Created by " + owner;
                playlistName = PlaylistInfoTable.Rows[0]["playlistTitle"].ToString();
                playlistName_label.Text = playlistName;
                description = PlaylistInfoTable.Rows[0]["description"].ToString();
            }
        }

        //load các track trong playlist vào list trackinfos
        public void loadInfo()
        {
            //tự viết thêm hàm showloading,hideloading
            playlistFm.playlistDetail.showLoading();

            load_worker.RunWorkerAsync();
        }

        private DataTable trackTable = new DataTable();
        private List<TrackInfo> trackInfos = new List<TrackInfo>();
        private List<Image> cover = new List<Image>();
        public int timeInSec = 0;

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

                    temp.TrackID = track["trackID"].ToString();
                    temp.Artist = track["artistName"].ToString();

                    temp.Title = track["trackTitle"].ToString();
                    temp.TrackLink = track["trackLink"].ToString();
                    if (temp.Artist == "")
                    {
                        temp.Artist = GetSongData.loadArtist(temp.TrackLink);
                    }
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

                    TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(temp.TrackLink));

                    string timeString = time.ToString(@"mm\:ss");
                    temp.Time = timeString;

                    timeInSec += (int)time.TotalSeconds;
                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
            loadCover(true);
            isLoaded = true;
        }

        //sau khi load xong thì kiểm tra xem có lỗi không, nếu không thì set data vào playlist detail rồi mở form detail lên
        private void load_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                return;
            }

            playlistFm.playlistDetail.setDetailInfo(trackInfos, cover.ToArray(), this,isChart);
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

        #region load 4 cover

        public void loadCover(bool set)
        {
            cover.Clear();

            while (loadCover_worker.IsBusy) { }

            loadCover_worker.RunWorkerAsync(set);
        }

        private void loadCover_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int trackInfosIndex = 0;

            while (cover.Count < 4 && trackInfosIndex < trackInfos.Count)
            {
                using (PictureBox pb = new PictureBox())
                {
                    pb.Load(GetSongData.GetSongCover(trackInfos[trackInfosIndex++].TrackLink));
                    cover.Add(pb.Image);
                   
                }
            }
            while (cover.Count < 4)
            {
                cover.Add(Properties.Resources.emptyplaylist);
            }
            e.Result = e.Argument;
        }

        private void loadCover_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result.ToString() == "True")
            {
                playlistFm.playlistDetail.setCover(cover.ToArray());
            }
        }

        #endregion load 4 cover

        #region addtrack to playlist

        private DataTable tempTrackTable = new DataTable();

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
                    if (temp.Artist == "")
                    {
                        temp.Artist = GetSongData.loadArtist(temp.TrackLink);
                    }

                    temp.DateAdded = DateTime.Now.ToShortDateString();
                    if (Database.checkIfTrackLoved(temp.TrackID, playlistFm.mainScr.CurrentUser.UserID))
                    {
                        temp.IsLoved = true;
                    }
                    else
                    {
                        temp.IsLoved = false;
                    }

                    TimeSpan time = TimeSpan.FromSeconds(GetSongData.GetSongDuration(temp.TrackLink));

                    string timeString = time.ToString(@"mm\:ss");
                    temp.Time = timeString;
                    timeInSec += (int)time.TotalSeconds;
                    trackInfos.Add(temp);
                    lastTrackID = track["trackID"].ToString();
                }
            }
            loadCover(false);
            numberOfTracks_label.Text = ++trackCount + " Tracks";
            if (playlistFm.playlistDetail.playlistContainer == this && !(playlistFm.mainScr.Controls[0] is SongDetail))
                playlistFm.playlistDetail.setDetailInfo(trackInfos, cover.ToArray(), this,isChart);
        }

        public void addTrack(List<TrackInfo> tracks)
        {
            int insertedTrackCount=0;
            foreach (TrackInfo track in tracks)
            {
            
                if (trackInfos.Where(Track => (Track.Title == track.Title)).Count()==0)
                {
                    TrackInfo temp = track;

                    temp.DateAdded = DateTime.Now.ToShortDateString();



                    TimeSpan time = TimeSpan.ParseExact(temp.Time, "mm\\:ss", CultureInfo.InvariantCulture);

                    timeInSec += (int)time.TotalSeconds;
                    trackInfos.Add(temp);
                    insertedTrackCount++;
                }
            }

        loadCover(false);
        trackCount += insertedTrackCount;
        numberOfTracks_label.Text = trackCount + " Tracks";
            if (playlistFm.playlistDetail.playlistContainer == this && !(playlistFm.mainScr.Controls[0] is SongDetail))
                playlistFm.playlistDetail.setDetailInfo(trackInfos, cover.ToArray(), this,isChart);
        }

    #endregion addtrack to playlist

    #region reload when unlike track

    public void reloadStatus()
    {
        //reload_worker.RunWorkerAsync();
        new Thread(() =>
        {
            reload();
        }).Start();
    }

    private void reload()
    {
        foreach (var track in trackInfos)
        {
            if (Database.checkIfTrackLoved(track.TrackID, playlistFm.mainScr.CurrentUser.UserID))
            {
                track.IsLoved = true;
            }
            else if (!Database.checkIfTrackLoved(track.TrackID, playlistFm.mainScr.CurrentUser.UserID))
            {
                track.IsLoved = false;
            }
        }
    }

    private void reload_worker_DoWork(object sender, DoWorkEventArgs e)
    {
        foreach (var track in trackInfos)
        {
            if (Database.checkIfTrackLoved(track.TrackID, playlistFm.mainScr.CurrentUser.UserID))
            {
                track.IsLoved = true;
            }
            else if (!Database.checkIfTrackLoved(track.TrackID, playlistFm.mainScr.CurrentUser.UserID))
            {
                track.IsLoved = false;
            }
        }
    }

    private void reload_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
    }

    #endregion reload when unlike track
}
}