using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Customers.Queries;

namespace SolutionReact.Server.Handlers.Customers
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto?>
    {
        private readonly ApplicationDbContext _context;
        public GetCustomerByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerDto?> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers
                .Where(c => c.Id == request.Id && c.IsActive)
                .AsNoTracking()
                .Select(t => t.Adapt<CustomerDto>())
                .FirstOrDefaultAsync(cancellationToken);

            return customer;
        }
    }
}