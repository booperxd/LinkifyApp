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

    class SongPairing
    {
        public int id { get; set; }
        public string song_key { get; set; }
        public string song_value { get; set; }
        public string owner { get; set; }

        public SongPairing()
        {

        }
        public SongPairing(string key, string value, string owner)
        {
            id = -1;
            song_key = key;
            song_value = value;
            this.owner = owner;
        }
        public SongPairing(int id, string key, string value, string owner)
        {
            this.id = id;
            song_key = key;
            song_value = value;
            this.owner = owner;
        }

    }
    class ExternalInterface
    {
        public CurrentSong storedSong = new CurrentSong("https://open.spotify.com/track/4CJ7iadNL15GuTr7fXMqxr");
        public UserModel curUser = null;


        public string url = "http://10.0.0.29:8000";
        static HttpClient client = new HttpClient();

        public async Task<bool> Login()
        {
            var response = await client.GetAsync(url + "/login");
            if (response.Content != null)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(responseContent);
                curUser = JsonConvert.DeserializeObject<UserModel>(responseContent);
                if (curUser.song_pairings == null)
                {
                    curUser.song_pairings = new List<int>();
                }
                return true;
            }
            return false;
        }

        public async Task<List<SongPairing>> GetSongPairings(String ownerId)
        {
            var response = await client.GetAsync(url + "/song-pairings?owner=" + ownerId);
            response.EnsureSuccessStatusCode();
            if (response.Content != null)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic songPairings = JsonConvert.DeserializeObject<List<SongPairing>>(responseContent);
                return songPairings;
            }
            return null;
        }

        public async Task<SongPairing> PostSongPairing(String songkey, String songvalue)
        {
            SongPairing pairing = new SongPairing(songkey, songvalue, curUser.id);
            var stringPayload = JsonConvert.SerializeObject(pairing);
            var httpPayload = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url + "/song-pairings", httpPayload);
            response.EnsureSuccessStatusCode();
            if (response.Content != null)
            {
                

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<SongPairing>(responseContent);
                }

            }
            return null;
        }

        public async Task<bool> UpdateUserPairings(int pairing_id)
        {
            List<int> temp = curUser.song_pairings;
            temp.Add(pairing_id);
            curUser.song_pairings = temp;
            var stringPayload = JsonConvert.SerializeObject(curUser);
            var httpPayload = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url + "/users/" + curUser.id, httpPayload);
            response.EnsureSuccessStatusCode();
            if (response.Content != null)
            {
                //var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return true;
                }

            }
            return false;
        }

        public async Task PostCurrentSong()
        {
            Debug.WriteLine(storedSong.current);
            var stringPayload = JsonConvert.SerializeObject(storedSong);
            var httpPayload = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url + "/check-songs", httpPayload);
            response.EnsureSuccessStatusCode();
            if (response.Content != null)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                
                CurrentSong newSong = JsonConvert.DeserializeObject<CurrentSong>(responseContent);
                storedSong = newSong;

            }
        }

    }
}
