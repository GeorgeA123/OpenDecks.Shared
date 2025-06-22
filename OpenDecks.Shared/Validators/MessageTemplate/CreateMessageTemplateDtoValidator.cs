using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.MessageTemplate;

namespace OpenDecks.Shared.Validators.MessageTemplate
{
    public class CreateMessageTemplateDtoValidator : AbstractValidator<CreateMessageTemplateDto>
    {
        public CreateMessageTemplateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Template name is required")
                .MaximumLength(200)
                .WithMessage("Template name cannot exceed 200 characters");

            RuleFor(x => x.Subject)
                .NotEmpty()
                .WithMessage("Subject is required")
                .MaximumLength(500)
                .WithMessage("Subject cannot exceed 500 characters");

            RuleFor(x => x.Body)
                .NotEmpty()
                .WithMessage("Message body is required")
                .MaximumLength(10000)
                .WithMessage("Message body cannot exceed 10,000 characters");

            RuleFor(x => x.MessageType)
                .NotEmpty()
                .WithMessage("Message type is required")
                .Must(x => x == "Success" || x == "Unsuccessful")
                .WithMessage("Message type must be either 'Success' or 'Unsuccessful'");
        }
    }
}