using Mapster;
using MediatR;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Destinations.Commands;

namespace SolutionReact.Server.Handlers.Destinations
{
    public class CreateDestinationHandler : IRequestHandler<CreateDestinationCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateDestinationHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateDestinationCommand request, CancellationToken cancellationToken)
        {
            var destination = request.Adapt<Destination>();

            _context.Destination.Add(destination);
            await _context.SaveChangesAsync(cancellationToken);
            return destination.Id;
        }

    }
}
