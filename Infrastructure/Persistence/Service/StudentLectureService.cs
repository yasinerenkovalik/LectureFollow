using Application.Message;
using Application.Repository;
using Application.Services;
using Domain;

namespace Persistence.Service;

public class StudentLectureService:IStudentLectureService
{
    private readonly IStudentLectureRepository _studentLectureRepository;
    public StudentLectureService(IStudentLectureRepository studentLectureRepository)
    {
        _studentLectureRepository = studentLectureRepository;
    }
    public bool Add(StudentLecture entity)
    {
        var result = _studentLectureRepository.Get(n => n.LectureId==entity.LectureId );
        if (result == null)
        {
            _studentLectureRepository.Add(entity);
            return true;
        }

        return false;
         
         

        
    }


    public List<StudentLecture> GetAll()
    {

        var result = _studentLectureRepository.GetAll();
        return result;
    }

    public StudentLecture GetById(int id)
    {
        var result = _studentLectureRepository.GetById(id);
        if (result == null)
        {
            throw new Exception(Messages.UserNotFoundMessage);
        }

        return result;
    }

    public bool Delete(int id)
    {
        _studentLectureRepository.Delete(id);
     

        return true;
    }

    public bool HardDelete(int id)
    {
     _studentLectureRepository.HardDelete(id);
     

        return true;
    }

    public bool Update(StudentLecture entity)
    {
        _studentLectureRepository.Update(entity);
      

        return true;
    }

    public StudentLecture Get()
    {
        var result = _studentLectureRepository.Get();
        return result;
    }

    public IQueryable<dynamic> StudenLecture(int id)
    {
        var result = _studentLectureRepository.StudenLecture(id);
        return result;
    }
}