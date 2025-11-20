namespace SolutionReact.Server.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string EMailAddress { get; set; } = string.Empty;
        public System.TimeSpan CheckInTime { get; set; }
        public System.TimeSpan CheckOutTime { get; set; }
        public string HotelType { get; set; } = string.Empty;

        public virtual ICollection<TourSchedule> TourSchedules { get; set; } = new List<TourSchedule>();
    }
}
