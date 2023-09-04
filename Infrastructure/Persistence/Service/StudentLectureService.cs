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
        var result = _studentLectureRepository.Add(entity);
        if (result)
        {
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
        var result = _studentLectureRepository.Delete(id);
        if (result == false)
        {
            throw new Exception(Messages.LectureNotFound);
        }

        return true;
    }

    public bool HardDelete(int id)
    {
        var result = _studentLectureRepository.HardDelete(id);
        if (result == false)
        {
            throw new Exception(Messages.LectureNotFound);
        }

        return true;
    }

    public bool Update(StudentLecture entity)
    {
        var result = _studentLectureRepository.Update(entity);
        if (result == null)
        {
            throw new Exception(Messages.LectureNotFound);
            
        }

        return true;
    }

    public StudentLecture Get()
    {
        var result = _studentLectureRepository.Get();
        return result;
    }
}