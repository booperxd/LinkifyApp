using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace LinkifyApp
{
    class CurrentSong { 
        public string current { get; set; }
        public CurrentSong()
        {

        }
        public CurrentSong(string current)
        {
            this.current = current;
        }
    }
    class ExteranlInterface
    {
        public string url = "http://127.0.0.1:8000";
        static HttpClient client = new HttpClient();

        public async Task<String> PostCurrentSong(string uri)
        {
            Debug.WriteLine("Hello???");
            var stringPayload = JsonConvert.SerializeObject(new CurrentSong(uri));
            var httpPayload = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url + "/check-songs", httpPayload);
            response.EnsureSuccessStatusCode();
            if (response.Content != null)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                CurrentSong newSong = JsonConvert.DeserializeObject<CurrentSong>(responseContent);
                Debug.WriteLine(newSong.current);
                return newSong.current;

            }
            return "";
        }

    }
}
