using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.DTOs;

namespace UniversityManagementSystem.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {
    }
}
