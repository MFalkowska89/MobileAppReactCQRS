namespace SolutionReact.Server.Models
{
    public class Guide
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public System.DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string? PhoneNumberExtra { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
        public string HomeAddress { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public System.DateTime HiredFrom { get; set; }
        public Nullable<System.DateTime> HiredUntil { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }

        public virtual ICollection<TourSchedule> TourSchedules { get; set; } = new List<TourSchedule>();
    }
}
