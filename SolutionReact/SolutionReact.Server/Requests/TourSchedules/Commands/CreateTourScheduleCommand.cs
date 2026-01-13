using MediatR;

namespace SolutionReact.Server.Requests.TourSchedules.Commands
{
    public class CreateTourScheduleCommand : IRequest<int>
    {
        public int TourId { get; set; }
        public System.DateTime TourStartDate { get; set; }
        public int TourStatusId { get; set; }
    }
}
