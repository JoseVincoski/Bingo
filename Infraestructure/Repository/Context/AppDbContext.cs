using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Card> Card { get; set; }
    }
}