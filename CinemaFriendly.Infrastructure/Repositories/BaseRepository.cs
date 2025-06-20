using CinemaFriendly.Domain.Repositories;
using CinemaFriendly.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CinemaFriendly.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<T?> GetByIdAsync(Guid id) => _context.Set<T>().FindAsync(id).AsTask();

    public async Task AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}
