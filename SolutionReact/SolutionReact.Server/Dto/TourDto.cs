using SolutionReact.Server.Models;

namespace SolutionReact.Server.Dto
{
    public class TourDto
    {
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public int LengthInDays { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int MaxParticipants { get; set; }
        public int MinParticipants { get; set; }
        public string TourCode { get; set; } = string.Empty;
        public string FotoURL { get; set; } = string.Empty;
        public string? Comments { get; set; }

        public DestinationDto Destination { get; set; } = null!;
        public List<TourActivitiesDto> TourActivities { get; set; } = new List<TourActivitiesDto>();
    }

    public class TourActivitiesDto
    {
        public int TourActivityId { get; set; }
        public int ActivityId { get; set; }
        public string ActivityName { get; set; } = string.Empty;
        public int? DayNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
