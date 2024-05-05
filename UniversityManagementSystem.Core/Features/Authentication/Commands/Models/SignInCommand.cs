
using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.Results;

namespace UniversityManagementSystem.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
