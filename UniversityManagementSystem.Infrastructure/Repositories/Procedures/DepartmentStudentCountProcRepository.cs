using UniversityManagementSystem.Data.Entities.Procedures;
using UniversityManagementSystem.Infrustructure.Abstracts.Procedures;
using UniversityManagementSystem.Infrustructure.Data;
using StoredProcedureEFCore;

namespace UniversityManagementSystem.Infrustructure.Repositories.Procedures
{
    public class DepartmentStudentCountProcRepository : IDepartmentStudentCountProcRepository
    {
        // Fields
        private readonly ApplicationDBContext _context;
        /*******************************************************************************************/
        // Constructors
        public DepartmentStudentCountProcRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        /*******************************************************************************************/
        // Handle Functions
        public async Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters)
        {
            var rows = new List<DepartmentStudentCountProc>();
            await _context.LoadStoredProc(nameof(DepartmentStudentCountProc))
                   .AddParam(nameof(DepartmentStudentCountProcParameters.DID), parameters.DID)
                   .ExecAsync(async r => rows=await r.ToListAsync<DepartmentStudentCountProc>());
            return rows;
        }
        /*******************************************************************************************/

    }
}
