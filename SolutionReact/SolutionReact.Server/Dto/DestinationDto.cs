namespace SolutionReact.Server.Dto
{
    public class DestinationDto
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public string? TimeZone { get; set; }
    }
}
