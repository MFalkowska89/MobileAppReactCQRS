using MediatR;

namespace SolutionReact.Server.Requests.Customers.Commands
{
    public class UpdateCustomerCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public List<CustomersToUpdate> CustomersToUpdate { get; set; } = new();
    }

    public class CustomersToUpdate
    {
        public int Id { get; set; }
        public string HomeAddress { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? PhoneNumberExtra { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
    }
}
