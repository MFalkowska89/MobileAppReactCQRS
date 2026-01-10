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

            if (booking == null)
            {
                throw new KeyNotFoundException();
            }

            booking.IsActive = false;
            booking.DeletedDate = DateTime.UtcNow;
            booking.DeletedBy = "user";
            booking.BookingStatusId = 3;

            var bookingParticipants = await _context.BookingsParticipant
                .Where(bp => bp.BookingId == booking.Id && bp.IsActive)
                .ToListAsync();

            foreach (var participant in bookingParticipants)
            {
                participant.IsActive = false;
                participant.DeletedDate = DateTime.UtcNow;
                participant.DeletedBy = "user";
            }

            var tourSchedule = await _context.ToursSchedule
                .FirstAsync(ts => ts.Id == booking.CustomTourScheduleId);

            tourSchedule.AvailablePax = tourSchedule.AvailablePax + bookingParticipants.Count;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
