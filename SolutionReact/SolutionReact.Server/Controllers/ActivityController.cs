using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Commands;
using SolutionReact.Server.Requests.Activities.Queries;

namespace SolutionReact.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/items
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllActivitiesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // POST: api/items
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateActivityCommand command)
        {
            var activityId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAll), new { id = activityId }, activityId);
        }
    }
}
