using MediatR;

namespace SolutionReact.Server.Requests.Tours.Commands
{
    public class UpdateTourCommand : IRequest<Unit>
    {
        public int Id { get; set; }
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
        public List<ActivitiesToAdd> ActivitiesToAdd { get; set; } = new List<ActivitiesToAdd>();
        public List<ActivitiesToEdit> ActivitiesToEdit { get; set; } = new List<ActivitiesToEdit>();
        public List<ActivitiesToDelete> ActivitiesToDelete { get; set; } = new List<ActivitiesToDelete>();
    }

    public class ActivitiesToAdd
    {
        public int ActivityId { get; set; }
        public int DayScheduled { get; set; }
    }

    public class ActivitiesToEdit
    {
        public int Id { get; set; }
        public int DayScheduled { get; set; }
    }

    public class ActivitiesToDelete
    {
        public int Id { get; set; }
    }
}