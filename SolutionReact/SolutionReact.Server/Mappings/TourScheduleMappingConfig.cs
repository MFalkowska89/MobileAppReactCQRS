using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.TourSchedules.Commands;

namespace SolutionReact.Server.Mappings
{
    public class TourScheduleMappingConfig
    {
        public static void Configure()
        {
            TypeAdapterConfig<TourSchedule, TourScheduleDto>
                .NewConfig()
                .Map(ts => ts.Id, src => src.Id)
                .Map(ts => ts.AvailablePax, src => src.AvailablePax)
                .Map(ts => ts.TourStartDate, src => src.TourStartDate)
                .Map(ts => ts.TourEndDate, src => src.TourStartDate.AddDays(src.Tour.LengthInDays));

            TypeAdapterConfig<CreateTourScheduleCommand, TourSchedule>
              .NewConfig()
              .Map(ts => ts.TourId, src => src.TourId)
              .Map(ts => ts.TourStatusId, src => src.TourStatusId)
              .Map(ts => ts.TourStartDate, src => src.TourStartDate)
              .Map(ts => ts.IsActive, src => true)
              .Map(ts => ts.AddedBy, src => "user")
              .Map(ts => ts.AddedDate, src => DateTime.UtcNow);
        }
    }
}
