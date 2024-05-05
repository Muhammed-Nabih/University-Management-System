using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.Requests;

namespace UniversityManagementSystem.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserClaimsCommand : UpdateUserClaimsRequest, IRequest<Response<string>>
    {
    }
}
