using Mapster;
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
            var activity = request.Adapt<Activity>();

            _context.Activities.Add(activity);
            await _context.SaveChangesAsync(cancellationToken);
            return activity.Id;
        }

    }
}
