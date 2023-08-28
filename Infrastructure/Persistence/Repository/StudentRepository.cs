using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class StudentRepository:Repository<StudentEntity>
{
    public StudentRepository(OracleContext context) : base(context)
    {
        
    }
}