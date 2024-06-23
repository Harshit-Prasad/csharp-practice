using Microsoft.EntityFrameworkCore;
using social_media_api.Entities;

namespace social_media_api.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
