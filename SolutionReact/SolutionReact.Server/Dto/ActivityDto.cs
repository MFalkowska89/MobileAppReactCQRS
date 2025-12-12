namespace SolutionReact.Server.Dto
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? Comments { get; set; }
        public string ActivityName { get; set; } = string.Empty;
        public int? MinimumAge { get; set; }
        public int? MaximumAge { get; set; }
        public string? AdditionalRequirements { get; set; }
        public int DurationInMinutes { get; set; }
    }
}

