using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consumespotifyapi2.Models;

namespace consumespotifyapi2.Services
{
    public interface ISpotifyService
    {
        Task<IEnumerable<Release>> GetNewReleases(string countryCode, int limit, string accessToken);

        Task<IEnumerable<Playlist>> GetNewPlaylists(string countryCode, int limit, string accessToken);

    }
}
