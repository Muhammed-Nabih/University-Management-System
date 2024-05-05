using Microsoft.Extensions.DependencyInjection;
using UniversityManagementSystem.Data.Entities.Views;
using UniversityManagementSystem.Infrustructure.Abstracts;
using UniversityManagementSystem.Infrustructure.Abstracts.Functions;
using UniversityManagementSystem.Infrustructure.Abstracts.Procedures;
using UniversityManagementSystem.Infrustructure.Abstracts.Views;
using UniversityManagementSystem.Infrustructure.InfrastructureBases;
using UniversityManagementSystem.Infrustructure.Repositories;
using UniversityManagementSystem.Infrustructure.Repositories.Functions;
using UniversityManagementSystem.Infrustructure.Repositories.Procedures;
using UniversityManagementSystem.Infrustructure.Repositories.Views;

namespace UniversityManagementSystem.Infrustructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IInstructorsRepository, InstructorsRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            //views
            services.AddTransient<IViewRepository<ViewDepartment>, ViewDepartmentRepository>();

            //Procedure
            services.AddTransient<IDepartmentStudentCountProcRepository, DepartmentStudentCountProcRepository>();

            //functions
            services.AddTransient<IInstructorFunctionsRepository, InstructorFunctionsRepository>();

            return services;
        }
    }
}