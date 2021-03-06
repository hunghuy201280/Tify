﻿using GetData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Tify
{
    internal class Database
    {

     
        static public DataTable getPlaylistTable_Search(string searchKeyWord)
        {
            string sqlQuery = "select * from Playlist where playlistTitle like '%" + searchKeyWord + "%'";

            /* string sqlQuery = "select top 20 *  " +
                "from Track where trackTitle like '%" + searchKeyWord + "%' order by trackID";*/
            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return Table;
        }
        static public void deleteLastTrackInRecentlyPlayed(int userID)
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            string sqlQuery = "delete from RecentlyPlayed where userID=@userID and trackID =( select top 1 trackID from RecentlyPlayed where userID=@userID1 order by stackIndex)";
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@userID1", userID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();

        }

        static public DataTable getRecentlyTrack(int userID)
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            DataTable table = new DataTable();
            string sqlQuery = "select * from RecentlyPlayed where userID=@userID order by stackIndex desc";
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            sqlconnection.Close();

            return table;
        }

        static public void addTrackToRecentlyPlayed(string trackID, int userID, string lastTrackID)
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            //delete new track
            string sqlQuery = "delete from RecentlyPlayed where userID=@userID and trackID=@trackID ";
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.Parameters.AddWithValue("@userID", userID);

                cmd.ExecuteNonQuery();
            }

            try
            {
                sqlQuery = "insert into RecentlyPlayed values(@userID,@trackID)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
                {
                    cmd.Parameters.AddWithValue("@trackID", lastTrackID);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            sqlconnection.Close();
        }


        static public void addArtistToUserFollowArtist(string artistID, int userID)
        {
            string sqlQuery = "insert into UserFollowArtist values(@userID,@artistID)";


            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                cmd.Parameters.AddWithValue("@userID", userID);

                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }
        static public void deleteArtistFromUserFollowArtist(string artistID, int userID)
        {
            string sqlQuery = "delete from UserFollowArtist where userID=@userID and artistID=@artistID";


            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }
        static public bool checkUserLikeArtist(string artistID, int userID)
        {
            string sqlQuery = "select count(*) from UserFollowArtist where userID=@userID and artistID=@artistID ";

            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                cmd.Parameters.AddWithValue("@userID", userID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return checkTable.Rows[0][0].ToString() == "1";
        }


        static public void addAlbumToUserLikeAlbum(string albumID, int userID)
        {
            string sqlQuery = "insert into UserLikeAlbum values(@userID,@albumID)";


            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@albumID", albumID);
                cmd.Parameters.AddWithValue("@userID", userID);

                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }


        static public void deleteAlbumFromUserLikeAlbum(string albumID, int userID)
        {
            string sqlQuery = "delete from UserLikeAlbum where userID=@userID and albumID=@albumID";


            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@albumID", albumID);
                cmd.Parameters.AddWithValue("@userID", userID);

                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }
        static public bool checkUserLikeAlbum(string albumID, int userID)
        {
            string sqlQuery = "select count(*) from UserLikeAlbum where albumID=@albumID and userID=@userID";

            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@albumID", albumID);
                cmd.Parameters.AddWithValue("@userID", userID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return checkTable.Rows[0][0].ToString() == "1";
        }


        static public string getTrackIdBaseOnTrackLink(string trackLink)
        {
            string sqlQuery = "select * from Track where trackLink=@trackLink";

            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackLink", trackLink);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return checkTable.Rows[0]["trackID"].ToString();
        }
        static public bool checkTrackExisted(string trackLink)
        {
            string sqlQuery = "select count(*) from Track where trackLink=@trackLink";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackLink", trackLink);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();
            if (Table.Rows[0][0].ToString() == "0")
            {
                return false;
            }
            return true;
        }


        static public string addTrackToDatabase(string trackUrl)
        {
            //string[0]=title,[1]=link
            string title = GetSongData.getTrackTitle(trackUrl);
            string sqlQuery = "insert into Track output inserted.trackID values(@trackTitle,@trackLink)";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@trackTitle", title);
                cmd.Parameters.AddWithValue("@trackLink", trackUrl);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            DataTable artistTable = new DataTable();
            ThreadPool.QueueUserWorkItem(delegate (object obj)
            {
                string[] artist = GetSongData.GetSongArtist(trackUrl);
                foreach (string item in artist)
                {
                    artistTable.Clear();
                    string temp = TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(item);
                    sqlQuery = "select * from Artist where artistName=@artistName";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
                    {
                        cmd.Parameters.AddWithValue("@artistName", temp);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            artistTable.Load(reader);
                        }
                    }
                    if (artistTable.Rows.Count != 0)
                    {
                        string artistID = artistTable.Rows[0]["artistID"].ToString();
                        sqlQuery = "insert into ArtistHasTrack values(@artistID,@trackID)";
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
                        {
                            cmd.Parameters.AddWithValue("@artistID", artistID);
                            cmd.Parameters.AddWithValue("@trackID", Table.Rows[0][0].ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                sqlconnection.Close();
            });
            return Table.Rows[0][0].ToString();
        }


        static public DataTable getAlbumOfArtist(string artistID)
        {
            string sqlQuery = "select Album.* from Album where artistID=@artistID";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();

            return Table;
        }

        static public DataTable getArtistBaseOnID(string artistID)
        {
            string sqlQuery = "select * from Artist where artistID=@artistID;";

            DataTable artistTab_Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTab_Table.Load(reader);
                }
            }
            sqlconnection.Close();

            return artistTab_Table;
        }
        static public bool checkIfPlaylistExisted(string playlistTitle, int userID)
        {
            string sqlQuery = "select * from UserHasPlaylist join Playlist on Playlist.playlistID=UserHasPlaylist.playlistID" +
           " where playlistTitle=@playlistTitle and userID=@userID";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistTitle", playlistTitle);
                cmd.Parameters.AddWithValue("@userID", userID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();

            if (Table.Rows.Count == 0)
            {
                return true;
            }
            else return false;
        }

        static public void createPlaylist(int userID, string playlistName, string description)
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            string sqlQuery = "INSERT INTO Playlist (playlistTitle,description,owner) OUTPUT inserted.playlistID VALUES(@playlistName,@description,@userID)";

            using (SqlCommand command = new SqlCommand(sqlQuery, sqlconnection))
            {
                command.Parameters.AddWithValue("@playlistName", playlistName);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            string newPlaylistID = reader[0].ToString();
                            sqlQuery = "insert into UserHasPlaylist values(@userID,@newPlaylistID)";
                            using (SqlCommand command1 = new SqlCommand(sqlQuery, sqlconnection))
                            {
                                command1.Parameters.AddWithValue("@userID", userID);
                                command1.Parameters.AddWithValue("@newPlaylistID", newPlaylistID);
                                command1.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            sqlconnection.Close();
        }

        static public void updateDOB(int userID, string newDOB)
        {
            string sqlQuery = "update Account  " +
                "set DOB = (select convert(datetime, @newDOB, 103)) " +
                "where userID = @userID";
            DateTime dob;
            try
            {
                dob = DateTime.Parse(newDOB);
            }
            catch (System.Exception)
            {
                throw;
            }

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@newDOB", dob.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        static public void updatePhone(int userID, string newPhone)
        {
            string sqlQuery = "update Account set phone=@newPhone where userID=@userID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@newPhone", newPhone);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        static public void updateName(int userID, string newName)
        {
            string sqlQuery = "update Account set name=@newName where userID=@userID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        static public void updatePassword(int userID, string newPassword)
        {
            string sqlQuery = "update Account set password=@newPassword where userID=@userID";

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        static public void deletePlaylist(string playlistID)
        {
            /*
             delete from UserHasPlaylist where playlistID=50

delete From PlaylistHasTrack where playlistID=50

delete From Playlist where playlistID=50
             */

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            string sqlQuery = "delete from UserHasPlaylist where playlistID=@playlistID";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                cmd.ExecuteNonQuery();
            }

            sqlQuery = "delete from PlaylistHasTrack where playlistID=@playlistID";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                cmd.ExecuteNonQuery();
            }
            sqlQuery = "delete from Playlist where playlistID=@playlistID";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        static public DataTable getTrack_Artist(string artistID)
        {
            string sqlQuery = "select Artist.*,Track.* from Artist " +
                "join ArtistHasTrack on Artist.artistID = ArtistHasTrack.artistID " +
                "join Track on Track.trackID = ArtistHasTrack.trackID " +
                "where Artist.artistID =@artistID ";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return Table;
        }
        static public DataTable getTrack_Artist(string spotifyID,int lol)
        {
            string sqlQuery = "select Artist.*,Track.* from Artist " +
                "join ArtistHasTrack on Artist.artistID = ArtistHasTrack.artistID " +
                "join Track on Track.trackID = ArtistHasTrack.trackID " +
                "where Artist.spotifyID =@spotifyID ";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@spotifyID", spotifyID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return Table;
        }

        static public DataTable getArtistInfo_Artist(string artistID)
        {
            string sqlQuery = "select * from Artist where artistID=@artistID";

            DataTable artistTab_Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@artistID", artistID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTab_Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return artistTab_Table;
        }

        static public DataTable getArtistThatUserFollow(int userID)
        {
            string sqlQuery = "select Artist.* from UserFollowArtist join Artist on Artist.artistID=UserFollowArtist.artistID where userID=@userID";

            DataTable Table = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Table.Load(reader);
                }
            }
            sqlconnection.Close();
            return Table;
        }

        static public DataTable getPlaylistInfo_NotIncludeDetail(string playlistID)
        {
            string sqlQuery = "select Account.name,Playlist.* from UserHasPlaylist join Playlist on Playlist.playlistID=UserHasPlaylist.playlistID  " +
                "join Account on Account.userID = UserHasPlaylist.userID " +
                "where Playlist.playlistID = @playlistID ";

            DataTable checkTable = new DataTable();

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    checkTable.Load(reader);
                }
            }
            sqlconnection.Close();
            return checkTable;
        }

        /* static public DataTable checkRelationshipWithPlaylistWhenDeleteLovedTrack(string trackID, int userID)
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
         }*/

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

        static public bool checkIfTrackLoved(string trackID, int userID)
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
            if (checkTable.Rows[0][0].ToString() == "0")
                return false;
            return true;
        }

        static public DataTable getTrackTable_Search(string searchKeyWord)
        {
            string sqlQuery = "select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn " +
                "from Track where trackTitle like '%" + searchKeyWord + "%') as temp where rn = 1";

            /* string sqlQuery = "select top 20 *  " +
                "from Track where trackTitle like '%" + searchKeyWord + "%' order by trackID";*/
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

        static public void AddTrackToPlaylist(string trackID, string playlistID)
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
               "left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID  " +
               "left join Artist on ArtistHasTrack.artistID = Artist.artistID   " +
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

        static public void addTrackToUserLikeTrack(int userID, string trackID)
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
                "left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID " +
                "left join Artist on ArtistHasTrack.artistID = Artist.artistID " +
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
                "left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID " +
                "left join Artist on Artist.artistID = ArtistHasTrack.artistID " +
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

        static public int getMyMixOrder(int userID, string mixID)
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

            int index = 0;
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

            string sqlQuery = "select Playlist.*from UserHasPlaylist " +
                "join Playlist on Playlist.playlistID = UserHasPlaylist.playlistID " +
                "where userID = @userID order by Playlist.playlistID asc; ";
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
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

            string sqlQuery = "select Track.*,Artist.* from Track left join  " +
                "ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID " +
                "left join Artist on Artist.artistID = ArtistHasTrack.artistID " +
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