using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.Results;

namespace UniversityManagementSystem.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResult>>
    {
        public int UserId { get; set; }
    }
}
