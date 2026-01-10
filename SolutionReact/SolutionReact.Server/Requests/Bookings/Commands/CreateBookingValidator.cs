using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Customers.Commands;

namespace SolutionReact.Server.Requests.Bookings.Commands
{
    public class CreateBookingValidator : AbstractValidator<CreateBookingCommand>
    {
        private readonly ApplicationDbContext _context;

        public CreateBookingValidator(ApplicationDbContext context)
        {
            _context = context;

            RuleFor(b => b.CustomTourScheduleId)
                .NotEmpty()
                .WithMessage("Tour Schedule Id is required.")
                .WithErrorCode("CustomTourScheduleIdRequired")
                .MustAsync(TourScheduleIdExists)
                .WithMessage("Provided Tour Schedule Id doesn't exist.")
                .WithErrorCode("TourScheduleDoesntExist")
                .MustAsync(TourScheduleNotInThePast)
                .WithMessage("Tour schedule not valid.")
                .WithErrorCode("CannotBookInPast");

            RuleFor(b => b.Customers)
                .NotNull()
                .WithMessage("At least one customer is required.")
                .WithErrorCode("CustomersRequired")
                .Must(c => c.Any())
                .WithMessage("At least one customer is required.")
                .WithErrorCode("CustomersRequired");

            RuleForEach(b => b.Customers)
                .SetValidator(new CreateCustomerRequestValidator());
        }

        private async Task<bool> TourScheduleIdExists(int tourScheduleId, CancellationToken cancellationToken)
        {
            return await _context.ToursSchedule
                .AnyAsync(ts => ts.Id == tourScheduleId && ts.IsActive, cancellationToken);
        }

        private async Task<bool> TourScheduleNotInThePast(int tourScheduleId, CancellationToken cancellationToken)
        {
            var tourSchedule = await _context.ToursSchedule
                .AsNoTracking()
                .FirstOrDefaultAsync(ts => ts.Id == tourScheduleId && ts.IsActive, cancellationToken);

            if (tourSchedule == null)
                return false;

            return tourSchedule.TourStartDate.Date >= DateTime.UtcNow.Date;
        }
    }
}
