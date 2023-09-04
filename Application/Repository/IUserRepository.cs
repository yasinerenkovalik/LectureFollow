using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Domain;

namespace Application.Repository;

public interface IUserRepository:IGenericRepository<User>
{
   string Login(string email, string password);
   string Jwt(int id);
}