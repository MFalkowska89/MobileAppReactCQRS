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
                .Where(a => a.IsActive)
                .Select(a => new ActivityDto
                {
                    Id = a.Id,
                    Description = a.Description,
                    IsActive = a.IsActive,
                    AddedBy = a.AddedBy,
                    AddedDate = a.AddedDate,
                    ModifiedBy = a.ModifiedBy,
                    ModifiedDate = a.ModifiedDate,
                    DeletedBy = a.DeletedBy,
                    DeletedDate = a.DeletedDate,
                    Comments = a.Comments,
                    ActivityName = a.ActivityName,
                    MinimumAge = a.MinimumAge,
                    MaximumAge = a.MaximumAge,
                    FitnessLevel = a.FitnessLevel,
                    DurationInMinutes = a.DurationInMinutes
                })
                .ToListAsync(cancellationToken);

            return activities;
        }

    }
}
