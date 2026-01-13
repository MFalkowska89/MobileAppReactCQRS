using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Tours.Commands;

namespace SolutionReact.Server.Handlers.Tours
{
    public class DeleteTourHandler : IRequestHandler<DeleteTourCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public DeleteTourHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteTourCommand request, CancellationToken cancellationToken)
        {
            var tour = await _context.Tours
                .Include(t => t.TourActivities)
                .Include(t => t.TourSchedules)
                .FirstOrDefaultAsync(b => b.Id == request.Id && b.IsActive);

            if (tour == null)
            {
                throw new KeyNotFoundException();
            }

            tour.IsActive = false;
            tour.DeletedDate = DateTime.UtcNow;
            tour.DeletedBy = "user";

            var tourActivities = await _context.TourActivities
                .Where(bp => bp.TourId == tour.Id && bp.IsActive)
                .ToListAsync();

            foreach (var activity in tourActivities)
            {
                activity.IsActive = false;
                activity.DeletedDate = DateTime.UtcNow;
                activity.DeletedBy = "user";
            }

            var tourSchedules = await _context.ToursSchedule
                .Where(bp => bp.TourId == tour.Id && bp.IsActive)
                .ToListAsync();

            foreach (var schedule in tourSchedules)
            {
                schedule.IsActive = false;
                schedule.DeletedDate = DateTime.UtcNow;
                schedule.DeletedBy = "user";
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}