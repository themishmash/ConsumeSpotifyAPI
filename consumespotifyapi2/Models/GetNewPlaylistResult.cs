using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consumespotifyapi2.Models
{

    public class GetNewPlaylistResult
    {
        public string message { get; set; }
        public Playlists playlists { get; set; }
    }

    public class Playlists
    {
        public string href { get; set; }
        public Item2[] items { get; set; }
        public int limit { get; set; }
        public object next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class Item2
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public External_Urls2 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image2[] images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public object primary_color { get; set; }
        public object _public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls2
    {
        public string spotify { get; set; }
    }

    public class Owner
    {
        public string display_name { get; set; }
        public External_Urls3 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls3
    {
        public string spotify { get; set; }
    }

    public class Tracks
    {
        public string href { get; set; }
        public int total { get; set; }
    }

    public class Image2
    {
        public object height { get; set; }
        public string url { get; set; }
        public object width { get; set; }
    }

}
