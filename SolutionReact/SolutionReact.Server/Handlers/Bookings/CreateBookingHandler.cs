using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var customersList = new List<Customer>();

            foreach (var customer in request.Customers)
            {
                var existingCustomer = await _context.Customers
                    .FirstOrDefaultAsync(c => c.EmailAddress == customer.EmailAddress
                                        && c.FirstName == customer.FirstName
                                        && c.LastName == customer.LastName
                                        && c.DateOfBirth == customer.DateOfBirth
                                        && c.IsActive, cancellationToken);

                if (existingCustomer != null)
                {
                    existingCustomer.HomeAddress = customer.HomeAddress;
                    existingCustomer.PostCode = customer.PostCode;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.PhoneNumber = customer.PhoneNumber;
                    existingCustomer.PhoneNumberExtra = customer.PhoneNumberExtra;
                    existingCustomer.ModifiedBy = "user";
                    existingCustomer.ModifiedDate = DateTime.UtcNow;

                    _context.Customers.Update(existingCustomer);
                    customersList.Add(existingCustomer);
                }

                else
                {
                    var newCustomer = customer.Adapt<Customer>();
                    _context.Customers.Add(newCustomer);
                    customersList.Add(newCustomer);
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            var booking = request.Adapt<Booking>();

            var tourPrice = await _context.ToursSchedule
                .Where(testc => testc.Id == request.CustomTourScheduleId)
                .Include(ts => ts.Tour)
                .Select(ts => ts.Tour.Price)
                .FirstAsync();

            booking.CustomerId = customersList[0].Id;  
            booking.NoPax = customersList.Count;
            booking.TotalPrice = tourPrice * booking.NoPax;

            booking.BookingParticipants = customersList
                .Select(c => new BookingParticipant
                {
                    CustomerId = c.Id,
                    IsActive = true,
                    AddedBy = "user",
                    AddedDate = DateTime.UtcNow
                })
                .ToList();

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync(cancellationToken);

            return booking.Id;
        }
    }
}
