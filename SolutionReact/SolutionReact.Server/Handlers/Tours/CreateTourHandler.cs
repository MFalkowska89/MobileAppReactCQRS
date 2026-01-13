using Mapster;
using MediatR;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Tours.Commands;

namespace SolutionReact.Server.Handlers.Tours
{
    public class CreateTourHandler : IRequestHandler<CreateTourCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateTourHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTourCommand request, CancellationToken cancellationToken)
        {
            var tour = request.Adapt<Tour>();

            tour.TourActivities = request.TourActivities
            .Select(a => new TourActivity
             {
                 ActivityId = a.ActivityId,
                 DayScheduled = a.DayScheduled,
                 IsActive = true,
                 AddedBy = "user",
                 AddedDate = DateTime.Now,
             })
             .ToList();

            _context.Tours.Add(tour);

            await _context.SaveChangesAsync(cancellationToken);

            return tour.Id;
        }
    }
}
