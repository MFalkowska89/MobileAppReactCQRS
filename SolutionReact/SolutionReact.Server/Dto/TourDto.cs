using SolutionReact.Server.Models;

namespace SolutionReact.Server.Dto
{
    public class TourDto // only tour for the customer dto
    {
        public int Id { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public string DestinationCity { get; set; } = string.Empty;
        public string DestinationRegion { get; set; } = string.Empty;
        public int LengthInDays { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int MaxParticipants { get; set; }
        public int MinParticipants { get; set; }
        public string TourCode { get; set; } = string.Empty;
        public string FotoURL { get; set; } = string.Empty;
        public List<ActivityDto> TourActivities { get; set; } = new List<ActivityDto>();
    }
}
