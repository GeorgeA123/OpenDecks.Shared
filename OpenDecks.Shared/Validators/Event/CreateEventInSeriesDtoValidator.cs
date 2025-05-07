using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Event;

namespace OpenDecks.Shared.Validators.Event
{
    public class CreateEventInSeriesDtoValidator : AbstractValidator<CreateEventInSeriesDto>
    {
        public CreateEventInSeriesDtoValidator()
        {
            RuleFor(e => e.EventDate)
                .NotEmpty().WithMessage("Event date is required")
                .GreaterThan(DateTime.UtcNow).WithMessage("Event date must be in the future");

            RuleFor(e => e.ApplicationDeadline)
                .NotEmpty().WithMessage("Application deadline is required")
                .LessThan(e => e.EventDate).WithMessage("Application deadline must be before the event date")
                .GreaterThan(DateTime.UtcNow).WithMessage("Application deadline must be in the future");

            // Optional fields - only validate if provided
            When(e => !string.IsNullOrEmpty(e.Name), () => {
                RuleFor(e => e.Name)
                    .MaximumLength(200).WithMessage("Event name cannot exceed 200 characters");
            });

            When(e => !string.IsNullOrEmpty(e.Location), () => {
                RuleFor(e => e.Location)
                    .MaximumLength(500).WithMessage("Location cannot exceed 500 characters");
            });

            When(e => e.MaxApplicants.HasValue, () => {
                RuleFor(e => e.MaxApplicants.Value)
                    .GreaterThan(0).WithMessage("Maximum applicants must be greater than 0");
            });
        }
    }
}