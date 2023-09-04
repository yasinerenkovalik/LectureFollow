using Application.Repository;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class SectionRepository:Repository<Section>, ISectionRepository
{
    public SectionRepository(OracleContext context) : base(context)
    {
    }
}