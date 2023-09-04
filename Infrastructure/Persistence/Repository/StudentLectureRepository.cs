using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class StudentLectureRepository:Repository<StudentLecture>
{
    public StudentLectureRepository(OracleContext context) : base(context)
    {
    }
}