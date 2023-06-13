using System;
using System.Collections.Generic;
using System.Text;

namespace LinkifyApp
{
    class UserModel
    {
        public string id { get; set; }
        public string username { get; set; }

        public List<int> song_pairings { get; set; }

        public string token { get; set; }

    }
}
