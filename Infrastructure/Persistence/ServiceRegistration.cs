using System.Configuration;
using Application.Repository;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repository;
using Persistence.Service;

namespace Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<OracleContext>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IFacultyService, FacultyService>();
        services.AddScoped<IFacultyRepository, FacultyRepository>();
        services.AddScoped<ILectureService, LectureService>();
        services.AddScoped<ILectureRepository, LectureRepository>();
        services.AddScoped<ISectionService, SectionService>();
        services.AddScoped<ISectionRepository, SectionRepository>();
        services.AddScoped<IStudentLectureService, StudentLectureService>();
        services.AddScoped<IStudentLectureRepository, StudentLectureRepository>();
    }
}