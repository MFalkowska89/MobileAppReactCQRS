namespace SolutionReact.Server.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public int LengthInDays { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int MinParticipants { get; set; }
        public int MaxParticipants { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public string TourCode { get; set; } = string.Empty;
        public string TourName { get; set; } = string.Empty;


        public virtual Destination Destination { get; set; } = null!;

        public virtual ICollection<TourActivity> TourActivities { get; set; } = new List<TourActivity>();
        public virtual ICollection<TourSchedule> TourSchedules { get; set; } = new List<TourSchedule>();
    }
}
