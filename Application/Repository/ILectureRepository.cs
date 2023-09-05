using Domain;

namespace Application.Repository;

public interface ILectureRepository:IGenericRepository<Lecture>
{
    IQueryable<dynamic> StudentSelectLecture(int id);
}