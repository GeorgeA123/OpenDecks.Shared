using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.SetTimeSlot;

namespace OpenDecks.Shared.Validators.SetTimeSlot
{
    public class UpdateSetTimeSlotDtoValidator : AbstractValidator<UpdateSetTimeSlotDto>
    {
        public UpdateSetTimeSlotDtoValidator()
        {
            _ = RuleFor(s => s.Id)
                .NotEmpty().WithMessage("Set time slot ID is required");

            _ = RuleFor(s => s.SlotNotes)
                .MaximumLength(1000).WithMessage("Slot notes cannot exceed 1000 characters");

            // ApplicantId is optional (nullable), so only validate if provided
            _ = RuleFor(s => s.ApplicantId)
                .NotEmpty().WithMessage("Applicant ID must be a valid GUID")
                .When(s => s.ApplicantId.HasValue);

            // If both start and end times are provided, validate they make sense
            _ = RuleFor(s => s.EndTime)
                .GreaterThan(s => s.StartTime).WithMessage("End time must be after start time")
                .When(s => s.StartTime.HasValue && s.EndTime.HasValue);

            // If start time is provided, it should be in the future
            _ = RuleFor(s => s.StartTime)
                .GreaterThan(DateTime.UtcNow).WithMessage("Start time must be in the future")
                .When(s => s.StartTime.HasValue);

            // If end time is provided, it should be in the future
            _ = RuleFor(s => s.EndTime)
                .GreaterThan(DateTime.UtcNow).WithMessage("End time must be in the future")
                .When(s => s.EndTime.HasValue);
        }
    }
}