using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Bookings.Queries
{
    public class GetBookingByIdQuery : IRequest<List<BookingDto>>
    {
    }
}
