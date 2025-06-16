using Microsoft.EntityFrameworkCore;

namespace ThomasHuttonWebApp.Components.Classes
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Contacts { get; set; }
    }
}
