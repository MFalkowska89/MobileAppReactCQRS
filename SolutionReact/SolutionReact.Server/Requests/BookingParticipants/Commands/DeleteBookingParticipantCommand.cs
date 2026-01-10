using MediatR;

namespace SolutionReact.Server.Requests.BookingParticipants.Commands
{
    public class DeleteBookingParticipantCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteBookingParticipantCommand(int id)
        {
            Id = id;
        }
    }
}
