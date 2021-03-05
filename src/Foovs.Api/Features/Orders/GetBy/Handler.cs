using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Foovs.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Foovs.Api.Features.Orders
{
    public static partial class GetBy
    {
        public class Handler : IRequestHandler<Query, Result>
        {
            private readonly FoovsReadOnlyContext _readOnlyContext;

            public Handler(FoovsReadOnlyContext readOnlyContext)
            {
                _readOnlyContext = readOnlyContext;
            }

            public async Task<Result> Handle(Query query, CancellationToken cancellationToken)
            {
                var order = await _readOnlyContext.Orders
                        .Where(o => o.Id == query.Id)
                        .FirstOrDefaultAsync(cancellationToken);

                if(order == null)
                    throw new Exception();

                return new Result {
                    Order = order
                };
            }
        }
    }
}