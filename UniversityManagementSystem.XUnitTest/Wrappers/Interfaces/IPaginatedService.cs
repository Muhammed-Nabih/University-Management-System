using UniversityManagementSystem.Core.Wrappers;

namespace UniversityManagementSystem.XUnitTest.Wrappers.Interfaces
{
    public interface IPaginatedService<T>
    {
        public Task<PaginatedResult<T>> ReturnPaginatedResult(IQueryable<T> source, int pageNumber, int pageSize);
    }
}
