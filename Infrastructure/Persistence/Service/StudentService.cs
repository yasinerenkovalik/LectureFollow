using Application.Services;
using Domain;

namespace Persistence.Service;

public class StudentService:Services<StudentEntity>, IStudentService
{
    public StudentService(IGenericService<StudentEntity> genericService) : base(genericService)
    {
    }
}