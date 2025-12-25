using MediatR;

namespace SolutionReact.Server.Requests.Bookings.Commands
{
    public class CreateBookingCommand : IRequest<int>
    {
        public int CustomTourScheduleId { get; set; }
        public int NoPax { get; set; }
        public List<BookingParticipantData> Customers { get; set; }
    }

    public class BookingParticipantData
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? PhoneNumberExtra { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
    }
}




 