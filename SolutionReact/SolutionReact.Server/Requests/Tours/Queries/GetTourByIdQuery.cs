using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Tours.Queries
{
    public class GetTourByIdQuery : IRequest<TourDto?>
    {
        public int Id { get; set; }

        public GetTourByIdQuery(int id)
        {
            Id = id;
        }
    }
}
