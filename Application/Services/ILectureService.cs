using Domain;

namespace Application.Services;

public interface ILectureService:IGenericService<Lecture>
{
    IQueryable<dynamic> StudentSelectLecture(int id);
}