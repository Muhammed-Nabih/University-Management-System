﻿using FluentValidation;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Features.Students.Commands.Models;
using UniversityManagementSystem.Core.Resources;
using UniversityManagementSystem.Service.Abstracts;

namespace UniversityManagementSystem.Core.Features.Students.Commands.Validatiors
{
    public class AddStudentValidator : AbstractValidator<AddStudentCommand>
    {
        // Fields
        private readonly IStudentService _studentService;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IDepartmentService _departmentService;
        /*******************************************************************************************/

        // Constructors
        public AddStudentValidator(IStudentService studentService,
                                   IStringLocalizer<SharedResources> localizer,
                                   IDepartmentService departmentService)
        {
            _studentService = studentService;
            _localizer = localizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
            _departmentService=departmentService;
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

            RuleFor(x => x.DepartmementId)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        }

        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.NameAr)
                .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameArExist(Key))
                .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
            RuleFor(x => x.NameEn)
               .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameEnExist(Key))
               .WithMessage(_localizer[SharedResourcesKeys.IsExist]);



            RuleFor(x => x.DepartmementId)
           .MustAsync(async (Key, CancellationToken) => await _departmentService.IsDepartmentIdExist(Key))
           .WithMessage(_localizer[SharedResourcesKeys.IsNotExist]);




        }

        /*******************************************************************************************/

    }
}
