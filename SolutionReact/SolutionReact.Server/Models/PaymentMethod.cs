namespace SolutionReact.Server.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
