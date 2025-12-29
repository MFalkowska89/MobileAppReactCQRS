using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Tours.Queries;

namespace SolutionReact.Server.Handlers.Tours
{
    public class GetAllToursHandler : IRequestHandler<GetAllToursQuery, List<TourBasicDto>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllToursHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TourBasicDto>> Handle(
           GetAllToursQuery request,
           CancellationToken cancellationToken)
        {
            var tours = await _context.Tours
                .Where(t => t.IsActive)
                .Include(t => t.Destination)
                .OrderBy(t => t.Destination.Country)
                .AsNoTracking()
                .Select(t => t.Adapt<TourBasicDto>())
                .ToListAsync(cancellationToken);

            return tours;
        }
    }
}
