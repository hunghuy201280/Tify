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
        
        public TrackInfo(TrackInfo copy)
        {
            title = copy.title;
            artist = copy.artist;
            time = copy.time;
            trackID = copy.trackID;
            trackLink = copy.trackLink;
            dateAdded = copy.dateAdded;
            IsLoved = copy.isLoved;
            cover = copy.cover;
                
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
