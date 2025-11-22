using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Commands;
using SolutionReact.Server.Requests.Activities.Queries;
using SolutionReact.Server.Requests.Destinations.Commands;
using SolutionReact.Server.Requests.Destinations.Queries;

namespace SolutionReact.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DestinationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/items
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllDestinationsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // POST: api/items
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDestinationCommand command)
        {
            var itemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAll), new { id = itemId }, itemId);
        }
    }
}
