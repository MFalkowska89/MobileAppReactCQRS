using Mapster;
using MediatR;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Bookings.Commands;

namespace SolutionReact.Server.Handlers.Bookings
{
    public class CreateBookingHandler : IRequestHandler<CreateBookingCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateBookingHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {

            //Console.WriteLine($"Received booking with {request.Customers.Count} customers");


            //foreach (var cust in request.Customers)
            //{
            //    var customer = new Customer
            //    {
            //        FirstName = cust.FirstName,
            //        LastName = cust.LastName,
            //        DateOfBirth = DateTime.UtcNow,
            //        HomeAddress = cust.HomeAddress,
            //        PostCode = cust.PostCode,
            //        City = cust.City,
            //        Country = cust.Country,
            //        PhoneNumber = cust.PhoneNumber,
            //        PhoneNumberExtra = cust.PhoneNumberExtra,
            //        EmailAddress = cust.EmailAddress
            //    };
            //    _context.Customers.Add(customer);
            //}




            //var customers = request.Customers
            //    .Select(c => c.Adapt<Customer>())
            //    .ToList();

            ////_context.Customers.AddRange(customers);
            //await _context.SaveChangesAsync(cancellationToken);

            var booking = request.Adapt<Booking>();

            booking.CustomerId = 1; //customers[0].Id;  

            //booking.BookingParticipants = customers
            //    .Select(c => new BookingParticipant
            //    {
            //        CustomerId = c.Id,
            //        IsActive = true,
            //        AddedBy = "user",
            //        AddedDate = DateTime.UtcNow
            //    })
            //    .ToList();

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync(cancellationToken);

            return booking.Id;
        }
    }
}
