using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Application;
using OpenDecks.Shared.Enums;

namespace OpenDecks.Shared.Validators.Application
{
    public class PatchApplicationDtoValidator : AbstractValidator<PatchApplicationDto>
    {
        public PatchApplicationDtoValidator()
        {
            RuleFor(a => a.Status)
                .Must(BeValidApplicationStatus)
                .When(a => !string.IsNullOrEmpty(a.Status))
                .WithMessage("Invalid application status");

        }

        private bool BeValidApplicationStatus(string status)
        {
            return Enum.TryParse<ApplicationStatus>(status, true, out _);
        }
    }
}