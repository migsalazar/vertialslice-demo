using System.Threading.Tasks;
using Foovs.Api.Features.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Foovs.Api.Controllers.Features.Controllers
{
    [ApiController]
    [Route("foovs-api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public OrdersController(IMediator mediator)
            => _mediatr = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
            => Ok(await _mediatr.Send(new GetAll.Query { }));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(GetBy.Query query)
            => Ok(await _mediatr.Send(query));

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Create.Command command)
            => Ok(await _mediatr.Send(command));
    }
}
