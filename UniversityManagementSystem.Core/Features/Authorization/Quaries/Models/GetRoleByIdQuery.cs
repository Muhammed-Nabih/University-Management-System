using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Authorization.Quaries.Results;

namespace UniversityManagementSystem.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResult>>
    {
        public int Id { get; set; }
    }
}
