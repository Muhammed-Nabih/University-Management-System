using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using UniversityManagementSystem.Data.Entities.Identity;
using UniversityManagementSystem.Data.Helpers;
using UniversityManagementSystem.Service.AuthServices.Interfaces;

namespace UniversityManagementSystem.Service.AuthServices.Implementations
{
    public class CurrentUserService : ICurrentUserService
    {

        // Fields
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        /*******************************************************************************************/
        // Constructors
        public CurrentUserService(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        /*******************************************************************************************/
        // Functions
        public int GetUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.Claims.SingleOrDefault(claim => claim.Type==nameof(UserClaimModel.Id)).Value;
            if (userId == null)
            {
                throw new UnauthorizedAccessException();
            }
            return int.Parse(userId);
        }

        public async Task<User> GetUserAsync()
        {
            var userId = GetUserId();
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            { throw new UnauthorizedAccessException(); }
            return user;
        }

        public async Task<List<string>> GetCurrentUserRolesAsync()
        {
            var user = await GetUserAsync();
            var roles = await _userManager.GetRolesAsync(user);
            return roles.ToList();
        }
        /*******************************************************************************************/
    }
}
