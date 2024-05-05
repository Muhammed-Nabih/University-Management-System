using MediatR;
using UniversityManagementSystem.Core.Bases;

namespace UniversityManagementSystem.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}
