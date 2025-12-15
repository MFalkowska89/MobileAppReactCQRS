using MediatR;

namespace SolutionReact.Server.Requests.Bookings.Commands
{
    public class UpdateBookingCommand : IRequest <Unit>
    {
        public int Id { get; set; }
        public int CustomTourScheduleId { get; set; }
        public int NoPax { get; set; }
    }
}
