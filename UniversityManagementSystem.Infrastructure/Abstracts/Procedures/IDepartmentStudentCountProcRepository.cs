using UniversityManagementSystem.Data.Entities.Procedures;

namespace UniversityManagementSystem.Infrustructure.Abstracts.Procedures
{
    public interface IDepartmentStudentCountProcRepository
    {
        public Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters);
    }
}
