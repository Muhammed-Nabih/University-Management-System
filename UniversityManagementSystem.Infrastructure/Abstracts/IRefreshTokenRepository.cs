using UniversityManagementSystem.Data.Entities.Identity;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
