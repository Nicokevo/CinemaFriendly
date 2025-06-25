using System.Collections.Generic;
using System.Linq;
using CinemaFriendly.Client.Services.Interfaces;
using CinemaFriendly.Shared.Models;

namespace CinemaFriendly.Client.Services.Implementations;

public class TrailerService : ITrailerService
{
    public Task<IEnumerable<TrailerDto>> GetTrailersAsync()
    {
        return Task.FromResult(Enumerable.Empty<TrailerDto>());
    }
}
