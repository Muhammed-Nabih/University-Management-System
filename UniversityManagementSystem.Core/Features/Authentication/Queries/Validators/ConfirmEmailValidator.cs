using FluentValidation;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Features.Authentication.Queries.Models;
using UniversityManagementSystem.Core.Resources;

namespace UniversityManagementSystem.Core.Features.Authentication.Queries.Validators
{
    public class ConfirmEmailValidator : AbstractValidator<ConfirmEmailQuery>
    {
        // Fields
        private readonly IStringLocalizer<SharedResources> _localizer;
        /*******************************************************************************************/

        // Constructors
        public ConfirmEmailValidator(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        /*******************************************************************************************/

        // Actions
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.UserId)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);

            RuleFor(x => x.Code)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        }

        public void ApplyCustomValidationsRules()
        {
        }

        /*******************************************************************************************/

    }
}