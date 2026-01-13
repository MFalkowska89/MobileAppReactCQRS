using MediatR;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.Tours.Commands;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolutionReact.Server.Handlers.Tours
{
    public class UpdateTourHandler : IRequestHandler<UpdateTourCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public UpdateTourHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateTourCommand request, CancellationToken cancellationToken)
        {
            var tour = await _context.Tours
                .Include(t => t.TourActivities)
                .FirstOrDefaultAsync(b => b.Id == request.Id && b.IsActive);

            if (tour == null)
            {
                throw new KeyNotFoundException(nameof(tour));
            }

            tour.DestinationId = request.DestinationId;
            tour.LengthInDays = request.LengthInDays;
            tour.Description = request.Description;
            tour.FotoURL = request.FotoURL;
            tour.TourName = request.TourName;
            tour.MinParticipants = request.MinParticipants;
            tour.MaxParticipants = request.MaxParticipants;
            tour.TourCode = request.TourCode;
            tour.Price = request.Price;
            tour.Comments = request.Comments;

            foreach(var ata in request.ActivitiesToAdd)
            {
                tour.TourActivities.Add(new TourActivity
                {
                    ActivityId = ata.ActivityId,
                    TourId = tour.Id,
                    DayScheduled = ata.DayScheduled,
                    IsActive = true,
                    AddedBy = "user",
                    AddedDate = DateTime.Now,
                });
            }

            foreach(var ate in request.ActivitiesToEdit)
            {
                var currentActivity = await _context.TourActivities.FirstOrDefaultAsync(ta => ta.Id == ate.Id);

                if(currentActivity != null)
                {
                    currentActivity.DayScheduled = ate.DayScheduled;
                    currentActivity.ModifiedBy = "user";
                    currentActivity.ModifiedDate = DateTime.Now;
                }
            }

            foreach(var atd in  request.ActivitiesToDelete)
            {
                var currentActivity = await _context.TourActivities.FirstOrDefaultAsync(ta => ta.Id == atd.Id);

                if (currentActivity != null)
                {
                    currentActivity.IsActive = false; 
                    currentActivity.ModifiedBy = "user";
                    currentActivity.ModifiedDate = DateTime.Now;
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
