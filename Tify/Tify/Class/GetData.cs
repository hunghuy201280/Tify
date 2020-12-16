using CsQuery;
using NAudio.Wave;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TiengVietKhongDau;
namespace GetData
{
    public class GetSongData
    {
        static Uri link;

        static public string getArtistLinkWithName(string name, DataTable dataTable)
        {
            foreach (DataRow item in dataTable.Rows)
            {
                item["artistName"] = TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(item["artistName"].ToString());
            }

            string url = "https://chiasenhac.vn/search/real?q=" +
                        HttpUtility.UrlEncode(TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(name).ToLower(), Encoding.UTF8) +
                        "&type=json&rows=3&view_all=true";
            try
            {
                JObject jObject = getResponseJObject(url);

                DataRow[] foundAuthors = dataTable.Select("artistName = '" + TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(name) + "'");

                if (foundAuthors.Length == 0)
                {
                    return string.Empty;
                }
                return "https://chiasenhac.vn" + jObject["artist"]["data"][0]["artist_link"].ToString();
            }
            catch (Exception)
            {

                throw;
            }


        }


        static public string getArtistCover(string name)
        {
            string url = "https://musicroamer.com/api/v1/spotify?artist=" +
         HttpUtility.UrlEncode(TiengVietKhongDau.TiengVietKhongDau.RemoveSign4VietnameseString(name), Encoding.UTF8);
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JObject json = JObject.Parse(responseString);
            try
            {
                string pictureLink = Convert.ToString(json["artists"]["items"][0]["images"][0]["url"]);
                return pictureLink;


            }
            catch (Exception)
            {
                return "http://cdn.wearevl.com/IMAGEBANK/-9009/bl/an/blank.jpg";
            }
        }
        static private JObject getResponseJObject(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                responseString = responseString.Remove(0, 5);
                responseString = responseString.Remove(responseString.Length - 1, 1);
                return JObject.Parse(responseString);
            }
            catch (Exception )
            {

                return null;
            }
        }

        static public string GetSongName(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out link))
            {
                var dom = CQ.CreateFromUrl(link.ToString());
                return dom[@"h2.card-title"].Text();
            }
            else
            {
                return string.Empty;
            }
        }

        static public string[] GetSongArtist(string url)
        {
            string[] artists;
            if (Uri.TryCreate(url, UriKind.Absolute, out link))
            {
                var dom = CQ.CreateFromUrl(link.ToString());

                int count = dom[@"div.col-md-4 div.card-body ul.list-unstyled li:nth-of-type(1) a"].Count();
                artists = new string[count];
                for (int i = 0; i < count; i++)
                {
                    int cur = i + 1;
                    artists[i] = dom[@"div.col-md-4 div.card-body ul.list-unstyled li:nth-of-type(1) a[href]:nth-of-type(" + cur + ")"].Text();


                }
                return artists;
            }
            else
            {
                return new string[1];
            }
        }

        static public string GetStreamLink(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out link))
            {
                var dom = CQ.CreateFromUrl(link.ToString());
                return dom[@"ul[class='list-unstyled download_status'] li:nth-of-type(2) a[href*='.mp3']"].Attr("href");
            }
            else
            {
                return string.Empty;
            }
        }

        static public int GetSongDuration(string url)
        {
            int time;
          
            try
            {
                MediaFoundationReader temp1 = new MediaFoundationReader(GetStreamLink(url));
                
                time=(int)temp1.TotalTime.TotalSeconds;
              

            }
            catch (Exception)
            {
                return 0;
            }

            return time;
        }

        static public string GetSongCover(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out link))
            {
                var dom = CQ.CreateFromUrl(link.ToString());
                return dom[@"div#companion_cover img"].Attr("src");
            }
            else
            {
                return string.Empty;
            }


        }

        static public string[] GetSuggetSongs(string url)
        {
            string[] suggest = new string[10];
            if (Uri.TryCreate(url, UriKind.Absolute, out link))
            {
                var dom = CQ.CreateFromUrl(link.ToString());

                for (int i = 1; i < 11; i++)
                {
                    string Url = dom[@"ul[class='list-unstyled list_music sug_music'] li[class='media align-items-stretch']:nth-of-type(" + i + ") h5 a"].Attr("href");
                    suggest[i - 1] = Url;


                }
                return suggest;
            }
            else
            {
                return suggest;
            }

        }


    }

}
