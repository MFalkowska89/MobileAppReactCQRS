namespace SolutionReact.Server.Models
{
    public class TourSchedule
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public System.DateTime TourStartDate { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public int TourStatusId { get; set; }
        public int AvailablePax { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual Tour Tour { get; set; } = null!;
        public virtual StatusOfEntity StatusOfEntity { get; set; } = null!;
    }
}
