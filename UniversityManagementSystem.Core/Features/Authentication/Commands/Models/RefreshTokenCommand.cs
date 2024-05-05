using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Data.Results;

namespace UniversityManagementSystem.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
