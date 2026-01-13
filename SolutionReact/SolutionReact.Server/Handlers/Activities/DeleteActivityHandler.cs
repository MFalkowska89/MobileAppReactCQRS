using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Commands;

namespace SolutionReact.Server.Handlers.Activities
{
    public class DeleteActivityHandler : IRequestHandler<DeleteActivityCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public DeleteActivityHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities
                .FirstOrDefaultAsync(b => b.Id == request.Id && b.IsActive);

            if (activity == null)
            {
                throw new KeyNotFoundException();
            }

            activity.IsActive = false;
            activity.DeletedDate = DateTime.UtcNow;
            activity.DeletedBy = "user";

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
