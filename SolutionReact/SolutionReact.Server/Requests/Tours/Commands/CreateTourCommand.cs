using MediatR;

namespace SolutionReact.Server.Requests.Tours.Commands
{
    public class CreateTourCommand : IRequest<int>
    {
        public int DestinationId { get; set; }
        public int LengthInDays { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int MinParticipants { get; set; }
        public int MaxParticipants { get; set; }
        public string? Comments { get; set; }
        public string TourCode { get; set; } = string.Empty;
        public string TourName { get; set; } = string.Empty;
        public string FotoURL { get; set; } = string.Empty;
        public List<AddTourActivityCommand> TourActivities { get; set; } = new List<AddTourActivityCommand>();
    }

    public class AddTourActivityCommand
    {
        public int ActivityId { get; set; }
        public int DayScheduled {  get; set; }
    }
}

