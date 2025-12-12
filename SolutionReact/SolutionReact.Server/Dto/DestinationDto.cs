namespace SolutionReact.Server.Dto
{
    public class DestinationDto
    {
        public int Id { get; set; }
        public string Country { get; set; } = string.Empty;
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Comments { get; set; }
    }
}
