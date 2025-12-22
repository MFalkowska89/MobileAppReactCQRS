namespace SolutionReact.Server.Dto
{
    public class TourScheduleDto
    {
        public int Id { get; set; }
        public DateTime TourStartDate { get; set; }
        public DateTime TourEndDate { get; set; }
        public int AvailablePax { get; set; }
    }
}
