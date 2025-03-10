
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NewsGenerator.Models
{
    /// <summary>
    /// Használja a News API-t. (Cache-eléssel)
    /// </summary>
    public class NewsAPIRandomNewsProvider : IRandomNewsProvider
    {
        private const string NewsApiUrl = "https://ok.surf/api/v1/cors/news-feed";
        private List<News> news = new List<News>();
        private static Random rnd = new Random();
        private static int id = 1;
        private DateTime lastUpdated = DateTime.Now;
        private TimeSpan cacheTime = TimeSpan.FromMinutes(1);
        public News GetRandomNews()
        {
            // ha már eltelt annyi idő, amennyi időre állítjuk a cache-t
            if (IsEmptyOrCacheTimeElapsed())
            {

                news.Clear();
                HttpClient httpClient = new HttpClient();
                // GET request -> stringet ad vissza
                string json = httpClient.GetStringAsync(NewsApiUrl).Result;
                JObject jsonObj = JObject.Parse(json);
                JToken businessNews = jsonObj["Technology"];
                lastUpdated = DateTime.Now;
                foreach (JToken jsonNews in businessNews)
                
                {
                    News news = new News()
                    {
                        Id = id,
                        OriginalNewsLink = jsonNews["link"].ToString(),
                        Title = jsonNews["title"].ToString(),
                        Source = jsonNews["source"].ToString(),
                        ImageLink = jsonNews["og"].ToString()
                    };
                    this.news.Add(news);
                    id++;
                }
            }

            return GetRandomElement();
        }

        private News GetRandomElement()
        {
            return news.ElementAt(rnd.Next(0, news.Count()));
        }

        private bool IsEmptyOrCacheTimeElapsed()
        {
            return !news.Any() || DateTime.Now - cacheTime > lastUpdated;
        }
    }
}
