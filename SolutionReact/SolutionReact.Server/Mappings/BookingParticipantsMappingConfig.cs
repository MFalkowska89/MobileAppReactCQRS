using Mapster;
using SolutionReact.Server.Dto;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Mappings
{
    public class BookingParticipantsMappingConfig
    {
        public static void Configure()
        {
            // ENTITY → DTO
            TypeAdapterConfig<BookingParticipant, CustomerDto>
                .NewConfig()
                .Map(t => t.CustomerId, src => src.Id)
                .Map(t => t.FirstName, src => src.Customer.FirstName)
                .Map(t => t.LastName, src => src.Customer.LastName)
                .Map(t => t.DateOfBirth, src => src.Customer.DateOfBirth)
                .Map(t => t.HomeAddress, src => src.Customer.HomeAddress)
                .Map(t => t.PostCode, src => src.Customer.PostCode)
                .Map(t => t.City, src => src.Customer.City)
                .Map(t => t.Country, src => src.Customer.Country)
                .Map(t => t.PhoneNumber, src => src.Customer.PhoneNumber)
                .Map(t => t.PhoneNumberExtra, src => src.Customer.PhoneNumberExtra)
                .Map(t => t.EmailAddress, src => src.Customer.EmailAddress);
        }
    }
}
