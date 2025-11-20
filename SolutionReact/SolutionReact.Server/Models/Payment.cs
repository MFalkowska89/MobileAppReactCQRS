namespace SolutionReact.Server.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public System.DateTime DateInvoice { get; set; }
        public decimal AmountInvoice { get; set; }
        public Nullable<System.DateTime> DatePayment { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public string? PaymentMethod { get; set; }
        public string? TransactionReference { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public System.DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string? Comments { get; set; }

        public virtual Booking Booking { get; set; } = null!;

    }
}
