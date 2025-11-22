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
            TypeAdapterConfig<Activity, ActivityDto>
                .NewConfig()
                .Map(d => d.Id, s => s.Id)
                .Map(d => d.Description, s => s.Description)
                .Map(d => d.IsActive, s => s.IsActive)
                .Map(d => d.AddedBy, s => s.AddedBy)
                .Map(d => d.AddedDate, s => s.AddedDate)
                .Map(d => d.ModifiedBy, s => s.ModifiedBy)
                .Map(d => d.ModifiedDate, s => s.ModifiedDate)
                .Map(d => d.DeletedBy, s => s.DeletedBy)
                .Map(d => d.DeletedDate, s => s.DeletedDate)
                .Map(d => d.Comments, s => s.Comments)
                .Map(d => d.ActivityName, s => s.ActivityName)
                .Map(d => d.MinimumAge, s => s.MinimumAge)
                .Map(d => d.MaximumAge, s => s.MaximumAge)
                .Map(d => d.FitnessLevel, s => s.FitnessLevel)
                .Map(d => d.DurationInMinutes, s => s.DurationInMinutes);

            TypeAdapterConfig<CreateActivityCommand, Activity>
                .NewConfig()
                .Map(d => d.Description, s => s.Description)
                .Map(d => d.IsActive, s => true)
                .Map(d => d.AddedBy, s => s.AddedBy)
                .Map(d => d.AddedDate, s => s.AddedDate)
                .Map(d => d.ModifiedBy, s => s.ModifiedBy)
                .Map(d => d.ModifiedDate, s => s.ModifiedDate)
                .Map(d => d.DeletedBy, s => s.DeletedBy)
                .Map(d => d.DeletedDate, s => s.DeletedDate)
                .Map(d => d.Comments, s => s.Comments)
                .Map(d => d.ActivityName, s => s.ActivityName)
                .Map(d => d.MinimumAge, s => s.MinimumAge)
                .Map(d => d.MaximumAge, s => s.MaximumAge)
                .Map(d => d.FitnessLevel, s => s.FitnessLevel)
                .Map(d => d.DurationInMinutes, s => s.DurationInMinutes)
                .Ignore(d => d.Id);

        }
    }
}