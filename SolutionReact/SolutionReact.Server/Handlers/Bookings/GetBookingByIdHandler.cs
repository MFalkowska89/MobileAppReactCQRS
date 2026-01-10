using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Bookings.Queries;

namespace SolutionReact.Server.Handlers.Customers
{
    public class GetBookingByIdHandler : IRequestHandler<GetBookingByIdQuery, BookingDto?>
    {
        private readonly ApplicationDbContext _context;
        public GetBookingByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookingDto?> Handle(GetBookingByIdQuery request, CancellationToken cancellationToken)
        {
            var bookings = await _context.Bookings
                .Where(b => b.Id == request.Id && b.IsActive)
                .Include(b => b.TourSchedule)
                    .ThenInclude(ts => ts.Tour)
                    .ThenInclude(t => t.Destination)
               .Include(b => b.BookingParticipants.Where(bp => bp.IsActive))
                    .ThenInclude(bp => bp.Customer)
                .Include(b => b.StatusOfEntity)
                .AsNoTracking()
                .Select(b => b.Adapt<BookingDto>())
                .FirstOrDefaultAsync(cancellationToken);

            return bookings;
        }
    }
}