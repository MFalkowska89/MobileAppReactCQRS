using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Activities.Queries
{
    // zwroc wszystkie aktywnosci
    public class GetAllActivitiesQuery : IRequest<List<ActivityDto>>
    {
    }
}
