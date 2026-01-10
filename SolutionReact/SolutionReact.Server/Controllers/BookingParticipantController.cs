using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Requests.BookingParticipants.Commands;
using SolutionReact.Server.Requests.Bookings.Queries;

namespace SolutionReact.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingParticipantController : ControllerBase
    {

        private readonly IMediator _mediator;

        public BookingParticipantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("booking/{bookingId}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromRoute] int bookingId, [FromBody] CreateBookingParticipantCommand command)
        {
            if (bookingId != command.BookingId)
                return BadRequest("BookingId mismatch");
             
            var unitId = await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBookingParticipantCommand(id);

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
    } // czy powinnam miec customer i booking participant oddzielnie?
}