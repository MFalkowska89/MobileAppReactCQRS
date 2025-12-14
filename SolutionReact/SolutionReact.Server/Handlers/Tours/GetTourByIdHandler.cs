using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Tours.Queries;

namespace SolutionReact.Server.Handlers.Tours
{
    public class GetTourByIdHandler : IRequestHandler<GetTourByIdQuery, TourDto?>
    {
        private readonly ApplicationDbContext _context;
        public GetTourByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TourDto?> Handle(GetTourByIdQuery request, CancellationToken cancellationToken)
        {
            var tour = await _context.Tours
                .Where(t => t.Id == request.Id && t.IsActive)
                .Include(t => t.Destination)
                .Include(t => t.TourActivities)
                    .ThenInclude(ta => ta.Activity)
                .AsNoTracking()
                .Select(t => t.Adapt<TourDto>())
                .FirstOrDefaultAsync(cancellationToken);

            return tour;
        }
    }
}