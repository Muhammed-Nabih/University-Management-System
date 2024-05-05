using UniversityManagementSystem.Core.Features.ApplicationUser.Commands.Models;
using UniversityManagementSystem.Data.Entities.Identity;

namespace UniversityManagementSystem.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void UpdateUserMapping()
        {
            CreateMap<EditUserCommand, User>();
        }
    }
}
