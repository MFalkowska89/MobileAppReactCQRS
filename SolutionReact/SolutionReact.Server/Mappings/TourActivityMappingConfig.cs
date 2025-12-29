using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Mappings
{
    public class TourActivityMappingConfig
    {
        public static void Configure()
        {
            // ENTITY → DTO
            TypeAdapterConfig<TourActivity, TourActivityDto>
                .NewConfig()
                .Map(t => t.ActivityId, src => src.Activity.Id)
                .Map(t => t.DayScheduled, src => src.DayScheduled)
                .Map(t => t.ActivityName, src => src.Activity.ActivityName)
                .Map(t => t.Description, src => src.Activity.Description)
                .Map(t => t.MaximumAge, src => src.Activity.MaximumAge)
                .Map(t => t.MinimumAge, src => src.Activity.MinimumAge)
                .Map(t => t.AdditionalRequirements, src => src.Activity.AdditionalRequirements)
                .Map(t => t.DurationInMinutes, src => src.Activity.DurationInMinutes);
        }
    }
}

