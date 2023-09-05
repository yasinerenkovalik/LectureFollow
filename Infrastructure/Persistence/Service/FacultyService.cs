using Application.Message;
using Application.Repository;
using Application.Services;
using Domain;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Persistence.Service;

public class FacultyService:IFacultyService
{
    private readonly IFacultyRepository _facultyRepository;

    public FacultyService(IFacultyRepository facultyRepository)
    {
        _facultyRepository = facultyRepository;
    }
    public bool Add(Faculty entity)
    {
        var result = _facultyRepository.Get(n => n.Name == entity.Name);
        if (result == null)
        {
            _facultyRepository.Add(entity);
            return true;
        }
        
        return false;

    }

    public List<Faculty> GetAll()
    {
        var result = _facultyRepository.GetAll();
        if (result == null)
        {
            throw new Exception(Messages.UserNotFoundMessage);
        }

        return result;
    }

    public Faculty GetById(int id)
    {
        var result = _facultyRepository.GetById(id);
        if (result == null)
        {
             throw new Exception(Messages.UserNotFoundMessage);
        }

        return result;
    }

    public bool Delete(int id)
    {
       _facultyRepository.Delete(id);
       return true;
       
    }

    public bool HardDelete(int id)
    {
      _facultyRepository.HardDelete(id);
      return true;
      
    }

    public bool Update(Faculty entity)
    {
         _facultyRepository.Update(entity);
         return true;

    }

    public Faculty Get()
    {
        throw new NotImplementedException();
    }
}