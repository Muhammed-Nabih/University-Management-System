using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Department.Queries.Results;

namespace UniversityManagementSystem.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIDQuery : IRequest<Response<GetDepartmentByIDResponse>>
    {
        public int Id { get; set; }
        public int StudentPageNumber { get; set; }
        public int StudentPageSize { get; set; }
    }
}
