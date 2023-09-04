using Application.Message;
using Application.Repository;
using Application.Services;
using Domain;

namespace Persistence.Service;

public class SectionService:ISectionService
{
    private readonly ISectionRepository _sectionRepository;

    public SectionService(ISectionRepository sectionRepository)
    {
        _sectionRepository = sectionRepository;
    }
    public bool Add(Section entity)
    {
        var result = _sectionRepository.Add(entity);
        if (result)
        {
            return true;
        }

        return false;
    }

    public List<Section> GetAll()
    {

        var result = _sectionRepository.GetAll();
        return result;
    }

    public Section GetById(int id)
    {
        var result = _sectionRepository.GetById(id);
        if (result == null)
        {
            throw new Exception(Messages.UserNotFoundMessage);
        }

        return result;
    }

    public bool Delete(int id)
    {
        var result = _sectionRepository.Delete(id);
        if (result == false)
        {
            throw new Exception(Messages.LectureNotFound);
        }

        return true;
    }

    public bool HardDelete(int id)
    {
        var result = _sectionRepository.HardDelete(id);
        if (result == false)
        {
            throw new Exception(Messages.LectureNotFound);
        }

        return true;
    }

    public bool Update(Section entity)
    {
        var result = _sectionRepository.Update(entity);
        if (result == null)
        {
            throw new Exception(Messages.LectureNotFound);
            
        }

        return true;
    }

    public Section Get()
    {
        var result = _sectionRepository.Get();
        return result;
    }
}