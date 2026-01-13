using MediatR;

namespace SolutionReact.Server.Requests.Activities.Commands
{
    public class UpdateActivityCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ActivityName { get; set; } = string.Empty;
        public Nullable<int> MinimumAge { get; set; }
        public Nullable<int> MaximumAge { get; set; }
        public string AdditionalRequirements { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
    }
}
