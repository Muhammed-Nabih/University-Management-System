using MediatR;
using UniversityManagementSystem.Core.Features.Students.Queries.Results;
using UniversityManagementSystem.Core.Wrappers;
using UniversityManagementSystem.Data.Enums;

namespace UniversityManagementSystem.Core.Features.Students.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public StudentOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
