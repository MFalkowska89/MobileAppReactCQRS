using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Customers.Commands;

namespace SolutionReact.Server.Requests.BookingParticipants.Commands
{
    public class CreateBookingParticipantValidator : AbstractValidator<CreateBookingParticipantCommand>
    {
        private readonly ApplicationDbContext _context;
        public CreateBookingParticipantValidator(ApplicationDbContext context)
        {
            _context = context;

            RuleFor(bp => bp.BookingId)
                .NotEmpty()
                .WithMessage("Booking Id is required.")
                .WithErrorCode("BookingIdRequired")
                .MustAsync(BookingIdExists)
                .WithMessage("Provided Booking Id doesn't exist.")
                .WithErrorCode("BookingDoesntExist");

            RuleForEach(b => b.ParticipantsToAdd)
               .SetValidator(new CreateCustomerRequestValidator());
        }

        private async Task<bool> BookingIdExists(int bookingId, CancellationToken cancellationToken)
        {
            return await _context.Bookings
                .AnyAsync(b => b.Id == bookingId && b.IsActive, cancellationToken);
        }
    }
}
