using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Students.Queries.Results;

namespace UniversityManagementSystem.Core.Features.Students.Queries.Models
{
    public class GetStudentByIDQuery : IRequest<Response<GetSingleStudentResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIDQuery(int id)
        {
            Id=id;
        }
    }
}
