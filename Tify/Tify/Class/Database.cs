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
            using (SqlCommand cmd = new SqlCommand("select * from UserHasMix where userID=8 order by myMixID asc;", sqlconnection))
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
    }
  

}
