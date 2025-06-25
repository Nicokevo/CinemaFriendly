using CinemaFriendly.Shared.Models;

namespace CinemaFriendly.Client.Services.Interfaces;

public interface ITrailerService
{
    Task<IEnumerable<TrailerDto>> GetTrailersAsync();
}
