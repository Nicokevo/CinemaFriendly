using CinemaFriendly.Domain.Entities;
using CinemaFriendly.Domain.Repositories;
using CinemaFriendly.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CinemaFriendly.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}
