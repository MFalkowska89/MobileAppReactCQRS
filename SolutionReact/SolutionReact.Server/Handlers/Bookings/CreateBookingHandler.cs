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
            var customers = request.Customers
                .Select(c => c.Adapt<Customer>())
                .ToList();

            _context.Customers.AddRange(customers);
            await _context.SaveChangesAsync(cancellationToken);

            var booking = request.Adapt<Booking>();

            booking.CustomerId = customers.First().Id; 

            booking.BookingParticipants = customers
                .Select(c => new BookingParticipant
                {
                    BookingId = booking.Id,
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
