using UniversityManagementSystem.Core.Features.Department.Queries.Models;
using UniversityManagementSystem.Core.Features.Department.Queries.Results;
using UniversityManagementSystem.Data.Entities.Procedures;

namespace UniversityManagementSystem.Core.Mapping.Departments
{
    public partial class DepartmentProfile
    {
        public void GetDepartmentStudentCountByIdMapping()
        {
            CreateMap<GetDepartmentStudentCountByIDQuery, DepartmentStudentCountProcParameters>();

            CreateMap<DepartmentStudentCountProc, GetDepartmentStudentCountByIDResult>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Localize(src.DNameAr, src.DNameEn)))
                .ForMember(dest => dest.StudentCount, opt => opt.MapFrom(src => src.StudentCount));
        }
    }
}
