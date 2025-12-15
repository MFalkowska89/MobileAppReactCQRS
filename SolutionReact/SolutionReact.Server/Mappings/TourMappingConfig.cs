using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Mappings
{
    public class TourMappingConfig
    {
        public static void Configure()
        {
            // ENTITY → DTO
            TypeAdapterConfig<Tour, TourDto>
                .NewConfig()
                .Map(t => t.Id, src => src.Id)
                .Map(t => t.DestinationId, src => src.DestinationId)
                .Map(t => t.DestinationCountry, src => src.Destination.Country)
                .Map(t => t.DestinationCity, src => src.Destination.City)
                .Map(t => t.DestinationRegion, src => src.Destination.Region)
                .Map(t => t.LengthInDays, src => src.LengthInDays)
                .Map(t => t.Name, src => src.TourName)
                .Map(t => t.Description, src => src.Description)
                .Map(t => t.Price, src => src.Price)
                .Map(t => t.FotoURL, src => src.FotoURL)
                .Map(t => t.MinParticipants, src => src.MinParticipants)
                .Map(t => t.MaxParticipants, src => src.MaxParticipants)
                .Map(t => t.TourCode, src => src.TourCode)
                .Map(t => t.TourActivities, src => src.TourActivities);
        }
    }
}
