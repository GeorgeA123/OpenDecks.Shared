using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Form;

namespace OpenDecks.Shared.Validators.Form
{
    public class CreateFormDtoValidator : AbstractValidator<CreateFormDto>
    {
        public CreateFormDtoValidator()
        {
            _ = RuleFor(f => f.Title)
                .NotEmpty().WithMessage("Form title is required")
                .MaximumLength(200).WithMessage("Form title cannot exceed 200 characters");

            _ = RuleFor(f => f.Description)
                .MaximumLength(2000).WithMessage("Form description cannot exceed 2000 characters");
        }
    }
}