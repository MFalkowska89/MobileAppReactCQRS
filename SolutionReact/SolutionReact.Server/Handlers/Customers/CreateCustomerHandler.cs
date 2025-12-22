using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Customers.Commands;

namespace SolutionReact.Server.Handlers.BookingParticipants
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, List<int>>
    {
        private readonly ApplicationDbContext _context;

        public CreateCustomerHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var newCustomers = new List<Customer>();

            foreach (var requestedCustomer in request.Customers)
            {

                var existingCustomer = await _context.Customers
                        .Where(c => c.IsActive &&
                        c.FirstName == requestedCustomer.FirstName &&
                        c.LastName == requestedCustomer.LastName &&
                        c.DateOfBirth == requestedCustomer.DateOfBirth &&
                        c.EmailAddress == requestedCustomer.EmailAddress)
                        .FirstOrDefaultAsync();

                if (existingCustomer != null) // how to use mapper here?
                {
                    existingCustomer.HomeAddress = requestedCustomer.HomeAddress;
                    existingCustomer.PostCode = requestedCustomer.PostCode;
                    existingCustomer.City = requestedCustomer.City;
                    existingCustomer.Country = requestedCustomer.Country;
                    existingCustomer.PhoneNumber = requestedCustomer.PhoneNumber;
                    existingCustomer.PhoneNumberExtra = requestedCustomer.PhoneNumberExtra;
                    existingCustomer.ModifiedBy = "user";
                    existingCustomer.ModifiedDate = DateTime.UtcNow;

                    newCustomers.Add(existingCustomer);  
                }
                else
                {
                    var customer = requestedCustomer.Adapt<Customer>();

                    _context.Customers.Add(customer);

                    newCustomers.Add(customer); // the custmer will not have an id here yet, need to find other way?
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            return newCustomers.Select(c => c.Id).ToList();
        }
    }
}
