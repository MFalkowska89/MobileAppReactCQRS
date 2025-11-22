using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Queries;

namespace SolutionReact.Server.Handlers.Activities
{
    public class GetAllActivitiesHandler : IRequestHandler<GetAllActivitiesQuery, List<ActivityDto>>
    {
        private readonly ApplicationDbContext _context;
        public GetAllActivitiesHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ActivityDto>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activities = await _context.Activities
                .AsNoTracking()
                .Where(a => a.IsActive)
                .Select(a => a.Adapt<ActivityDto>())
                .ToListAsync(cancellationToken);

            return activities;
        }

    }
}
