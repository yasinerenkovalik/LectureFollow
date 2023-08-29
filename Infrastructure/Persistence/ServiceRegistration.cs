using Application.Repository;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repository;
using Persistence.Service;

namespace Application;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<OracleContext>();
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ITeacherService, TeacherService>(); 
        services.AddScoped<ITeacherRepository, TeacherRepository>();
      
    }
}