using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Requests.Bookings.Commands
{
    public class UpdateBookingValidator : AbstractValidator<UpdateBookingCommand>
    {
        private readonly ApplicationDbContext _context;

        public UpdateBookingValidator(ApplicationDbContext context)
        {
            _context = context;

            RuleFor(b => b.Id)
                .NotEmpty()
                .WithMessage("BookingId is required.")
                .WithErrorCode("BookingIdRequired")
                .MustAsync(BookingIdExists)
                .WithMessage("Provided Booking Id doesn't exist")
                .WithErrorCode("BookingDoesntExist");
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
        }

        private async Task<bool> BookingIdExists(int bookingId, CancellationToken cancellationToken)
        {
            return await _context.Bookings.AnyAsync(b => b.Id == bookingId && b.IsActive, cancellationToken);
        }

        private async Task<bool> TourScheduleIdExists(int tourScheduleId,  CancellationToken cancellationToken)
        {
            return await _context.ToursSchedule.AnyAsync(ts => ts.Id == tourScheduleId && ts.IsActive, cancellationToken);
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

