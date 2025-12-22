using MediatR;
using SolutionReact.Server.Dto;

namespace SolutionReact.Server.Requests.Customers.Commands
{
    public class CreateCustomerCommand : IRequest<List<int>>
    {
        public List<CustomerDto> Customers { get; set; } = new();
    }
}
