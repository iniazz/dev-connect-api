using DevConnect___Complete_Developer_Networking_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect___Complete_Developer_Networking_Platform.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
