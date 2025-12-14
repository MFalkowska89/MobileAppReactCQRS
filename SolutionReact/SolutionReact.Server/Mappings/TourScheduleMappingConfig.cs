using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Mappings
{
    public class TourScheduleMappingConfig
    {
        public static void Configure()
        {
            // ENTITY → DTO
            TypeAdapterConfig<TourSchedule, TourScheduleDto>
                .NewConfig()
                .Map(ts => ts.Id, src => src.Id)
                .Map(ts => ts.TourId, src => src.TourId)
                .Map(ts => ts.AvailablePax, src => src.AvailablePax)
                .Map(ts => ts.TourStartDate, src => src.TourStartDate)
                .Map(ts => ts.TourEndDate, src => src.TourStartDate.AddDays(src.Tour.LengthInDays));
        }
    }
}
