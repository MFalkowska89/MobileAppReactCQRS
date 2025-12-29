using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.TourSchedules.Queries;

namespace SolutionReact.Server.Handlers.TourSchedules
{
    public class GetTourSchedulesByTourIdHandler : IRequestHandler<GetTourSchedulesByTourIdQuery, List<TourScheduleDto>>
    {
        private readonly ApplicationDbContext _context;
        public GetTourSchedulesByTourIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TourScheduleDto>> Handle(GetTourSchedulesByTourIdQuery request, CancellationToken cancellationToken)
        {
            var tourScheudles = await _context.ToursSchedule
                .Where(ts => ts.TourId == request.TourId && ts.IsActive)
                .Include(ts => ts.Tour)
                .OrderBy(ts => ts.TourStartDate)
                .ThenBy(ts => ts.AvailablePax)
                .AsNoTracking()
                .Select(ts => ts.Adapt<TourScheduleDto>())
                .ToListAsync(cancellationToken);

            return tourScheudles;
        }
    }
}