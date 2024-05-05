using MediatR;
using UniversityManagementSystem.Core.Bases;

namespace UniversityManagementSystem.Core.Features.Students.Commands.Models
{
    public class DeleteStudentCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteStudentCommand(int id)
        {
            Id=id;
        }
    }
}
