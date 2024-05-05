using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Entities.Views;
using UniversityManagementSystem.Infrustructure.Abstracts.Views;
using UniversityManagementSystem.Infrustructure.Data;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Repositories.Views
{
    public class ViewDepartmentRepository : GenericRepositoryAsync<ViewDepartment>, IViewRepository<ViewDepartment>
    {
        // Fields
        private DbSet<ViewDepartment> viewDepartment;
        /*******************************************************************************************/

        // Constructors
        public ViewDepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            viewDepartment=dbContext.Set<ViewDepartment>();
        }
        /*******************************************************************************************/

        // Handle Functions

        /*******************************************************************************************/
    }
}
