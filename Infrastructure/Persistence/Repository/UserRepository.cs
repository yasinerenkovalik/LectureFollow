using Application.Repository;
using Domain;
using Persistence.Context;

namespace Persistence.Repository;

public class UserRepository:Repository<User>, IUserRepository
{
    public UserRepository(OracleContext context) : base(context)
    {
    }

    public string Login(string email, string password)
    {
      var login=  new Context.OracleContext().Set<User>().Where(n => n.Email == email && n.Password == password).FirstOrDefault();
      if (login == null)
      {
          return "böyle bir kullanıcı bulunamadı";
      }

      return "Giriş işlemi başarılı";
    }
}