using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;
using SolutionReact.Server.Requests.BookingParticipants.Commands;
using SolutionReact.Server.Requests.Bookings.Commands;

namespace SolutionReact.Server.Mappings
{
    public class CustomerMappingConfig
    {
        public static void Configure()
        {
            //ENTITY → DTO
            TypeAdapterConfig<CreateCustomerRequest, Customer>
                .NewConfig()
                .Map(t => t.FirstName, src => src.FirstName)
                .Map(t => t.LastName, src => src.LastName)
                .Map(t => t.DateOfBirth, src => src.DateOfBirth)
                .Map(t => t.HomeAddress, src => src.HomeAddress)
                .Map(t => t.PostCode, src => src.PostCode)
                .Map(t => t.City, src => src.City)
                .Map(t => t.Country, src => src.Country)
                .Map(t => t.PhoneNumber, src => src.PhoneNumber)
                .Map(t => t.PhoneNumberExtra, src => src.PhoneNumberExtra)
                .Map(t => t.EmailAddress, src => src.EmailAddress)
                .Map(t => t.IsActive, src => true)
                .Map(t => t.AddedBy, src => "user")
                .Map(t => t.AddedDate, src => DateTime.UtcNow);
        }
    }
}
