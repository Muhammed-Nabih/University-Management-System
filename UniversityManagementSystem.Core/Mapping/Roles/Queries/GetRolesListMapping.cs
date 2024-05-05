using UniversityManagementSystem.Core.Features.Authorization.Quaries.Results;
using UniversityManagementSystem.Data.Entities.Identity;

namespace UniversityManagementSystem.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRolesListMapping()
        {
            CreateMap<Role, GetRolesListResult>();
        }
    }
}
