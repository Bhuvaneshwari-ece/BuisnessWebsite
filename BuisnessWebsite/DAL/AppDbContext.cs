
using BuisnessWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace BuisnessWebsite.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

      
    }
}
