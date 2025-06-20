using CinemaFriendly.Domain.Entities;

namespace CinemaFriendly.Domain.Repositories;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByEmailAsync(string email);
}
