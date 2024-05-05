﻿using FluentValidation;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Features.Students.Commands.Models;
using UniversityManagementSystem.Core.Resources;
using UniversityManagementSystem.Service.Abstracts;

namespace UniversityManagementSystem.Core.Features.Students.Commands.Validatiors
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        // Fields
        private readonly IStudentService _studentService;
        private readonly IStringLocalizer<SharedResources> _localizer;
        /*******************************************************************************************/

        // Constructors
        public EditStudentValidator(IStudentService studentService,
                                    IStringLocalizer<SharedResources> localizer)
        {
            _studentService = studentService;
            _localizer=localizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        /*******************************************************************************************/

        // Actions
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.NameAr)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                 .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);
        }

        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.NameAr)
                .MustAsync(async (model, Key, CancellationToken) => !await _studentService.IsNameArExistExcludeSelf(Key, model.Id))
                .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
            RuleFor(x => x.NameEn)
                .MustAsync(async (model, Key, CancellationToken) => !await _studentService.IsNameEnExistExcludeSelf(Key, model.Id))
                .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
        }

        /*******************************************************************************************/
    }
}
