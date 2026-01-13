namespace SolutionReact.Server.Dto
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int TourScheduleId { get; set; }
        public DateTime TourStartDate { get; set; }
        public DateTime TourEndDate { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public string DestinationCity { get; set; } = string.Empty;
        public string DestinationRegion { get; set; } = string.Empty;
        public string BookingStatusName { get; set; } = string.Empty;
        public int NoPax { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
        public List<BookingParticipantDto> BookingParticipants { get; set; } = new List<BookingParticipantDto>();
    }
}
