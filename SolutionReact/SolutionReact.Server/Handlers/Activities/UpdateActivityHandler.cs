using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Commands;

namespace SolutionReact.Server.Handlers.Activities
{
    public class UpdateActivityHandler : IRequestHandler<UpdateActivityCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public UpdateActivityHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var existingActivity = await _context.Activities
                .FirstOrDefaultAsync(c => c.Id == request.Id && c.IsActive);

            if (existingActivity == null)
            {
                throw new KeyNotFoundException("Could not find the activity with provided ID");
            }

            existingActivity.ActivityName = request.ActivityName;
            existingActivity.Description = request.Description;
            existingActivity.MaximumAge = request.MaximumAge;
            existingActivity.MinimumAge = request.MinimumAge;
            existingActivity.AdditionalRequirements = request.AdditionalRequirements;
            existingActivity.DurationInMinutes = request.DurationInMinutes;
            existingActivity.ModifiedBy = "user";
            existingActivity.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
