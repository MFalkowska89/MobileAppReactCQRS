using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Queries;

namespace SolutionReact.Server.Handlers.Activities
{
    public class GetActivityByIdHandler : IRequestHandler<GetActivityByIdQuery, ActivityDto?>
    {
        private readonly ApplicationDbContext _context;
        public GetActivityByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActivityDto?> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities
                .Where(t => t.Id == request.Id && t.IsActive)
                .AsNoTracking()
                .Select(t => t.Adapt<ActivityDto>())
                .FirstOrDefaultAsync(cancellationToken);

            return activity;
        }
    }
}