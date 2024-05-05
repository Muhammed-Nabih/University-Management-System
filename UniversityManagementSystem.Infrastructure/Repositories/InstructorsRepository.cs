using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Infrustructure.Abstracts;
using UniversityManagementSystem.Infrustructure.Data;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Repositories
{
    public class InstructorsRepository : GenericRepositoryAsync<Instructor>, IInstructorsRepository
    {
        // Fields
        private DbSet<Instructor> instructors;
        /*******************************************************************************************/

        // Constructors
        public InstructorsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            instructors=dbContext.Set<Instructor>();
        }
        /*******************************************************************************************/

        // Handle Functions

        /*******************************************************************************************/
    }
}
