using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Form;

namespace OpenDecks.Shared.Validators.Form
{
    public class UpdateFormDtoValidator : AbstractValidator<UpdateFormDto>
    {
        public UpdateFormDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(200).WithMessage("Title cannot exceed 200 characters");

            RuleFor(x => x.Description)
                .MaximumLength(1000).WithMessage("Description cannot exceed 1000 characters");
        }
    }
}
