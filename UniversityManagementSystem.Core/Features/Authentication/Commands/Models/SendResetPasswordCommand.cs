using MediatR;
using UniversityManagementSystem.Core.Bases;

namespace UniversityManagementSystem.Core.Features.Authentication.Commands.Models
{
    public class SendResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}
