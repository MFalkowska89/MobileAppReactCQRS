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
            // to jest do wyslania na front - activity model = database, activity dto - data wyslana na front
            TypeAdapterConfig<Activity, ActivityDto>
                .NewConfig()
                .Map(d => d.Id, s => s.Id)
                .Map(d => d.Description, s => s.Description)
                .Map(d => d.Comments, s => s.Comments)
                .Map(d => d.ActivityName, s => s.ActivityName)
                .Map(d => d.MinimumAge, s => s.MinimumAge)
                .Map(d => d.MaximumAge, s => s.MaximumAge)
                .Map(d => d.FitnessLevel, s => s.FitnessLevel)
                .Map(d => d.DurationInMinutes, s => s.DurationInMinutes);

            // to dodajemy do back - create activity command - request z frontu, activity - model bazy danych
            TypeAdapterConfig<CreateActivityCommand, Activity>
                .NewConfig()
                .Map(d => d.Description, s => s.Description)
                .Map(d => d.Comments, s => s.Comments)
                .Map(d => d.ActivityName, s => s.ActivityName)
                .Map(d => d.MinimumAge, s => s.MinimumAge)
                .Map(d => d.MaximumAge, s => s.MaximumAge)
                .Map(d => d.FitnessLevel, s => s.FitnessLevel)
                .Map(d => d.DurationInMinutes, s => s.DurationInMinutes)
                .Map(d => d.IsActive, _ => true);
        }
    }
}