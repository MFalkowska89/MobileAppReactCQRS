using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Customers.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerDto?>
    {
        public int Id { get; set; }

        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }
    }
}