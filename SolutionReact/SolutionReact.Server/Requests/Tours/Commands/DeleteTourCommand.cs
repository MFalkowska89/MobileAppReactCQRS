using MediatR;

namespace SolutionReact.Server.Requests.Tours.Commands
{
    public class DeleteTourCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteTourCommand(int id)
        {
            Id = id;
        }
    }
}