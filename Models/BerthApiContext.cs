using Microsoft.EntityFrameworkCore;

namespace BerthApi.Models
{
    public class BerthApiContext : DbContext
    {
        public BerthApiContext(DbContextOptions<BerthApiContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}