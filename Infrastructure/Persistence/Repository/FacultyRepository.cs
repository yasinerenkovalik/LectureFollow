using Application.Repository;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class FacultyRepository:Repository<Faculty>, IFacultyRepository
{
    public FacultyRepository(OracleContext context) : base(context)
    {
    }
}