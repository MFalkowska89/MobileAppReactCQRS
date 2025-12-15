using MediatR;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Customers.Commands;

namespace SolutionReact.Server.Handlers.BookingParticipants
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateCustomerHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var bookingParticipant = new BookingParticipant
            {
                // how to do tis one correctly?
            };

            return bookingParticipant.Id;
        }
    } 
}
