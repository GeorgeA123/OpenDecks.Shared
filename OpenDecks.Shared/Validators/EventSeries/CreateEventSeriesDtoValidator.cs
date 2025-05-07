using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.EventSeries;

namespace OpenDecks.Shared.Validators.EventSeries
{
    public class CreateEventSeriesDtoValidator : AbstractValidator<CreateEventSeriesDto>
    {
        public CreateEventSeriesDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Series name is required")
                .MaximumLength(200).WithMessage("Series name cannot exceed 200 characters");

            RuleFor(x => x.Description)
                .MaximumLength(2000).WithMessage("Series description cannot exceed 2000 characters");

            RuleFor(x => x.InitialEventId)
                .NotEmpty().WithMessage("An initial event is required to create a series");
        }
    }
}