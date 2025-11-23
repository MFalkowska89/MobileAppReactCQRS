namespace SolutionReact.Server.Models
{
    public class StatusOfEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string? StatusDescription { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<TourSchedule> TourSchedules { get; set; } = new List<TourSchedule>();
    }
}
