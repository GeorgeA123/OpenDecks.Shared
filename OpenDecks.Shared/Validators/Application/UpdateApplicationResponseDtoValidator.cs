using FluentValidation;
using OpenDecks.Shared.DTOs.Requests.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.Validators.Application
{
    public class UpdateApplicationResponseDtoValidator : AbstractValidator<UpdateApplicationResponseDto>
    {
        public UpdateApplicationResponseDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Response ID is required");
        }
    }
}
