using Application.Message;
using Application.Repository;
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Persistence.Service;

public class UserService:IUserService
{
    private readonly IUserRepository _userRepository;
   

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
     
    }
    public bool Add(User entity)
    {
        
        var result = _userRepository.Get(n => n.Email == entity.Email);
      
        if (result == null)
        {
            _userRepository.Add(entity);
            return true;
        }
        return false;
    }

    public List<User> GetAll()
    {
        var result = _userRepository.GetAll();
        return result;
    }

    public User GetById(int id)
    {
        var result = _userRepository.GetById(id);
        if (result == null)
        {
            throw new Exception(Messages.UserNotFoundMessage);
        }
        return result;
    }

    public bool Delete(int id)
    {
    _userRepository.Delete(id);
    return true;
    }

    public bool HardDelete(int id)
    {
       _userRepository.HardDelete(id);
       return true;
    }

    public bool Update(User entity)
    {
        _userRepository.Update(entity);
     

        return false;
    }

    public User Get()
    {
        var result = _userRepository.Get();
        return result;
    }

    public string? Login(string email, string password)
    {
        var result = _userRepository.Login(email, password);
        if (result == Messages.UserNotFoundMessage)
        {
            return null;
        }

        return result;
    }

    public string Jwt(string mail, string password)
    {
        throw new NotImplementedException();
    }
}