using UniversityManagementSystem.Core.Wrappers;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.XUnitTest.Wrappers.Interfaces;

namespace UniversityManagementSystem.XUnitTest.Wrappers.Implementations
{
    public class PaginatedService : IPaginatedService<Student>
    {
        public async Task<PaginatedResult<Student>> ReturnPaginatedResult(IQueryable<Student> source, int pageNumber, int pageSize)
        {
            return await source.ToPaginatedListAsync(pageNumber, pageSize);
        }
    }
}
