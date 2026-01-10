using MediatR;
using SolutionReact.Server.Requests.Bookings.Commands;
using System.Reflection.Metadata;

namespace SolutionReact.Server.Requests.BookingParticipants.Commands
{
    public class CreateBookingParticipantCommand : IRequest<Unit>
    {
        public int BookingId { get; set; }
        public List<CreateCustomerRequest> ParticipantsToAdd { get; set; } = new List<CreateCustomerRequest>();
    }
}
