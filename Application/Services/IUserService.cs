using Domain;

namespace Application.Services;

public interface IUserService:IGenericService<User>
{
    string Login(string email, string password);

}