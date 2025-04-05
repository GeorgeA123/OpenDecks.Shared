using FluentValidation;
using OpenDecks.Shared.DTOs.Requests;

namespace OpenDecks.Shared.Validators.Application
{
    public class SubmitApplicationDtoValidator : AbstractValidator<SubmitApplicationDto>
    {
        public SubmitApplicationDtoValidator()
        {
            _ = RuleFor(a => a.EventId)
                .NotEmpty().WithMessage("Event ID is required");

            _ = RuleFor(a => a.FormId)
                .NotEmpty().WithMessage("Form ID is required");

            _ = RuleFor(a => a.Responses)
                .NotEmpty().WithMessage("At least one response is required");

            _ = RuleForEach(a => a.Responses)
                .SetValidator(new ApplicationFieldResponseDtoValidator());

            _ = RuleFor(a => a.AnonymousUser)
                .SetValidator(new AnonymousUserInfoValidator())
                .When(a => a.AnonymousUser != null);
        }
    }
}