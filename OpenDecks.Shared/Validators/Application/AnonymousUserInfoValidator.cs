using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Application;
using System.Text.RegularExpressions;

namespace OpenDecks.Shared.Validators.Application
{
    public class AnonymousUserInfoValidator : AbstractValidator<AnonymousUserInfo>
    {
        public AnonymousUserInfoValidator()
        {
            _ = RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("A valid email address is required")
                .MaximumLength(256).WithMessage("Email cannot exceed 256 characters");

            _ = RuleFor(u => u.FirstName)
                .NotEmpty().WithMessage("First name is required")
                .MaximumLength(100).WithMessage("First name cannot exceed 100 characters");

            _ = RuleFor(u => u.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .MaximumLength(100).WithMessage("Last name cannot exceed 100 characters");

            _ = RuleFor(u => u.PhoneNumber)
                .Must(BeAValidPhoneNumber).When(u => !string.IsNullOrEmpty(u.PhoneNumber))
                .WithMessage("Phone number format is invalid");
        }

        private bool BeAValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return true;

            return Regex.IsMatch(phoneNumber, @"^\+?[0-9]{10,15}$");
        }
    }
}