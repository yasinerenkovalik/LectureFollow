using Application.Repository;
using Application.Services;
using Domain;

namespace Persistence.Service;

public class StudentService:IStudentService
{
    private IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public bool Add(Student entity)
    {
        _studentRepository.Add(entity);
        return true;
    }

    public List<Student> GetAll()
    {
       var result= _studentRepository.GetAll();
       return result;
    }

    public Student GetById(int id)
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

    public bool Update(Student entity)
    {
        throw new NotImplementedException();
    }
}