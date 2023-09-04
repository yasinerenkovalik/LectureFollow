using Application.Message;
using Application.Repository;
using Application.Services;
using Domain;

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
        var result = _userRepository.Add(entity);
        if (result==false)
        {
            throw new Exception(Messages.UserAvailable);
        }

        return true;
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
        var result = _userRepository.Delete(id);
        return result;
    }

    public bool HardDelete(int id)
    {
        var result = _userRepository.HardDelete(id);
        return result;
    }

    public bool Update(User entity)
    {
        var result = _userRepository.Update(entity);
        if (result)
        {
            return result;
        }

        return false;
    }

    public User Get()
    {
        var result = _userRepository.Get();
        return result;
    }

    public string Login(string email, string password)
    {
        var result = _userRepository.Login(email, password);
        if (result == "böyle bir kullanıcı bulunamadı")
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