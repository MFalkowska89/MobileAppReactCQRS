namespace SolutionReact.Server.Dto
{
    public class BookingDto // czy to moze byc tak czy powinnam miec oddzielna klase w ktorej to wszystko jest wrzucone? 
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } // to chyba powinnam wywalic
        public int CustomTourScheduleId { get; set; }
        public DateTime TourStartDate { get; set; }
        public DateTime TourEndDate { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public string DestinationCity { get; set; } = string.Empty;
        public string DestinationRegion { get; set; } = string.Empty;
        public int BookingStatusId { get; set; }
        public string BookingStatusName { get; set; } = string.Empty;
        public int NoPax { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
        public List<CustomerDto> BookingParticipants { get; set; } = new List<CustomerDto>();
    }
}
