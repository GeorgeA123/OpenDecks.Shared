using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Application;
using OpenDecks.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.Validators.Application
{
    public class UpdateApplicationDtoValidator : AbstractValidator<UpdateApplicationDto>
    {
        public UpdateApplicationDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Application ID is required");

            RuleFor(x => x.Status)
                .Must(BeValidStatus).When(x => !string.IsNullOrEmpty(x.Status))
                .WithMessage("Invalid application status");

            RuleForEach(x => x.Responses)
                .SetValidator(new UpdateApplicationResponseDtoValidator());
        }

        private bool BeValidStatus(string status)
        {
            return Enum.TryParse<ApplicationStatus>(status, true, out _);
        }
    }

}
