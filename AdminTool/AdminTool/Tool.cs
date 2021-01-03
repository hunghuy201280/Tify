using CsQuery;
using GetData;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Tify;

namespace AdminTool
{
    /*

         --viet nam 87,88 US UK,88 Chinese, 90 Korea, 91 Japanese
        tifyadmin -15
    */

    public partial class Tool : Form
    {
        private string connectionString;
        private DataTable artistTable = new DataTable();

        public Tool()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string sqlQuery = "select * from Artist";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    artistTable.Load(reader);
                }
            }
            sqlconnection.Close();
        }

        #region update chart

        private void deleteTrackInPlaylist(string playlistID)
        {
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string sqlQuery = "delete from PlaylistHasTrack where playlistID=@playlistID";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@playlistID", playlistID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        private int progress = 0;
        private int totalProgress = 100;
        private object locker = new object();

        #region Vietnam

        private void loadVietNamChart()
        {
            string playlistID = "87";
            deleteTrackInPlaylist(playlistID);
            string url = "https://chiasenhac.vn/nhac-hot/vietnam.html";
            CQ dom = CQ.CreateFromUrl(url);
            for (int i = 1; i < 21; i++)
            {
                Monitor.Enter(locker);
                try
                {
                    VietNamChart_worker.ReportProgress((int)((++progress * 1.0f / totalProgress) * 100));
                }
                catch (System.Exception)
                {
                }
                finally
                {
                    Monitor.Exit(locker);
                }
                string realUrl = dom[@"div.music_recommendation div.d-table div[id*='music-listen']:nth-of-type(" + i + ") div.tool ul li:nth-of-type(1) a"].Attr("href");
                string trackID;
                if (Database.checkTrackExisted(realUrl))
                {
                    trackID = Database.getTrackIdBaseOnTrackLink(realUrl);
                }
                else
                {
                    trackID = Database.addTrackToDatabase(realUrl);
                }
                Database.AddTrackToPlaylist(trackID, playlistID);
            }
        }

        private void VietNamChart_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            loadVietNamChart();
        }

        private void VietNamChart_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Created Vietnamese chart");
        }

        #endregion Vietnam

        #region USUK

        private void loadUSUKChart()
        {
            string playlistID = "88";
            deleteTrackInPlaylist(playlistID);
            string url = "https://chiasenhac.vn/nhac-hot/us-uk.html";
            CQ dom = CQ.CreateFromUrl(url);
            for (int i = 1; i < 21; i++)
            {
                Monitor.Enter(locker);
                try
                {
                    USUKChart_worker.ReportProgress((int)((++progress * 1.0f / totalProgress) * 100));
                }
                catch (System.Exception)
                {
                }
                finally
                {
                    Monitor.Exit(locker);
                }
                string realUrl = dom[@"div.music_recommendation div.d-table div[id*='music-listen']:nth-of-type(" + i + ") div.tool ul li:nth-of-type(1) a"].Attr("href");
                string trackID;
                if (Database.checkTrackExisted(realUrl))
                {
                    trackID = Database.getTrackIdBaseOnTrackLink(realUrl);
                }
                else
                {
                    trackID = Database.addTrackToDatabase(realUrl);
                }
                Database.AddTrackToPlaylist(trackID, playlistID);
            }
        }

        private void USUKChart_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            loadUSUKChart();
        }

        private void USUKChart_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Created USUK chart");
        }

        #endregion USUK

        #region Chinese

        private void loadChineseChart()
        {
            string playlistID = "89";
            deleteTrackInPlaylist(playlistID);
            string url = "https://chiasenhac.vn/nhac-hot/chinese.html";
            CQ dom = CQ.CreateFromUrl(url);
            for (int i = 1; i < 21; i++)
            {
                Monitor.Enter(locker);
                try
                {
                    VietNamChart_worker.ReportProgress((int)((++progress * 1.0f / totalProgress) * 100));
                }
                catch (System.Exception)
                {
                }
                finally
                {
                    Monitor.Exit(locker);
                }
                string realUrl = dom[@"div.music_recommendation div.d-table div[id*='music-listen']:nth-of-type(" + i + ") div.tool ul li:nth-of-type(1) a"].Attr("href");
                string trackID;
                if (Database.checkTrackExisted(realUrl))
                {
                    trackID = Database.getTrackIdBaseOnTrackLink(realUrl);
                }
                else
                {
                    trackID = Database.addTrackToDatabase(realUrl);
                }
                Database.AddTrackToPlaylist(trackID, playlistID);
            }
        }

        private void ChineseChart_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            loadChineseChart();
        }

        private void ChineseChart_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Created Chinese chart");
        }

        #endregion Chinese

        private void VietNamChart_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.EditValue = e.ProgressPercentage;
        }

        #region Korea

        private void KoreaChart_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string playlistID = "90";
            deleteTrackInPlaylist(playlistID);
            string url = "https://chiasenhac.vn/nhac-hot/korea.html";
            CQ dom = CQ.CreateFromUrl(url);
            for (int i = 1; i < 21; i++)
            {
                Monitor.Enter(locker);
                try
                {
                    VietNamChart_worker.ReportProgress((int)((++progress * 1.0f / totalProgress) * 100));
                }
                catch (System.Exception)
                {
                }
                finally
                {
                    Monitor.Exit(locker);
                }
                string realUrl = dom[@"div.music_recommendation div.d-table div[id*='music-listen']:nth-of-type(" + i + ") div.tool ul li:nth-of-type(1) a"].Attr("href");
                string trackID;
                if (Database.checkTrackExisted(realUrl))
                {
                    trackID = Database.getTrackIdBaseOnTrackLink(realUrl);
                }
                else
                {
                    trackID = Database.addTrackToDatabase(realUrl);
                }
                Database.AddTrackToPlaylist(trackID, playlistID);
            }
        }

        private void KoreaChart_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Created Korea chart");
        }

        #endregion Korea

        #region Japan

        private void JapaneseChart_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string playlistID = "91";
            deleteTrackInPlaylist(playlistID);
            string url = "https://chiasenhac.vn/nhac-hot/japan.html";
            CQ dom = CQ.CreateFromUrl(url);
            for (int i = 1; i < 21; i++)
            {
                Monitor.Enter(locker);
                try
                {
                    VietNamChart_worker.ReportProgress((int)((++progress * 1.0f / totalProgress) * 100));
                }
                catch (System.Exception)
                {
                }
                finally
                {
                    Monitor.Exit(locker);
                }
                string realUrl = dom[@"div.music_recommendation div.d-table div[id*='music-listen']:nth-of-type(" + i + ") div.tool ul li:nth-of-type(1) a"].Attr("href");
                string trackID;
                if (Database.checkTrackExisted(realUrl))
                {
                    trackID = Database.getTrackIdBaseOnTrackLink(realUrl);
                }
                else
                {
                    trackID = Database.addTrackToDatabase(realUrl);
                }
                Database.AddTrackToPlaylist(trackID, playlistID);
            }
        }

        private void JapaneseChart_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Created Japanese chart");
        }

        #endregion Japan

        private void button1_Click(object sender, System.EventArgs e)
        {
            VietNamChart_worker.RunWorkerAsync();
            USUKChart_worker.RunWorkerAsync();
            ChineseChart_worker.RunWorkerAsync();
            KoreaChart_worker.RunWorkerAsync();
            JapaneseChart_worker.RunWorkerAsync();
        }

        #endregion update chart

        #region create mix for user

        private void createMix_button_Click(object sender, System.EventArgs e)
        {
            CreateMix();
        }

        private bool checkArtistExist(string spotID)
        {
            if (artistTable.Select("spotifyID='" + spotID + "'").Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addTrackToMix(string trackID, string myMixID)
        {
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string sqlQuery = "insert into MyMixHasTrack values (@myMixID,@trackID) ";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@myMixID", myMixID);
                cmd.Parameters.AddWithValue("@trackID", trackID);
                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        private DataTable getAllAccount()
        {
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            DataTable res = new DataTable();
            string sqlQuery = "select * from Account ";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    res.Load(reader);
                }
            }

            sqlconnection.Close();
            return res;
        }

        private void createMixForUser(DataRow User)
        {
            int userID = int.Parse(User["userID"].ToString()); ;

            DataTable lovedArtist = Database.getArtistThatUserFollow(userID);
            if (lovedArtist.Rows.Count == 0)
            {
                richTextBox1.BeginInvoke((Action)delegate ()
                {
                    richTextBox1.Text += "User dont have loved artist : " + User["username"].ToString() + "\n";
                });
                return;
            }
           /* if (lovedArtist.Rows.Count <= (getNumberOfMix(userID.ToString()) * 3))
            {
                richTextBox1.BeginInvoke((Action)delegate ()
                {
                    richTextBox1.Text += "User dont have enough artist : " + User["username"].ToString() + "\n";
                });
                return;
            }*/
            string mixID = createMixForUser(userID.ToString());
            //the max number of tracks each artist
            int numberOfTrackEachArtist;

            if (lovedArtist.Rows.Count>3)
            {
                numberOfTrackEachArtist =6;
            }
            else
            {
                numberOfTrackEachArtist = 20 / lovedArtist.Rows.Count;
            }
            int countTrackInMix = 0;

            Random randArtist = new Random(DateTime.Now.Second);
            List<int> randRes = new List<int>();
            int loopCount = (lovedArtist.Rows.Count <= 3 ? lovedArtist.Rows.Count : 3);
            for (int a = 0; a < loopCount; a++)
            {
                int currentIndex = randArtist.Next(0, lovedArtist.Rows.Count );
                while (randRes.Contains(currentIndex))
                {
                    currentIndex = randArtist.Next(0, lovedArtist.Rows.Count );
                }

                //

                string name = lovedArtist.Rows[currentIndex]["artistName"].ToString();
                string id = lovedArtist.Rows[currentIndex]["spotifyID"].ToString();
                //api url to get similar artist

                string url = "https://musicroamer.com/api/v1/spotify/similarArtists?artist=" + name + "&artistID=" + id + "&expandArtist=false";
                JObject apiRes = getResponseJObject(url);
                JToken[] suggestedArtist = apiRes["artists"].ToArray();
                for (int i = 0; i < suggestedArtist.Length && countTrackInMix < 20; i++)
                {
                    Random randSuggestedArtist = new Random(DateTime.Now.Second);
                    List<int> randSuggestRes = new List<int>();
                    int suggestArtistIndex = randSuggestedArtist.Next(0, suggestedArtist.Length );

                    while (randSuggestRes.Contains(suggestArtistIndex))
                    {
                        suggestArtistIndex = randSuggestedArtist.Next(0, suggestedArtist.Length );
                    }
                    randSuggestRes.Add(suggestArtistIndex);
                    //if suggest artist exists in database

                    if (checkArtistExist(suggestedArtist[suggestArtistIndex]["id"].ToString()))
                    {
                        int countTrackOfSuggestedArtist = 0;
                        DataTable artist_Track = Database.getTrack_Artist(suggestedArtist[suggestArtistIndex]["id"].ToString(), 93939);

                        if (artist_Track.Rows.Count < numberOfTrackEachArtist)
                        {
                            foreach (DataRow track in artist_Track.Rows)
                            {
                                try
                                {
                                    addTrackToMix(track["trackID"].ToString(), mixID);
                                    countTrackInMix++; countTrackOfSuggestedArtist++;
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                        else
                        {
                            Random rnd = new Random(DateTime.Now.Second);
                            List<int> randomNum = new List<int>();
                            for (int j = 0; j < numberOfTrackEachArtist; j++)
                            {
                                int index = rnd.Next(0, artist_Track.Rows.Count );
                                while (randomNum.Contains(index))
                                {
                                    index = rnd.Next(0, artist_Track.Rows.Count );
                                }
                                try
                                {
                                    addTrackToMix(artist_Track.Rows[index]["trackID"].ToString(), mixID);
                                    countTrackInMix++; countTrackOfSuggestedArtist++;
                                }
                                catch (Exception)
                                {
                                }

                                randomNum.Add(index);
                                if (countTrackOfSuggestedArtist > numberOfTrackEachArtist)
                                {
                                    break;
                                }
                            }
                        }
                        if (countTrackOfSuggestedArtist > numberOfTrackEachArtist)
                        {
                            break;
                        }
                    }
                }
                if (countTrackInMix > 20)
                {
                    break;
                }

                //

                randRes.Add(currentIndex);
            }

            //khi chua du 20 bai, add them nhac trong track vao
            DataTable lovedTrack = new DataTable();
            lovedTrack = Database.loadTrackTableInTracks(userID);

            for (int i = 0; i < lovedTrack.Rows.Count && countTrackInMix < 20; i++)
            {
                string[] suggestTrack = GetSongData.GetSuggetSongs(lovedTrack.Rows[i]["trackLink"].ToString());
                try
                {
                    string trackID = "";
                    if (!Database.checkTrackExisted(suggestTrack[0]))
                    {
                        trackID = Database.addTrackToDatabase(suggestTrack[0]);
                    }
                    else
                    {
                        trackID = Database.getTrackIdBaseOnTrackLink(suggestTrack[0]);
                    }
                    addTrackToMix(trackID, mixID);
                    countTrackInMix++;
                }
                catch (Exception)
                {
                }
            }
            richTextBox1.BeginInvoke((Action)delegate ()
            {
                richTextBox1.Text += "Created mix for : " + User["username"].ToString() + "\n";
            });
        }

        private ManualResetEvent resetEvent = new ManualResetEvent(false);

        private void CreateMix()
        {
            richTextBox1.Clear();
            DataTable AccountTable = getAllAccount();
            foreach (DataRow User in AccountTable.Rows)
            {
                ThreadPool.QueueUserWorkItem(delegate (object obj)
                {
                    DataRow currentUser = User;
                    resetEvent.Set();

                    createMixForUser(currentUser);
                });
                resetEvent.WaitOne();
            }
        }

        private int getNumberOfMix(string userID)
        {
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string sqlQuery = "select count(*) from UserHasMix where userID = @userID ";

            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            sqlconnection.Close();
            return int.Parse(table.Rows[0][0].ToString());
        }

        private string getNextTitleForMix(string userID)
        {
            string res = "My Mix ";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string sqlQuery = "select count(*) from UserHasMix where userID = @userID ";

            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            res += (int.Parse(table.Rows[0][0].ToString()) + 1).ToString();
            sqlconnection.Close();
            return res;
        }

        private string deleteOldestMix(string userID)
        {
            /*
             delete from UserHasPlaylist where playlistID=50

delete From PlaylistHasTrack where playlistID=50

delete From Playlist where playlistID=50
             */

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            sqlconnection.Open();
            string sqlQuery = "select * from UserHasMix where userID=@userID order by myMixID ";
            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    temp.Load(reader);
                }
            }

            if (temp.Rows.Count == 0)
            {
                return "My Mix 1";
            }
            else if (temp.Rows.Count < 6)
            {
                return "";
            }
            string myMixID = temp.Rows[0]["myMixID"].ToString();
            sqlQuery = "delete from UserHasMix where myMixID=@myMixID";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@myMixID", myMixID);
                cmd.ExecuteNonQuery();
            }

            sqlQuery = "delete from MyMixHasTrack where myMixID=@myMixID";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@myMixID", myMixID);
                cmd.ExecuteNonQuery();
            }
            sqlQuery = "delete from MyMix output deleted.myMixTitle where myMixID=@myMixID";
            DataTable res = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@myMixID", myMixID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    res.Load(reader);
                }
            }
            sqlconnection.Close();
            return res.Rows[0][0].ToString();
        }

        private string createMixForUser(string userID)
        {
            string mixName = deleteOldestMix(userID);

            SqlConnection sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string sqlQuery = "insert into MyMix output inserted.myMixID values(@title,@order)";
            DataTable table = new DataTable();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                if (mixName != "")
                {
                    cmd.Parameters.AddWithValue("@title", mixName);
                    cmd.Parameters.AddWithValue("@order", mixName.Substring(mixName.Length - 1, 1));
                }
                else
                {
                    mixName = getNextTitleForMix(userID);
                    cmd.Parameters.AddWithValue("@title", mixName);
                    cmd.Parameters.AddWithValue("@order", mixName.Substring(mixName.Length - 1, 1));
                }
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            string myMixID = table.Rows[0][0].ToString();
            sqlQuery = "insert into UserHasMix values(@userID,@myMixID)";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlconnection))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@myMixID", myMixID);

                cmd.ExecuteNonQuery();
            }
            sqlconnection.Close();
            return myMixID;
        }

        private JObject getResponseJObject(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return JObject.Parse(responseString);
        }

        #endregion create mix for user
    }
}