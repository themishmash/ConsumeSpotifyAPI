using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consumespotifyapi2.Services
{
    public interface ISpotifyAccountService
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}
