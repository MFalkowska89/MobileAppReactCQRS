using MediatR;
using Microsoft.AspNetCore.Mvc;
using SolutionReact.Server.Requests.Customers.Commands;

namespace SolutionReact.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut] // instead going to customer separately, i should be going by booking participant? // tutaj teoretrycznie moglabym tez pozwolic na dodwananie customers. - chociaz pewnie lepiej oddzielnie zeby nie miec problemu z id
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(UpdateCustomerCommand command)
        {
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
