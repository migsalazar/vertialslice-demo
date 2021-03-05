using Microsoft.EntityFrameworkCore;

namespace Foovs.Infrastructure.Data
{
    public class FoovsReadOnlyContext : FoovsBaseContext
    {
        public FoovsReadOnlyContext(DbContextOptions<FoovsReadOnlyContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}