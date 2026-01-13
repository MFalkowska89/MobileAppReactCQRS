using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Activities.Commands;

namespace SolutionReact.Server.Mappings
{
    public class ActivityMappingConfig
    {
        public static void Configure()
        {
            TypeAdapterConfig<CreateActivityCommand, Activity>
                .NewConfig()
                .Map(t => t.ActivityName, src => src.ActivityName)
                .Map(t => t.Description, src => src.Description)
                .Map(t => t.MinimumAge, src => src.MinimumAge)
                .Map(t => t.MaximumAge, src => src.MaximumAge)
                .Map(t => t.AdditionalRequirements, src => src.AdditionalRequirements)
                .Map(t => t.DurationInMinutes, src => src.DurationInMinutes)
                .Map(t => t.IsActive, src => true)
                .Map(t => t.AddedBy, src => "user")
                .Map(t => t.AddedDate, src => DateTime.UtcNow);

            TypeAdapterConfig<Activity, ActivityDto>
               .NewConfig()
               .Map(t => t.Id, src => src.Id)
               .Map(t => t.ActivityName, src => src.ActivityName)
                .Map(t => t.Description, src => src.Description)
                .Map(t => t.MinimumAge, src => src.MinimumAge)
                .Map(t => t.MaximumAge, src => src.MaximumAge)
                .Map(t => t.AdditionalRequirements, src => src.AdditionalRequirements)
                .Map(t => t.DurationInMinutes, src => src.DurationInMinutes);
        }
    }
}
