using Domain;

namespace Application.Services;

public interface IStudentLectureService:IGenericService<StudentLecture>
{
    IQueryable<dynamic> StudenLecture(int id);
}