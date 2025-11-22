using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Destinations.Commands;

namespace SolutionReact.Server.Mappings
{
    public class DestinationMappingConfig
    {
        public static void Configure()
        {
            // ENTITY → DTO
            TypeAdapterConfig<Destination, DestinationDto>
                .NewConfig()
                .Map(d => d.Id, s => s.Id)
                .Map(d => d.Country, s => s.Country)
                .Map(d => d.Region, s => s.Region)
                .Map(d => d.City, s => s.City)
                .Map(d => d.IsActive, s => s.IsActive)
                .Map(d => d.AddedBy, s => s.AddedBy)
                .Map(d => d.AddedDate, s => s.AddedDate)
                .Map(d => d.ModifiedBy, s => s.ModifiedBy)
                .Map(d => d.ModifiedDate, s => s.ModifiedDate)
                .Map(d => d.DeletedBy, s => s.DeletedBy)
                .Map(d => d.DeletedDate, s => s.DeletedDate)
                .Map(d => d.Comments, s => s.Comments)
                .Map(d => d.TimeZone, s => s.TimeZone);

            // CREATE COMMAND → ENTITY
            TypeAdapterConfig<CreateDestinationCommand, Destination>
                .NewConfig()
                .Map(d => d.Country, s => s.Country)
                .Map(d => d.Region, s => s.Region)
                .Map(d => d.City, s => s.City)
                .Map(d => d.IsActive, s => true)
                .Map(d => d.AddedBy, s => s.AddedBy)
                .Map(d => d.AddedDate, s => s.AddedDate)
                .Map(d => d.ModifiedBy, s => s.ModifiedBy)
                .Map(d => d.ModifiedDate, s => s.ModifiedDate)
                .Map(d => d.DeletedBy, s => s.DeletedBy)
                .Map(d => d.DeletedDate, s => s.DeletedDate)
                .Map(d => d.Comments, s => s.Comments)
                .Map(d => d.TimeZone, s => s.TimeZone)
                .Ignore(d => d.Id);
        }
    }
}
