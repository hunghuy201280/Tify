using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tify
{
    public class TrackInfo
    {
        private string title, artist, time,trackID;

        private Bitmap cover;
        public TrackInfo(string title,string artist,string time)
        {
            this.title = title;
            this.artist = artist;
            this.time = time;
        }
        public TrackInfo()
        {
            
        }

        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Time { get => time; set => time = value; }
        public string TrackID { get => trackID; set => trackID = value; }
        public Bitmap Cover { get => cover; set => cover = value; }
    }
}
