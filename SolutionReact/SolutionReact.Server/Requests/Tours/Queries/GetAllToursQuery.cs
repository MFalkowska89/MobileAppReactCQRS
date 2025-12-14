using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Tours.Queries
{
    public class GetAllToursQuery : IRequest<List<TourBasicDto>>
    {
    }
}
