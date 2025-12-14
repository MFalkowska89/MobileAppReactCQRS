using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Bookings.Queries
{
    public class GetBookingByIdQuery : IRequest<BookingDto?>
    {
        public int Id { get; set; }

        public GetBookingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
