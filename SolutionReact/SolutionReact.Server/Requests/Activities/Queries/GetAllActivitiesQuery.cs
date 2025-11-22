using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Activities.Queries
{
    public class GetAllActivitiesQuery : IRequest<List<ActivityDto>>
    {
    }
}
