using MediatR;

namespace SolutionReact.Server.Requests.Activities.Commands
{

    //zwraca id dodanej aktywnosci, klasa okresla jakie dane sa przyjmowane do dodania nowej aktywnosci
    public class CreateActivityCommand : IRequest<int>
    {
        public string Description { get; set; }
        public string? Comments { get; set; }
        public string ActivityName { get; set; }
        public int? MinimumAge { get; set; }
        public int? MaximumAge { get; set; }
        public string FitnessLevel { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
