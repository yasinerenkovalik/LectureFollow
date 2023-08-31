using Application.Repository;
using Application.Services;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class LectureRepository:Repository<Lecture>,ILectureRepository
{
    public LectureRepository(OracleContext context) : base(context)
    {
    }
}