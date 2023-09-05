
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
        var result = _lectureRepository.Get(n => n.Name == entity.Name);
        if (result==null)
        {
            _lectureRepository.Add(entity);
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
      _lectureRepository.Delete(id);
    
        return true;
    }

    public bool HardDelete(int id)
    {
        _lectureRepository.HardDelete(id);
     

        return true;
    }

    public bool Update(Lecture entity)
    {
       _lectureRepository.Update(entity);
        
       
        return true;
    }

    public Lecture Get()
    {
        var result = _lectureRepository.Get();
        return result;
    }

    public IQueryable<dynamic> StudentSelectLecture(int id)
    {
        var result = _lectureRepository.StudentSelectLecture(id);
        return result;
    }
}