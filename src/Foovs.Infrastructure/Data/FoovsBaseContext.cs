using Foovs.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Foovs.Infrastructure.Data
{
    public class FoovsBaseContext : DbContext
    {
        public FoovsBaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}