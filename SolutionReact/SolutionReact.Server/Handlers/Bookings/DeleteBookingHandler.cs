using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Bookings.Commands;

namespace SolutionReact.Server.Handlers.Bookings
{
    public class DeleteBookingHandler : IRequestHandler<DeleteBookingCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public DeleteBookingHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == request.Id && b.IsActive);

            var status = await _context.StatusOfEntities
                .Where(s => s.StatusName == "Cancelled").FirstAsync();

            if (booking == null)
            {
                throw new KeyNotFoundException();
            }

            booking.IsActive = false;
            booking.BookingStatusId = status.Id;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
