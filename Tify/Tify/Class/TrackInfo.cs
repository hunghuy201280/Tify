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
        private string title, artist, time,trackID,trackLink,dateAdded;
        private bool isLoved;
        private Image cover;
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
        public Image Cover { get => cover; set => cover = value; }
        public string TrackLink { get => trackLink; set => trackLink = value; }


        //use in track tab
        public string DateAdded { get => dateAdded; set => dateAdded = value; }
        public bool IsLoved { get => isLoved; set => isLoved = value; }
    }
}
