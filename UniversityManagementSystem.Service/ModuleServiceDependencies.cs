using Microsoft.Extensions.DependencyInjection;
using UniversityManagementSystem.Service.Abstracts;
using UniversityManagementSystem.Service.AuthServices.Implementations;
using UniversityManagementSystem.Service.AuthServices.Interfaces;
using UniversityManagementSystem.Service.Implementations;
namespace UniversityManagementSystem.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailsService, EmailsService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IInstructorService, InstructorService>();
            services.AddTransient<IFileService, FileService>();
            return services;
        }
    }
}