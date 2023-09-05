using Domain;

namespace Application.Services;

public interface IUserService:IGenericService<User>
{
    string? Login(string email, string password);
    string Jwt(string mail, string password);

}