using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    //Recently,chart,mix for you,
    //2 cai because you listened to
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
        public MainScreen mainScr = null;
        bool firstLoad = true;
        public Home(MainScreen parentForm)
        {
            
            InitializeComponent();
            mainScr = parentForm;
            
           
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Size=new Size(mainScr.childForm_panel.Size.Width - 16, mainScr.childForm_panel.Height - 39);
            //MainScreen.hideScrollBar(flowLayoutPanel1, "flow");
            DoubleBuffered = true;

            mixesForYou.setContainerName("Mixes For You");
            theCharts.setContainerName("The Charts");


          
        }


        #region recentlyPlayed 
        DataTable recentlyTable;
        public void loadRecentlyPlayed()
        {
            trackContainers.Clear();
            recentlyTable = Database.getRecentlyTrack(mainScr.CurrentUser.UserID);
            ThreadPool.QueueUserWorkItem(delegate (object obj)
            {
                if (recentlyTable.Rows.Count > 50)
                {
                    Database.deleteLastTrackInRecentlyPlayed(mainScr.CurrentUser.UserID);
                }
            });
            if (firstLoad)
            {
                Random rndSuggest = new Random(DateTime.Now.Second);

                string trackID1 = "", trackID2 = "";

                if (recentlyTable.Rows.Count > 15)
                {
                    trackID1 = recentlyTable.Rows[rndSuggest.Next(16, recentlyTable.Rows.Count)]["trackID"].ToString();
                    while (trackID1 == trackID2 || trackID2 == "")
                    {
                        trackID2 = recentlyTable.Rows[rndSuggest.Next(16, recentlyTable.Rows.Count)]["trackID"].ToString();
                    }
                    suggestSong1.setInfo(this, trackID1);
                    suggestSong2.setInfo(this, trackID2);
                }
                else
                {
                    suggestSong1.Hide();
                    suggestSong2.Hide();
                }

                firstLoad = false;  
            }
        
            
            foreach (DataRow row in recentlyTable.Rows)
            {
                if (trackContainers.Count>15)
                {
                    break;
                }
                trackContainers.Add(new TrackContainer_Home(row["trackID"].ToString(), mainScr));
            }
            recentlyPlayed.clearItem();
            recentlyPlayed.addRangeItem(trackContainers.ToArray());
           
        }
        public List<TrackContainer_Home> trackContainers = new List<TrackContainer_Home>();


        #endregion

        //test
        #region load my mix
        private Control[] mixs;
        public void addToMix(Control[] mixs)
        {
            this.mixs = mixs;
            mixesForYou.addRangeItem(mixs);
        }
        public void reAddMix()
        {
            mixesForYou.addRangeItem(mixs);
        }
        #endregion










    }
}
