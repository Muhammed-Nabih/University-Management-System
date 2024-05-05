using MediatR;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.ApplicationUser.Queries.Results;

namespace UniversityManagementSystem.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
