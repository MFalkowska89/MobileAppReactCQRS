namespace SolutionReact.Server.Models
{
    public class TourSchedule
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public Nullable<int> GuideId { get; set; }
        public Nullable<int> HotelId { get; set; }
        public Nullable<int> FlightDepartureId { get; set; }
        public Nullable<int> FlightReturnId { get; set; }
        public System.DateTime TourStartDate { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public string TourStatus { get; set; } = string.Empty;
        public int AvailablePax { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual Guide Guide { get; set; } = null!;
        public virtual Hotel Hotel { get; set; } = null!;
        public virtual Tour Tour { get; set; } = null!;

    }
}
