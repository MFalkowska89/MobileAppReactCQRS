using MediatR;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Commands;

namespace SolutionReact.Server.Handlers.Activities
{
    public class CreateActivityHandler : IRequestHandler<CreateActivityCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateActivityHandler(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<int> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = new Activity
            {
                Description = request.Description,
                IsActive = request.IsActive,
                AddedBy = request.AddedBy,
                AddedDate = request.AddedDate,
                ModifiedBy = request.ModifiedBy,
                ModifiedDate = request.ModifiedDate,
                DeletedBy = request.DeletedBy,
                DeletedDate = request.DeletedDate,
                Comments = request.Comments,
                ActivityName = request.ActivityName,
                MinimumAge = request.MinimumAge,
                MaximumAge = request.MaximumAge,
                FitnessLevel = request.FitnessLevel,
                DurationInMinutes = request.DurationInMinutes
            };
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync(cancellationToken);
            return activity.Id;
        }

    }
}
