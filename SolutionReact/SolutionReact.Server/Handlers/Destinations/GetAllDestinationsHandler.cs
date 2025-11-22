using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Destinations.Queries;

namespace SolutionReact.Server.Handlers.Destinations
{
    public class GetAllDestinationsHandler : IRequestHandler<GetAllDestinationsQuery, List<DestinationDto>>
    {
        private readonly ApplicationDbContext _context;
        public GetAllDestinationsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DestinationDto>> Handle(GetAllDestinationsQuery request, CancellationToken cancellationToken)
        {
            var destinations = await _context.Destination
                .AsNoTracking()
                .Where(d => d.IsActive)
                .Select(d => d.Adapt<DestinationDto>())
                .ToListAsync(cancellationToken);

            return destinations;
        }

    }
}
