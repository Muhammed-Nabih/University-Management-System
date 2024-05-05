using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Entities.Identity;
using UniversityManagementSystem.Infrustructure.Abstracts;
using UniversityManagementSystem.Infrustructure.Data;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        // Fields
        private DbSet<UserRefreshToken> userRefreshToken;
        /*******************************************************************************************/

        // Constructors
        public RefreshTokenRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            userRefreshToken=dbContext.Set<UserRefreshToken>();
        }
        /*******************************************************************************************/

        // Handle Functions

        /*******************************************************************************************/
    }
}
