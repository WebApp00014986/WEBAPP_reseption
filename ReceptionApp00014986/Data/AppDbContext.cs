using Microsoft.EntityFrameworkCore;
using ReceptionApp00014986.Models;

namespace ReceptionApp00014986.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
    
}
