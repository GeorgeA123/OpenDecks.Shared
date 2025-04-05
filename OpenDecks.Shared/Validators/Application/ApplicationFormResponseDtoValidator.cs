using FluentValidation;
using OpenDecks.Shared.DTOs.Requests;

namespace OpenDecks.Shared.Validators.Application
{
    public class ApplicationFieldResponseDtoValidator : AbstractValidator<ApplicationFieldResponseDto>
    {
        public ApplicationFieldResponseDtoValidator()
        {
            _ = RuleFor(r => r.FormFieldId)
                .NotEmpty().WithMessage("Form field ID is required");
        }
    }
}
