using MediatR;

namespace SolutionReact.Server.Requests.Activities.Commands
{
    public class CreateActivityCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public DateTime AddedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Comments { get; set; }
        public string ActivityName { get; set; } = string.Empty;
        public int? MinimumAge { get; set; }
        public int? MaximumAge { get; set; }
        public string FitnessLevel { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
    }
}
