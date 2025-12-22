using MediatR;

namespace SolutionReact.Server.Requests.Bookings.Commands
{
    public class CreateBookingCommand : IRequest<int>
    {
        public int CustomerId { get; set; }
        public int CustomTourScheduleId { get; set; }
        public int NoPax { get; set; }
        public List<int> BookingParticipantIds { get; set; }
    }
}
 