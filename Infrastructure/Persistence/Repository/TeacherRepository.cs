using Application.Repository;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class TeacherRepository:Repository<Teacher>,ITeacherRepository
{
    public TeacherRepository(OracleContext context) : base(context)
    {
        
    }
}