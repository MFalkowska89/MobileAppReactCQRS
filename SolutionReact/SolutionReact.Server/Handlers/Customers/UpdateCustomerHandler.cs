using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Customers.Commands;

namespace SolutionReact.Server.Handlers.BookingParticipants
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public UpdateCustomerHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            foreach (var customer in request.CustomersToUpdate)
            {
                var existingCustomer = await _context.Customers
                    .FirstOrDefaultAsync(c => c.Id == customer.Id && c.IsActive);

                if (existingCustomer != null)
                {
                    throw new KeyNotFoundException("Customer with the same ID already exists.");
                }

                existingCustomer.PhoneNumber = customer.PhoneNumber?.Trim();

            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
