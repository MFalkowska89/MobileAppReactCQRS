using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Destinations.Queries
{
    public class GetAllDestinationsQuery : IRequest<List<DestinationDto>>
    {
    }
}
