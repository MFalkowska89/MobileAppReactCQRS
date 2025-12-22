using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Bookings.Commands;

namespace SolutionReact.Server.Mappings
{
    public class BookingMappingConfig
    {
        public static void Configure()
        {
            // ENTITY → DTO
            TypeAdapterConfig<Booking, BookingDto>
                .NewConfig()
                .Map(t => t.Id, src => src.Id)
                .Map(t => t.DestinationCity, src => src.TourSchedule.Tour.Destination.City)
                .Map(t => t.DestinationCountry, src => src.TourSchedule.Tour.Destination.Country)
                .Map(t => t.DestinationRegion, src => src.TourSchedule.Tour.Destination.Region)
                .Map(t => t.BookingStatusName, src => src.StatusOfEntity.StatusName)
                .Map(t => t.NoPax, src => src.NoPax)
                .Map(t => t.TotalPrice, src => src.TotalPrice)
                .Map(t => t.BookingDate, src => src.BookingDate)
                .Map(t => t.BookingParticipants, src => src.BookingParticipants); // this one needs to be fixed

            TypeAdapterConfig<CreateBookingCommand, Booking> // i should be also getting id of customers for booking participantS?
               .NewConfig()
               .Map(t => t.CustomerId, src => src.CustomerId)
               .Map(t => t.CustomTourScheduleId, src => src.CustomTourScheduleId)
               .Map(t => t.NoPax, src => src.NoPax)
                        .Map(dest => dest.BookingParticipants,
                src => src.BookingParticipantIds.Select(id => new BookingParticipant
                {
                    CustomerId = id,
                    IsActive = true,
                    AddedBy = "user",
                    AddedDate = DateTime.UtcNow
                }).ToList()
                );

            TypeAdapterConfig<UpdateBookingCommand, Booking>
              .NewConfig()
                  .Map(t => t.CustomTourScheduleId, src => src.CustomTourScheduleId)
                  .Map(t => t.NoPax, src => src.NoPax);
        }
    }
}
