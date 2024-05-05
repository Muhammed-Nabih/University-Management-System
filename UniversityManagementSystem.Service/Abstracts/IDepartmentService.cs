using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Data.Entities.Procedures;
using UniversityManagementSystem.Data.Entities.Views;

namespace UniversityManagementSystem.Service.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int id);
        public Task<bool> IsDepartmentIdExist(int departmentId);
        public Task<List<ViewDepartment>> GetViewDepartmentDataAsync();
        public Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters);
    }
}
