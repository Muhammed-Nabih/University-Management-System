using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.DTOs;

namespace UniversityManagementSystem.Core.Features.Authorization.Commands.Models
{
    public class EditRoleCommand : EditRoleRequest, IRequest<Response<string>>
    {

    }
}
