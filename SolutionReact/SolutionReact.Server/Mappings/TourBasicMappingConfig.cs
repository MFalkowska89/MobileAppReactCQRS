using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Mappings
{
    public class TourBasicMappingConfig
    {
        public static void Configure()
        {
            TypeAdapterConfig<Tour, TourBasicDto>
                .NewConfig()
                .Map(t => t.Id, src => src.Id)
                .Map(t => t.DestinationCountry, src => src.Destination.Country)
                .Map(t => t.DestinationCity, src => src.Destination.City)
                .Map(t => t.DestinationRegion, src => src.Destination.Region)
                .Map(t => t.LengthInDays, src => src.LengthInDays)
                .Map(t => t.Name, src => src.TourName)
                .Map(t => t.Price, src => src.Price)
                .Map(t => t.FotoURL, src => src.FotoURL)
                .Map(t => t.Description, src => src.Description);
        }
    }
}
