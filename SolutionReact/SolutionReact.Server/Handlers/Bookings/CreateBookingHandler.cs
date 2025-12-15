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

        public async Task<int> Handle(CreateBookingCommand request, CancellationToken cancellationToken) // czy to nie powinno isc z mappera?
        {
            var booking = new Booking
            {
                CustomerId = request.CustomerId,
                CustomTourScheduleId = request.CustomTourScheduleId,
                NoPax = request.NoPax
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync(cancellationToken);

            return booking.Id;
        }
    }
}
