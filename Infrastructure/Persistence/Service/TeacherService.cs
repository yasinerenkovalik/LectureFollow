using Application.Repository;
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Service;

public class TeacherService:ITeacherService
{
    
    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }
    public bool Add(Teacher entity)
    {
        var result = _teacherRepository.Add(entity);
       
            return true;
     
    }

    public List<Teacher> GetAll()
    {
        throw new NotImplementedException();
    }

    public Teacher GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public bool HardDelete(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Teacher entity)
    {
        throw new NotImplementedException();
    }
}