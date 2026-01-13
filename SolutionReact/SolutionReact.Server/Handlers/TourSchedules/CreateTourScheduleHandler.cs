using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.TourSchedules.Commands;

namespace SolutionReact.Server.Handlers.TourSchedules
{
    public class CreateTourScheduleHandler : IRequestHandler<CreateTourScheduleCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateTourScheduleHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTourScheduleCommand request, CancellationToken cancellationToken)
        {
            var ts = request.Adapt<TourSchedule>();

            var tour = await _context.Tours.FirstOrDefaultAsync(t => t.Id == request.TourId);

            if (tour != null)
            {
                ts.AvailablePax = tour.MaxParticipants;
            }

            _context.ToursSchedule.Add(ts);

            await _context.SaveChangesAsync(cancellationToken);

            return ts.TourId;
        }
    }
}