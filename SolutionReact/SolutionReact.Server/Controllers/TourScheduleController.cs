using MediatR;
using Microsoft.AspNetCore.Mvc;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Requests.TourSchedules.Queries;

namespace SolutionReact.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TourScheduleController : ControllerBase
    {

        private readonly IMediator _mediator;

        public TourScheduleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("tour/{tourId}")]
        [ProducesResponseType(typeof(List<TourScheduleDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByTourId(int tourId)
        {
            var query = new GetTourSchedulesByTourIdQuery(tourId);
            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}

