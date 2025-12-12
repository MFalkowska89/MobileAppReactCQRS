namespace SolutionReact.Server.Dto
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CustomTourScheduleId { get; set; }
        public int BookingStatusId { get; set; }
        public int NoPax { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
        public string? Comments { get; set; }

        public StatusOfEntityDto BookingStatus { get; set; } = null!;
        public TourScheduleForBookingDto TourSchedule { get; set; } = null!;
        public List<ParticipantsOfBookingDto> BookingParticipants { get; set; } = new List<ParticipantsOfBookingDto>();
    }

    public class TourScheduleForBookingDto
    {
        public int TourScheduleId { get; set; }
        public int TourId { get; set; }
        public string TourCode { get; set; } = string.Empty;
        public decimal TourPrice { get; set; }
        public DateTime TourDate { get; set; }
    }

    public class ParticipantsOfBookingDto
    {
        public int BookingParticipantId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
    }
}
