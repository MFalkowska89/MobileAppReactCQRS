namespace SolutionReact.Server.Dto
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public string ActivityName { get; set; } = string.Empty;
        public Nullable<int> MinimumAge { get; set; }
        public Nullable<int> MaximumAge { get; set; }
        public string FitnessLevel { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
    }
}
