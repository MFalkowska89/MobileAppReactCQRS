using MediatR;
using Microsoft.AspNetCore.Mvc;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Requests.Bookings.Commands;
using SolutionReact.Server.Requests.Bookings.Queries;

namespace SolutionReact.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IMediator _mediator;

        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BookingDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetBookingByIdQuery(id);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound(new { message = $"No booking found with ID {id}" });
            }

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateBookingCommand command)
        {
            var bookingId = await _mediator.Send(command);

            return CreatedAtAction(
                nameof(GetById),
                new { id = bookingId },
                new { id = bookingId, message = "Booking has been created" }
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateBookingCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest(new { message = "ID w URL różni się od ID w body" });
            }

            try
            {
                await _mediator.Send(command);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBookingCommand(id);

            try
            {
                await _mediator.Send(command);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}