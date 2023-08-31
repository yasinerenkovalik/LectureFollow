
using Application.Message;
using Application.Repository;
using Application.Services;
using Domain;


namespace Persistence.Service;

public class LectureService:ILectureService
{
    private readonly ILectureRepository _lectureRepository;

    public LectureService(ILectureRepository lectureRepository)
    {
        _lectureRepository = lectureRepository;
    }
    public bool Add(Lecture entity)
    {
        var result = _lectureRepository.Add(entity);
        if (result)
        {
            return true;
        }

        return false;
    }

    public List<Lecture> GetAll()
    {

        var result = _lectureRepository.GetAll();
        return result;
    }

    public Lecture GetById(int id)
    {
        var result = _lectureRepository.GetById(id);
        if (result == null)
        {
            throw new Exception(Messages.UserNotFoundMessage);
        }

        return result;
    }

    public bool Delete(int id)
    {
        var result = _lectureRepository.Delete(id);
        if (result == false)
        {
            throw new Exception(Messages.LectureNotFound);
        }

        return true;
    }

    public bool HardDelete(int id)
    {
        var result = _lectureRepository.HardDelete(id);
        if (result == false)
        {
            throw new Exception(Messages.LectureNotFound);
        }

        return true;
    }

    public bool Update(Lecture entity)
    {
        var result = _lectureRepository.Update(entity);
        if (result == null)
        {
            throw new Exception(Messages.LectureNotFound);
            
        }

        return true;
    }

    public Lecture Get()
    {
        var result = _lectureRepository.Get();
        return result;
    }
}