using System.Collections.Generic;
using Foovs.Core.Domain;

namespace Foovs.Api.Features.Orders
{
    public static partial class GetAll
    {
        public class Result
        {
            public IEnumerable<Order> Orders { get; set; }
        }
    }
}