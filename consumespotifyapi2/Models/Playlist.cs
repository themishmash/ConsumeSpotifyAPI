using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consumespotifyapi2.Models
{
    public class Playlist
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
        public int TrackTotal { get; set; }
    }
}
