using Application.Repository;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class StudentRepository:Repository<Student>, IStudentRepository
{
    public StudentRepository(OracleContext context) : base(context)
    {
        
    }
}