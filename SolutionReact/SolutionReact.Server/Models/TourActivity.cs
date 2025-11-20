namespace SolutionReact.Server.Models
{
    public class TourActivity
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int ActivityId { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }
        public Nullable<int> DayScheduled { get; set; }

        public virtual Activity Activity { get; set; } = null!;
        public virtual Tour Tour { get; set; } = null!;

    }
}
