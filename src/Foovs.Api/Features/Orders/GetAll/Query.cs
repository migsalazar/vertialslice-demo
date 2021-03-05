using System.Collections.Generic;
using Foovs.Core.Domain;
using MediatR;

namespace Foovs.Api.Features.Orders
{
    public static partial class GetAll
    {
        public class Query : IRequest<Result>
        { }
    }
}