using UniversityManagementSystem.Core.Features.ApplicationUser.Queries.Results;
using UniversityManagementSystem.Data.Entities.Identity;

namespace UniversityManagementSystem.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void GetUserByIdMapping()
        {
            CreateMap<User, GetUserByIdResponse>();
        }
    }
}
