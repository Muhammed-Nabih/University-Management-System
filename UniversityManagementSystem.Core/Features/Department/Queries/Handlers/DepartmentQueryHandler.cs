﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Department.Queries.Models;
using UniversityManagementSystem.Core.Features.Department.Queries.Results;
using UniversityManagementSystem.Core.Resources;
using UniversityManagementSystem.Core.Wrappers;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Data.Entities.Procedures;
using UniversityManagementSystem.Service.Abstracts;
using System.Linq.Expressions;

namespace UniversityManagementSystem.Core.Features.Department.Queries.Handlers
{
    public class DepartmentQueryHandler : ResponseHandler,
         IRequestHandler<GetDepartmentByIDQuery, Response<GetDepartmentByIDResponse>>,
         IRequestHandler<GetDepartmentStudentListCountQuery, Response<List<GetDepartmentStudentListCountResults>>>,
         IRequestHandler<GetDepartmentStudentCountByIDQuery, Response<GetDepartmentStudentCountByIDResult>>
    {

        // Fields
        private readonly IDepartmentService _departmentService;
        private readonly IStudentService _studentService;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IMapper _mapper;
        /*******************************************************************************************/

        // Constructors
        public DepartmentQueryHandler(IStringLocalizer<SharedResources> stringLocalizer,
                                      IDepartmentService departmentService,
                                      IMapper mapper,
                                      IStudentService studentService) : base(stringLocalizer)
        {
            _stringLocalizer=stringLocalizer;
            _mapper=mapper;
            _studentService=studentService;
            _departmentService= departmentService;
        }

        /*******************************************************************************************/

        // Handle Functions
        public async Task<Response<GetDepartmentByIDResponse>> Handle(GetDepartmentByIDQuery request, CancellationToken cancellationToken)
        {
            //service Get By Id include St sub ins
            var response = await _departmentService.GetDepartmentById(request.Id);
            //check Is Not exist
            if (response == null) return NotFound<GetDepartmentByIDResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            //mapping 
            var mapper = _mapper.Map<GetDepartmentByIDResponse>(response);

            //pagination
            Expression<Func<Student, StudentResponse>> expression = e => new StudentResponse(e.StudID, e.Localize(e.NameAr, e.NameEn));
            var studentQuerable = _studentService.GetStudentsByDepartmentIDQuerable(request.Id);
            var PaginatedList = await studentQuerable.Select(expression).ToPaginatedListAsync(request.StudentPageNumber, request.StudentPageSize);
            mapper.StudentList = PaginatedList;

            // Log.Information($"Get Department By Id {request.Id}!");
            //return response
            return Success(mapper);
        }

        public async Task<Response<List<GetDepartmentStudentListCountResults>>> Handle(GetDepartmentStudentListCountQuery request, CancellationToken cancellationToken)
        {
            var viewDepartmentResult = await _departmentService.GetViewDepartmentDataAsync();
            var result = _mapper.Map<List<GetDepartmentStudentListCountResults>>(viewDepartmentResult);
            return Success(result);

        }

        public async Task<Response<GetDepartmentStudentCountByIDResult>> Handle(GetDepartmentStudentCountByIDQuery request, CancellationToken cancellationToken)
        {
            var parameters = _mapper.Map<DepartmentStudentCountProcParameters>(request);
            var procResult = await _departmentService.GetDepartmentStudentCountProcs(parameters);
            var result = _mapper.Map<GetDepartmentStudentCountByIDResult>(procResult.FirstOrDefault());
            return Success(result);

        }
        /*******************************************************************************************/
    }
}
