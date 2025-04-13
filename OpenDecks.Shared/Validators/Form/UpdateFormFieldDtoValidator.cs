using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Form;
using OpenDecks.Shared.Enums;
using System.Text.Json;

namespace OpenDecks.Shared.Validators.Form
{
    public class UpdateFormFieldDtoValidator : AbstractValidator<UpdateFormFieldDto>
    {
        public UpdateFormFieldDtoValidator()
        {
            RuleFor(f => f.Label)
                .NotEmpty().WithMessage("Field label is required")
                .MaximumLength(200).WithMessage("Field label cannot exceed 200 characters");

            RuleFor(f => f.Description)
                .MaximumLength(1000).WithMessage("Field description cannot exceed 1000 characters");

            RuleFor(f => f.FieldType)
                .NotEmpty().WithMessage("Field type is required")
                .Must(BeValidFieldType).WithMessage("Field type must be a valid field type");

            RuleFor(f => f.DisplayOrder)
                .GreaterThanOrEqualTo(0).WithMessage("Display order must be a non-negative number");

            RuleFor(f => f.Options)
                .Must(BeValidJsonWhenSpecified)
                .When(f => !string.IsNullOrEmpty(f.Options))
                .WithMessage("Options must be a valid JSON string");

            RuleFor(f => f.ValidationRules)
                .Must(BeValidJsonWhenSpecified)
                .When(f => !string.IsNullOrEmpty(f.ValidationRules))
                .WithMessage("Validation rules must be a valid JSON string");
        }

        private bool BeValidFieldType(string fieldType)
        {
            return Enum.TryParse(typeof(FieldType), fieldType, true, out _);
        }

        private bool BeValidJsonWhenSpecified(string json)
        {
            if (string.IsNullOrEmpty(json))
                return true;

            try
            {
                JsonDocument.Parse(json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
