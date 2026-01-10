using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.BookingParticipants.Commands;

namespace SolutionReact.Server.Handlers.BookingParticipants
{
    public class CreateBookingParticipantHandler : IRequestHandler<CreateBookingParticipantCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public CreateBookingParticipantHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateBookingParticipantCommand request, CancellationToken cancellationToken)
        {
            // dodac walidacje

            var customersList = new List<Customer>();

            foreach (var customer in request.ParticipantsToAdd)
            {
                var existingCustomer = await _context.Customers
                    .FirstOrDefaultAsync(c => c.EmailAddress == customer.EmailAddress
                                        && c.FirstName == customer.FirstName
                                        && c.LastName == customer.LastName
                                        && c.DateOfBirth == customer.DateOfBirth
                                        && c.IsActive);

                if (existingCustomer != null)
                {
                    existingCustomer.HomeAddress = customer.HomeAddress;
                    existingCustomer.PostCode = customer.PostCode;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.PhoneNumber = customer.PhoneNumber;
                    existingCustomer.PhoneNumberExtra = customer.PhoneNumberExtra;
                    existingCustomer.ModifiedBy = "user";
                    existingCustomer.ModifiedDate = DateTime.UtcNow;

                    customersList.Add(existingCustomer);
                }

                else
                {
                    var newCustomer = customer.Adapt<Customer>();
                    _context.Customers.Add(newCustomer);
                    customersList.Add(newCustomer);
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            var booking = await _context.Bookings
                .FirstAsync(b => b.Id == request.BookingId, cancellationToken);

            var tourSchedule = await _context.ToursSchedule
                .Where(testc => testc.Id == booking.CustomTourScheduleId)
                .Include(ts => ts.Tour)
                .FirstAsync();

            booking.NoPax = booking.NoPax + customersList.Count;
            booking.TotalPrice = tourSchedule.Tour.Price * booking.NoPax;

            foreach (var bookingParticipant in customersList)
            {
                var newBookingParticipant = new BookingParticipant
                {
                    BookingId = booking.Id,
                    CustomerId = bookingParticipant.Id,
                    IsActive = true,
                    AddedBy = "user",
                    AddedDate = DateTime.UtcNow
                };

                _context.BookingsParticipant.Add(newBookingParticipant);
            }

            tourSchedule.AvailablePax -= customersList.Count;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}