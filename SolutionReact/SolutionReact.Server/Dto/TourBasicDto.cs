namespace SolutionReact.Server.Dto
{
    public class TourBasicDto
    {
        public int Id { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public string DestinationCity { get; set; } = string.Empty;
        public string DestinationRegion { get; set; } = string.Empty;
        public int LengthInDays { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string FotoURL { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
