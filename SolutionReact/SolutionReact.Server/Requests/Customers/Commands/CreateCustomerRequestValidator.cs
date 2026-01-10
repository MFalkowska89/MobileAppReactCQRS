using FluentValidation;
using SolutionReact.Server.Requests.Bookings.Commands;

namespace SolutionReact.Server.Requests.Customers.Commands
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .WithMessage("First name is required.")
                .WithErrorCode("FirstNameRequired")
                .MaximumLength(50)
                .WithMessage("First name cannot be longer than 50 characters")
                .WithErrorCode("FirstNameTooLong");

            RuleFor(c => c.LastName)
                .NotEmpty()
                .WithMessage("Last name is required.")
                .WithErrorCode("LastNameRequired")
                .MaximumLength(100)
                .WithMessage("Last name cannot be longer than 100 characters")
                .WithErrorCode("LastNameTooLong");

            RuleFor(c => c.DateOfBirth)
                .NotEmpty()
                .WithMessage("Date of birth is required.")
                .WithErrorCode("DateOfBirthRequired")
                .LessThan(DateTime.UtcNow)
                .WithMessage("Date of birth must be in the past.")
                .WithErrorCode("InvalidDateOfBirth");

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
    }
}