using System.Collections.Generic;
using Foovs.Core.Domain;

namespace Foovs.Api.Features.Orders
{
    public static partial class GetBy
    {
        public class Result
        {
            public Order Order { get; set; }
        }
    }
}