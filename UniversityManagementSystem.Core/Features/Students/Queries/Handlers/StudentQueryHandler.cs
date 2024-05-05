﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Students.Queries.Models;
using UniversityManagementSystem.Core.Features.Students.Queries.Results;
using UniversityManagementSystem.Core.Resources;
using UniversityManagementSystem.Core.Wrappers;
using UniversityManagementSystem.Service.Abstracts;

namespace UniversityManagementSystem.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
                                       IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
                                       IRequestHandler<GetStudentByIDQuery, Response<GetSingleStudentResponse>>,
                                       IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<GetStudentPaginatedListResponse>>
    {

        // Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        /*******************************************************************************************/
        // Constructors
        public StudentQueryHandler(IStudentService studentService,
                                   IMapper mapper,
                                   IStringLocalizer<SharedResources> stringLocalizer) : base(stringLocalizer)
        {
            _studentService=studentService;
            _mapper=mapper;
            _stringLocalizer=stringLocalizer;
        }
        /*******************************************************************************************/


        // Handle Functions

        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentService.GetStudentsListAsync();
            var studentListMapper = _mapper.Map<List<GetStudentListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta=new { Count = studentListMapper.Count() };
            return result;
        }

        public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIDWithIncludeAsync(request.Id);
            if (student==null) return NotFound<GetSingleStudentResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            var result = _mapper.Map<GetSingleStudentResponse>(student);
            return Success(result);
        }

        public async Task<PaginatedResult<GetStudentPaginatedListResponse>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
        {
            //Expression<Func<Student, GetStudentPaginatedListResponse>> expression = e => new GetStudentPaginatedListResponse(e.StudID, e.Localize(e.NameAr, e.NameEn), e.Address, e.Department.Localize(e.Department.DNameAr, e.Department.DNameEn));
            var FilterQuery = _studentService.FilterStudentPaginatedQuerable(request.OrderBy, request.Search);
            var PaginatedList = await _mapper.ProjectTo<GetStudentPaginatedListResponse>(FilterQuery).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            PaginatedList.Meta=new { Count = PaginatedList.Data.Count() };
            return PaginatedList;
        }

        /*******************************************************************************************/
    }
}
