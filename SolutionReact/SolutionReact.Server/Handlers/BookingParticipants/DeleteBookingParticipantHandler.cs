using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.BookingParticipants.Commands;

namespace SolutionReact.Server.Handlers.BookingParticipants
{
    public class DeleteBookingParticipantHandler : IRequestHandler<DeleteBookingParticipantCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public DeleteBookingParticipantHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteBookingParticipantCommand request, CancellationToken cancellationToken)
        {
            var bookingParticipant = await _context.BookingsParticipant
                .Include(bp => bp.Booking)
                .FirstOrDefaultAsync(b => b.Id == request.Id && b.IsActive);

            if (bookingParticipant == null)
            {
                throw new KeyNotFoundException();
            }

            bookingParticipant.IsActive = false;
            bookingParticipant.DeletedDate = DateTime.UtcNow;
            bookingParticipant.DeletedBy = "user";

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == bookingParticipant.BookingId);

            var tourSchedule = await _context.ToursSchedule
                .Include(t => t.Tour)
                .FirstOrDefaultAsync(t => t.Id == bookingParticipant.Booking.CustomTourScheduleId);

            if (tourSchedule == null)
            {
                throw new KeyNotFoundException();
            }

            booking.NoPax = booking.NoPax - 1;
            booking.ModifiedDate = DateTime.UtcNow;
            booking.ModifiedBy = "user";
            booking.TotalPrice = bookingParticipant.Booking.TotalPrice - tourSchedule.Tour.Price;

            tourSchedule.AvailablePax = tourSchedule.AvailablePax + 1;

            await _context.SaveChangesAsync(cancellationToken); 

            return Unit.Value;
        }
    }
}

