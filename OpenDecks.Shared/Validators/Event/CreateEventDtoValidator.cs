using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Event;

namespace OpenDecks.Shared.Validators.Event
{
    public class CreateEventDtoValidator : AbstractValidator<CreateEventDto>
    {
        public CreateEventDtoValidator()
        {
            _ = RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Event name is required")
                .MaximumLength(200).WithMessage("Event name cannot exceed 200 characters");

            _ = RuleFor(e => e.Description)
                .MaximumLength(2000).WithMessage("Description cannot exceed 2000 characters");

            _ = RuleFor(e => e.EventDate)
                .NotEmpty().WithMessage("Event date is required")
                .GreaterThan(DateTime.UtcNow).WithMessage("Event date must be in the future");

            _ = RuleFor(e => e.ApplicationDeadline)
                .NotEmpty().WithMessage("Application deadline is required")
                .LessThan(e => e.EventDate).WithMessage("Application deadline must be before the event date")
                .GreaterThan(DateTime.UtcNow).WithMessage("Application deadline must be in the future");

            _ = RuleFor(e => e.Location)
                .NotEmpty().WithMessage("Event location is required")
                .MaximumLength(500).WithMessage("Location cannot exceed 500 characters");

            _ = RuleFor(e => e.MaxApplicants)
                .GreaterThan(0).WithMessage("Maximum applicants must be greater than 0");
        }
    }
}
