using FluentValidation;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Features.Emails.Commands.Models;
using UniversityManagementSystem.Core.Resources;

namespace UniversityManagementSystem.Core.Features.Emails.Commands.Validators
{
    public class SendEmailValidator : AbstractValidator<SendEmailCommand>
    {
        // Fields
        private readonly IStringLocalizer<SharedResources> _localizer;
        /*******************************************************************************************/
        // Constructors
        public SendEmailValidator(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            ApplyValidationsRules();
        }
        /*******************************************************************************************/
        // Actions
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Email)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);

            RuleFor(x => x.Message)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        }
        /*******************************************************************************************/
    }
}
