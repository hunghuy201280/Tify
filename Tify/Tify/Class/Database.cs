using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tify
{
    class Database
    {

        static public DataTable checkRelationshipWithPlaylistWhenDeleteLovedTrack(string trackID, int userID)
        {
            string sqlQuery = "select distinct UserHasPlaylist.playlistID from UserLikeTrack " +
                "join UserHasPlaylist on UserLikeTrack.userID = UserHasPlaylist.userID " +
                "join PlaylistHasTrack  on PlaylistHasTrack.trackID = UserLikeTrack.trackID " +
                "and UserHasPlaylist.playlistID = PlaylistHasTrack.playlistID " +
                "where UserLikeTrack.userID = @userID and UserLikeTrack.trackID = @trackID";


            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return checkTable;
        }
        static public DataTable checkRelationshipWithMyMixWhenDeleteLovedTrack(string trackID, int userID)
        {
            string sqlQuery = "select distinct UserHasMix.myMixID from UserLikeTrack  " +
                "join UserHasMix on UserLikeTrack.userID = UserHasMix.userID " +
                "join MyMixHasTrack  on MyMixHasTrack.trackID = UserLikeTrack.trackID and UserHasMix.myMixID = MyMixHasTrack.myMixID " +
                "where UserLikeTrack.userID = @userID and UserLikeTrack.trackID = @trackID";


            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return checkTable;
        }
        static public void deleteTrackInUserLikeTrack(int userID, string trackID)
        {
            string sqlQuery = "delete from UserLikeTrack where userID=@userID and trackID=@trackID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }
        static public bool checkIfTrackLoved(string trackID,int userID)
        {
            string sqlQuery = "select count(*) from UserLikeTrack where trackID=@trackID and userID=@userID";


            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            if (checkTable.Rows[0][0].ToString()=="0")
                return false;
            return true;
        }
        static public DataTable getTrackTable_Search(string searchKeyWord)
        {
            string sqlQuery = "select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn " +
                "from Track where trackTitle like '%" + searchKeyWord + "%') as temp where rn = 1";


            DataTable trackTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
              
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    trackTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return trackTable;

        }

        static public DataTable getAlbumTable_Search(string searchKeyWord)
        {
            string sqlQuery = "select top 20 Album.*,artistName from Album join Artist on Album.artistID=Artist.artistID" +
                    " where albumTitle like '%" + searchKeyWord + "%'";


            DataTable albumTab_Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    albumTab_Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return albumTab_Table;

        }

        static public DataTable getArtistTable_Search(string searchKeyWord)
        {
            string sqlQuery = "select top 20 * from Artist where artistName like '%" + searchKeyWord + "%'";


            DataTable artistTab_Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTab_Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return artistTab_Table;

        }

        static public void AddTrackToPlaylist(string trackID,string playlistID)
        {
            string sqlQuery = "insert into PlaylistHastrack values(@trackID, @playlistID,getdate())";

            

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }
        static public DataTable getArtistOfTrack(string trackID)
        {
            string sqlQuery = "select artistName from Track join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID " +
                "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
                "where Track.trackID = @id";

            DataTable artistTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@id", trackID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return artistTable;

        }

        static public DataTable loadTrackTableInTracks(int userID)
        {
            string sqlQuery = "select userID,dateAdded,Track.*,artistName,Artist.artistID from UserLikeTrack join Track on Track.trackID=UserLikeTrack.trackID " +
               "join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID  " +
               "join Artist on ArtistHasTrack.artistID = Artist.artistID   " +
               "where userID = @id order by trackTitle";

            DataTable trackTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@id", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    trackTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return trackTable;

        }
        static public void addTrackToUserLikeTrack(int userID,string trackID)
        {


            string sqlQuery = "insert into UserLikeTrack values(@userID,@trackID,getdate())";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@trackID", trackID);
                
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

   

        static public DataTable getTrackInMyMix(string mixID)
        {
            DataTable trackTable = new DataTable();

            string sqlQuery = "select * from  " +
              "MyMix join MyMixHasTrack on MyMix.myMixID = MyMixHasTrack.myMixID " +
              "join Track on Track.trackID = MyMixHasTrack.trackID " +
              "join ArtistHasTrack on Track.trackID = ArtistHasTrack.trackID " +
              "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
              "where MyMix.myMixID = @id order by trackTitle; ";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@id", mixID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    trackTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return trackTable;
        }

        static public DataTable getTrack_Album(string albumID)
        {
            DataTable trackTable = new DataTable();

            string sqlQuery = "select Album.*,Track.*,Artist.artistName,Artist.artistID artistLink,spotifyID from Album " +
                "join AlbumHasTrack on Album.albumID = AlbumHasTrack.albumID " +
                "join Track on Track.trackID = AlbumHasTrack.trackID " +
                "join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID " +
                "join Artist on ArtistHasTrack.artistID = Artist.artistID " +
                "where Album.albumID = @albumID order by Track.trackID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@albumID", albumID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    trackTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return trackTable;
        }


        static public DataTable getTrackInPlaylist(string playlistID)
        {
            DataTable trackTable = new DataTable();

            string sqlQuery = "select Playlist.*,Track.*,Artist.*,Account.*,dateAdded from Playlist " +
                "join PlaylistHasTrack  on PlaylistHasTrack.playlistID = Playlist.playlistID " +
                "join Track on Track.trackID = PlaylistHasTrack.trackID " +
                "join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID " +
                "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
                "join Account on Account.userID = Playlist.owner " +
                "where Playlist.playlistID = @playlistID order by trackTitle";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    trackTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return trackTable;
        }

        



        static public DataTable getArtistInMyMixContainer(string mixID)
        {
            DataTable artistTable = new DataTable();

            string sqlQuery = "select distinct artistName from  " +
               "MyMix join MyMixHasTrack on MyMix.myMixID = MyMixHasTrack.myMixID " +
               "join Track on Track.trackID = MyMixHasTrack.trackID " +
               "join ArtistHasTrack on Track.trackID = ArtistHasTrack.trackID " +
               "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
               "where MyMix.myMixID = @id; ";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@id", mixID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return artistTable;
        }

        static public int getMyMixOrder(int userID,string mixID)
        {
            DataTable mixTable = new DataTable();



            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand("select * from UserHasMix where userID=@userid order by myMixID asc ", sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userid", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    mixTable.Load(reader);
                }
            }

            int index=0;
            for (int i = 0; i < mixTable.Rows.Count; i++)
            {
                if (mixTable.Rows[i]["myMixID"].ToString() == mixID)
                {
                    index = i + 1;
                    break;
                }
            }
            sqlconnection.Close();

            return index;
        }


        static public DataTable getMyMixTableInMyMix(int userID)
        {
            DataTable mixTable = new DataTable();



            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand("select * from UserHasMix where userID=@userID order by myMixID asc;", sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    mixTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return mixTable;
        }

        static public DataTable getAlbumTable_Album(int userID)
        {
            DataTable albumTable = new DataTable();


            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand("select * from UserLikeAlbum where userID=@userID;", sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    albumTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return albumTable;
        }

        static public DataTable getPlaylistTable_Playlist(int userID)
        {
            DataTable mixTable = new DataTable();


            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand("select * from UserHasPlaylist where userID=8 order by playlistID asc;", sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    mixTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return mixTable;
        }


        static public DataTable getTrackBaseOnID(string trackID)
        {
            DataTable tempTable = new DataTable();
            
            string sqlQuery= "select Track.*,Artist.* from Track join  " +
                "ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID " +
                "join Artist on Artist.artistID = ArtistHasTrack.artistID " +
                "where Track.trackID = @trackID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackID", trackID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tempTable.Load(reader);
                }
            }
            sqlconnection.Close();

            return tempTable;
        }


        static public void deleteTrackFromPlaylist(string playlistID, string trackID)
        {
            string sqlQuery = "delete from PlaylistHasTrack where playlistID=@playlistID and trackID=@trackID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }



    }
  

}
