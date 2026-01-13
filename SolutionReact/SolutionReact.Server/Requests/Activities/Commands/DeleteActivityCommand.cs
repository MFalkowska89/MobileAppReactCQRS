using MediatR;

namespace SolutionReact.Server.Requests.Activities.Commands
{
    public class DeleteActivityCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteActivityCommand(int id)
        {
            Id = id;
        }
    }
}
