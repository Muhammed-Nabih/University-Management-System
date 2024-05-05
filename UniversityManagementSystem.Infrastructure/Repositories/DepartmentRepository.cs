using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Infrustructure.Abstracts;
using UniversityManagementSystem.Infrustructure.Data;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
    {
        // Fields
        private DbSet<Department> departments;
        /*******************************************************************************************/

        // Constructors
        public DepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            departments=dbContext.Set<Department>();
        }
        /*******************************************************************************************/

        // Handle Functions

        /*******************************************************************************************/
    }
}
