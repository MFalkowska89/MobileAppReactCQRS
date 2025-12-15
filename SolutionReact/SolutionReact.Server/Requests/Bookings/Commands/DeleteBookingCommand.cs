using MediatR;

namespace SolutionReact.Server.Requests.Bookings.Commands
{
    public class DeleteBookingCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteBookingCommand(int id)
        {
            Id = id; 
        }
    }
}
