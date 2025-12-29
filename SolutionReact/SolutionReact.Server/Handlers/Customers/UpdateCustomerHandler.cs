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

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken) // chyba do tego noe jest mi potrzebne booking, moge wyslac liste samych customers?
        {
            foreach (var customer in request.CustomersToUpdate)
            {
                var existingCustomer = await _context.Customers
                    .FirstOrDefaultAsync(c => c.Id == customer.Id && c.IsActive); 

                if (existingCustomer == null)
                {
                    throw new KeyNotFoundException("Customer with the same ID already exists.");
                }

                existingCustomer.HomeAddress = customer.HomeAddress;
                existingCustomer.PostCode = customer.PostCode;
                existingCustomer.City = customer.City;
                existingCustomer.Country = customer.Country;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.PhoneNumberExtra = customer.PhoneNumberExtra;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.ModifiedBy = "user";
                existingCustomer.ModifiedDate = DateTime.UtcNow;

                _context.Customers.Update(existingCustomer);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
