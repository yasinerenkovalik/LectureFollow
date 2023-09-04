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
        var result = _facultyRepository.Add(entity);
        if (result == null)
        {
            return false;
        }

        return true;
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
        var result = _facultyRepository.Delete(id);
        if (result == false)
        {
            return false;
        }

        return true;
    }

    public bool HardDelete(int id)
    {
        var result = _facultyRepository.HardDelete(id);
        if (result == false)
        {
            return false;
        }

        return true;
    }

    public bool Update(Faculty entity)
    {
        var result = _facultyRepository.Update(entity);
        if (result == true)
        {
            return true;
        }

        return false;
    }

    public Faculty Get()
    {
        throw new NotImplementedException();
    }
}