using Microsoft.EntityFrameworkCore;
using CinemaFriendly.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CinemaFriendly.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Acá van las configuraciones futuras (con Fluent API)
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.HasIndex(u => u.Email).IsUnique();
            entity.Property(u => u.UserName).IsRequired().HasMaxLength(30);
        });
    }
}
