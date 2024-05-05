using UniversityManagementSystem.Data.Entities.Identity;

namespace UniversityManagementSystem.Service.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string password);
    }
}
