using Microsoft.EntityFrameworkCore;

namespace Foovs.Infrastructure.Data
{
    public class FoovsContext : FoovsBaseContext
    {
        public FoovsContext(DbContextOptions<FoovsContext> options) : base(options) { }
    }
}