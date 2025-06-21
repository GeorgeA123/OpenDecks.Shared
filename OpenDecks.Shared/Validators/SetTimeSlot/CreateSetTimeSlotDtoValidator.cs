using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.SetTimeSlot;

namespace OpenDecks.Shared.Validators.SetTimeSlot
{
    public class CreateSetTimeSlotDtoValidator : AbstractValidator<CreateSetTimeSlotDto>
    {
        public CreateSetTimeSlotDtoValidator()
        {
            _ = RuleFor(s => s.EventId)
                .NotEmpty().WithMessage("Event ID is required");

            _ = RuleFor(s => s.StartTime)
                .NotEmpty().WithMessage("Start time is required")
                .GreaterThan(DateTime.UtcNow).WithMessage("Start time must be in the future");

            _ = RuleFor(s => s.EndTime)
                .NotEmpty().WithMessage("End time is required")
                .GreaterThan(s => s.StartTime).WithMessage("End time must be after start time");

            _ = RuleFor(s => s.SlotNotes)
                .MaximumLength(1000).WithMessage("Slot notes cannot exceed 1000 characters");

            // ApplicantId is optional (nullable), so only validate if provided
            _ = RuleFor(s => s.ApplicantId)
                .NotEmpty().WithMessage("Applicant ID must be a valid GUID")
                .When(s => s.ApplicantId.HasValue);
        }
    }
}