
using System.Net.Http;
using System.Threading.Tasks;

namespace Rise_Set_Time
{
    public static class API_Helper
    {
        private static readonly string baseurl = "https://api.sunrise-sunset.org/json?";
        public static async Task<string> RGet(string lat,string lon)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseurl +"lat=" + lat + "&lng=" + lon + "&date=today"))
                {
                    using(HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        
    }
}
