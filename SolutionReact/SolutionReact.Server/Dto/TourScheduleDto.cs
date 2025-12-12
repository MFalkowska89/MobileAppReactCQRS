namespace SolutionReact.Server.Dto
{
    public class TourScheduleDto
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int TourStatusId { get; set; }
        public DateTime TourStartDate { get; set; }
        public DateTime TourEndDate { get; set; }
        public int AvailablePax { get; set; }
        public string? Comments { get; set; }

        public StatusOfEntityDto TourStatus { get; set; } = null!;
        public TourCodeDto TourCode { get; set; } = null!;
    }
}

public class TourCodeDto
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
}
