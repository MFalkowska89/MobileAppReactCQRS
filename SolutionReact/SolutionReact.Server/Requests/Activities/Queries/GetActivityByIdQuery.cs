using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Activities.Queries
{
    public class GetActivityByIdQuery : IRequest<ActivityDto?>
    {
        public int Id { get; set; }

        public GetActivityByIdQuery(int id)
        {
            Id = id;
        }
    }
}