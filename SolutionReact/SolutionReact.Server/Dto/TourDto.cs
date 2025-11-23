using SolutionReact.Server.Models;

namespace SolutionReact.Server.Dto
{
    public class TourDto
    {
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public int LengthInDays { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int MaxParticipants { get; set; }
        public string? Comments { get; set; }
        public string TourType { get; set; }
        public string TourCode { get; set; }

        public virtual Destination Destination { get; set; } = null!;
    }
}
