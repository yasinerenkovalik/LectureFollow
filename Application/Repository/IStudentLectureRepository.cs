using Domain;

namespace Application.Repository;

public interface IStudentLectureRepository:IGenericRepository<StudentLecture>
{
    IQueryable<dynamic> StudenLecture(int id);
}