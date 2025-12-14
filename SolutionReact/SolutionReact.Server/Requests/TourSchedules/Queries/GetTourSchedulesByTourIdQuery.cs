using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.TourSchedules.Queries
{
    public class GetTourSchedulesByTourIdQuery : IRequest<List<TourScheduleDto>>
    {
        public int TourId { get; set; }

        public GetTourSchedulesByTourIdQuery(int tourId)
        {
            TourId = tourId;
        }
    }
}
