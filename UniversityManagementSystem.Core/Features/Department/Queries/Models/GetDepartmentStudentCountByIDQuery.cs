using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Department.Queries.Results;

namespace UniversityManagementSystem.Core.Features.Department.Queries.Models
{
    public class GetDepartmentStudentCountByIDQuery : IRequest<Response<GetDepartmentStudentCountByIDResult>>
    {
        public int DID { get; set; }
    }
}
