using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyApi.Models;

namespace SpotifyApi.Services
{
  public interface ISpotifyService
  {
    Task<IEnumerable<Release>> GetNewReleases(string countryCode, int limit, string accessToken);
  }
}