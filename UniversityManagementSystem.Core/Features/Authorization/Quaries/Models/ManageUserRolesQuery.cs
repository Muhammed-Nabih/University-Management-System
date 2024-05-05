using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.Results;

namespace UniversityManagementSystem.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
