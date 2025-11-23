namespace SolutionReact.Server.Dto
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string? Comments { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> MinimumAge { get; set; }
        public Nullable<int> MaximumAge { get; set; }
        public string FitnessLevel { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
