using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Infrustructure.Abstracts;
using UniversityManagementSystem.Infrustructure.Data;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        // Fields
        private readonly DbSet<Student> _students;
        /*******************************************************************************************/

        // Constructors
        public StudentRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _students=dBContext.Set<Student>();
        }
        /*******************************************************************************************/

        // Handles Functions
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _students.Include(x => x.Department).ToListAsync();
        }
        /*******************************************************************************************/


    }
}
