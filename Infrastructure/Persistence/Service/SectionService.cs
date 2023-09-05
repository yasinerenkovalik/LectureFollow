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
        var result = _sectionRepository.Get(n => n.Name == entity.Name);
        if (result != null)
        {
            _sectionRepository.Add(entity);
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
        _sectionRepository.Delete(id);
   
     

        return true;
    }

    public bool HardDelete(int id)
    {
       _sectionRepository.HardDelete(id);
     

        return true;
    }

    public bool Update(Section entity)
    {
         _sectionRepository.Update(entity);
         return true;

    }

    public Section Get()
    {
        var result = _sectionRepository.Get();
        return result;
    }
}