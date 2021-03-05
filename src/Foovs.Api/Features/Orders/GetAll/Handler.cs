using System;
using System.Threading;
using System.Threading.Tasks;
using Foovs.Infrastructure.Data;
using MediatR;

namespace Foovs.Api.Features.Orders
{
    public static partial class GetAll
    {
        public class Handler : IRequestHandler<Query, Result>
        {
            private readonly FoovsReadOnlyContext _readOnlyContext;

            public Handler(FoovsReadOnlyContext readOnlyContext)
            {
                _readOnlyContext = readOnlyContext;
            }

            public Task<Result> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}