using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Infrustructure.Abstracts;
using UniversityManagementSystem.Infrustructure.Data;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<Subjects>, ISubjectRepository
    {
        // Fields
        private DbSet<Subjects> subjects;
        /*******************************************************************************************/

        // Constructors
        public SubjectRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            subjects=dbContext.Set<Subjects>();
        }
        /*******************************************************************************************/

        // Handle Functions

        /*******************************************************************************************/
    }
}