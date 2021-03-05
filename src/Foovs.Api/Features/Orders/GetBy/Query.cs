using System;
using System.Collections.Generic;
using Foovs.Core.Domain;
using MediatR;

namespace Foovs.Api.Features.Orders
{
    public static partial class GetBy
    {
        public class Query : IRequest<Result>
        {
            public Guid Id { get; set; }
        }
    }
}