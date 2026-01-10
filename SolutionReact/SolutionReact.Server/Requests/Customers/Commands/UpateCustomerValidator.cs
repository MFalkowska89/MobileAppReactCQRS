using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Requests.Customers.Commands
{
    public class UpateCustomerValidator : AbstractValidator<UpdateCustomerCommand>
    {
        private readonly ApplicationDbContext _context;
        public UpateCustomerValidator(ApplicationDbContext context)
        {
            _context = context;

            RuleFor(c => c.CustomerId)
                .NotEmpty()
                .WithMessage("CustomerId is required.")
                .WithErrorCode("CustomerIdRequired")
                .MustAsync(CustomerIdExists)
                .WithMessage("CustomerId is not valid.") 
                .WithErrorCode("CustomerIdDoesntExist");
            RuleFor(c => c.EmailAddress)
                .NotEmpty()
                .WithMessage("EmailAddress is required.")
                .WithErrorCode("EmailAddressRequired")
                .EmailAddress()
                .WithMessage("EmailAddress must be a valid email format.")
                .WithErrorCode("EmailNotValid")
                .MaximumLength(250)
                .WithMessage("EmailAddress must not exceed 250 characters.") 
                .WithErrorCode("EmailAddressTooLong");
            RuleFor(c => c.PhoneNumber)
                .NotEmpty()
                .WithMessage("PhoneNumber is required.")
                .WithErrorCode("PhoneNumberRequired")
                .Must(s => s.All(char.IsDigit))
                .WithMessage("Phone number can only contain digits")
                .WithErrorCode("PhoneNumberMustOnlyContainDigits")
                .MaximumLength(30)
                .WithMessage("Phone Number must not exceed 30 characters.")
                .WithErrorCode("PhoneNumberTooLong");
            RuleFor(c => c.PhoneNumberExtra)
                .Must(s => s.All(char.IsDigit))
                .WithMessage("Phone number can only contain digits")
                .WithErrorCode("PhoneNumberMustOnlyContainDigits")
                .MaximumLength(30)
                .WithMessage("Phone Number must not exceed 30 characters.")
                .WithErrorCode("PhoneNumberTooLong");
            RuleFor(c => c.HomeAddress)
                .NotEmpty()
                .WithMessage("Home Address is required.")
                .WithErrorCode("AddressRequired")
                .MaximumLength(250)
                .WithMessage("Address cannot exceed 250 characters")
                .WithErrorCode("AddressTooLong");
            RuleFor(c => c.PostCode)
                .NotEmpty()
                .WithMessage("Post Code is required.")
                .WithErrorCode("PostCodeRequired")
                .MaximumLength(20)
                .WithMessage("Post Code cannot exceed 20 characters")
                .WithErrorCode("PostCodeTooLong");
            RuleFor(c => c.City)
                .NotEmpty()
                .WithMessage("City is required.")
                .WithErrorCode("CityRequired")
                .MaximumLength(100)
                .WithMessage("City cannot exceed 250 characters")
                .WithErrorCode("CityTooLong");
            RuleFor(c => c.Country)
                .NotEmpty()
                .WithMessage("Country is required.")
                .WithErrorCode("CountryRequired")
                .MaximumLength(50)
                .WithMessage("Country cannot exceed 50 characters")
                .WithErrorCode("CountryTooLong");
        }

        private async Task<bool> CustomerIdExists(int customerId, CancellationToken cancellationToken)
        {
            return await _context.Customers.AnyAsync(c => c.Id == customerId && c.IsActive, cancellationToken);
        }
    }
}
