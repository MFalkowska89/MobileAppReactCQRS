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
            var existingCustomer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Id == request.CustomerId && c.IsActive);

            if (existingCustomer == null)
            {
                throw new KeyNotFoundException("Could not find the customer with provided ID");
            }

            existingCustomer.HomeAddress = request.HomeAddress;
            existingCustomer.PostCode = request.PostCode;
            existingCustomer.City = request.City;
            existingCustomer.Country = request.Country;
            existingCustomer.PhoneNumber = request.PhoneNumber;
            existingCustomer.PhoneNumberExtra = request.PhoneNumberExtra;
            existingCustomer.EmailAddress = request.EmailAddress;
            existingCustomer.ModifiedBy = "user";
            existingCustomer.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
