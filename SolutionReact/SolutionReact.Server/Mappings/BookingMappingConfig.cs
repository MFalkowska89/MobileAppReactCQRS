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
            TypeAdapterConfig<Booking, BookingDto>
                .NewConfig()
                .Map(t => t.Id, src => src.Id)
                .Map(t => t.TourId, src => src.TourSchedule.Tour.Id)
                .Map(t => t.TourScheduleId, src => src.TourSchedule.Id)
                .Map(t => t.TourStartDate, src => src.TourSchedule.TourStartDate)
                .Map(t => t.TourEndDate, src => src.TourSchedule.TourStartDate.AddDays(src.TourSchedule.Tour.LengthInDays))
                .Map(t => t.DestinationCity, src => src.TourSchedule.Tour.Destination.City)
                .Map(t => t.DestinationCountry, src => src.TourSchedule.Tour.Destination.Country)
                .Map(t => t.DestinationRegion, src => src.TourSchedule.Tour.Destination.Region)
                .Map(t => t.BookingStatusName, src => src.StatusOfEntity.StatusName)
                .Map(t => t.TotalPrice, src => src.TotalPrice)
                .Map(t => t.NoPax, src => src.NoPax)
                .Map(t => t.BookingDate, src => src.BookingDate)
                .Map(t => t.BookingParticipants, src => src.BookingParticipants.Adapt<List<BookingParticipantDto>>());

            TypeAdapterConfig<CreateBookingCommand, Booking>
               .NewConfig()
               .Map(t => t.CustomTourScheduleId, src => src.CustomTourScheduleId)
               .Map(t => t.BookingStatusId, src => 2)
               .Map(t => t.IsActive, src => true)
               .Map(t => t.AddedBy, src => "user")
               .Map(t => t.AddedDate, src => DateTime.UtcNow)
               .Map(t => t.BookingDate, src => DateTime.UtcNow);

            TypeAdapterConfig<UpdateBookingCommand, Booking>
              .NewConfig()
                  .Map(t => t.CustomTourScheduleId, src => src.CustomTourScheduleId)
                  .Map(t => t.ModifiedBy, src => "user")
                  .Map(t => t.ModifiedDate, src => DateTime.UtcNow);
        }
    }
}
