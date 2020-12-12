using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tify
{
    class PlaylistInfo
    {
        private string playlistName, playlistID;
        private List<TrackInfo> tracks;

        public PlaylistInfo(string playlistid)
        {
            this.playlistID = playlistid;
        }
    }
}
