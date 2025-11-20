namespace SolutionReact.Server.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CustomTourScheduleId { get; set; }
        public int NoPax { get; set; }
        public decimal TotalPrice { get; set; }
        public string BookingStatus { get; set; } = string.Empty;
        public System.DateTime BookingDate { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual TourSchedule TourSchedule { get; set; } = null!;
        public virtual ICollection<BookingParticipant> BookingParticipants { get; set; } = new List<BookingParticipant>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
