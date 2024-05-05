using MediatR;
using UniversityManagementSystem.Core.Features.ApplicationUser.Queries.Results;
using UniversityManagementSystem.Core.Wrappers;

namespace UniversityManagementSystem.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
