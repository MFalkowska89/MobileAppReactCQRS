using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;

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
                .Map(t => t.CustomerId, src => src.CustomerId)
                .Map(t => t.CustomTourScheduleId, src => src.CustomTourScheduleId)
                .Map(t => t.DestinationCity, src => src.TourSchedule.Tour.Destination.City)
                .Map(t => t.DestinationCountry, src => src.TourSchedule.Tour.Destination.Country)
                .Map(t => t.DestinationRegion, src => src.TourSchedule.Tour.Destination.Region)
                .Map(t => t.BookingStatusId, src => src.BookingStatusId)
                .Map(t => t.BookingStatusName, src => src.StatusOfEntity.StatusName)
                .Map(t => t.NoPax, src => src.NoPax)
                .Map(t => t.TotalPrice, src => src.TotalPrice)
                .Map(t => t.BookingDate, src => src.BookingDate)
                .Map(t => t.BookingParticipants, src => src.BookingParticipants); // here i need to get to customers somehow?
        }
    }
}
