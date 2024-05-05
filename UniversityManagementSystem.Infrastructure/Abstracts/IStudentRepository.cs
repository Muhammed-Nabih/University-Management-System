using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;

namespace UniversityManagementSystem.Infrustructure.Abstracts
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
