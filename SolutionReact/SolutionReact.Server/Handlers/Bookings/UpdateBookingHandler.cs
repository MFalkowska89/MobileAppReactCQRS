using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Bookings.Commands;

namespace SolutionReact.Server.Handlers.Bookings
{
    public class UpdateBookingHandler : IRequestHandler<UpdateBookingCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public UpdateBookingHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == request.Id && b.IsActive);

            if (booking == null)
            {
                throw new KeyNotFoundException(nameof(booking));
            }

            var currentSchedule = await _context.ToursSchedule
                .FirstAsync(s => s.Id == booking.CustomTourScheduleId && s.IsActive);

            var requestedSchedule = await _context.ToursSchedule
                .FirstAsync(s => s.Id == request.CustomTourScheduleId && s.IsActive);

            booking.CustomTourScheduleId = request.CustomTourScheduleId;
            booking.ModifiedBy = "user";
            booking.ModifiedDate = DateTime.UtcNow;

            currentSchedule.AvailablePax = currentSchedule.AvailablePax + booking.NoPax;

            requestedSchedule.AvailablePax = requestedSchedule.AvailablePax - booking.NoPax;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
