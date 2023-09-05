using Application.Repository;
using Application.Services;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class LectureRepository:Repository<Lecture>,ILectureRepository
{
    private readonly OracleContext _context;
    public LectureRepository(OracleContext context) : base(context)
    {
        _context = context;
    }

    public IQueryable<dynamic> StudentSelectLecture(int id)
    {
        var lecture = _context.Set<Lecture>().Where(n => n.FacultyId == id);
        return lecture;
    }
}