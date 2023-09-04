using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.Repository;
using Domain;
using Microsoft.IdentityModel.Tokens;
using Persistence.Context;

namespace Persistence.Repository;

public class UserRepository:Repository<User>, IUserRepository
{
   
    private readonly OracleContext _context;

    public UserRepository(OracleContext context) : base(context)
    {
        _context = context;
    }

    public string Login(string email, string password)
    {
      var login=  _context.Set<User>().Where(n => n.Email == email && n.Password == password).FirstOrDefault();
      if (login == null)
      {
          return null;
      }

     var result= Jwt(login.Id);

      return result;
    }

    public string Jwt(int id)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.NameId,id.ToString()),
        };
         
        var singninKey = "bubenimsigninkeyim";
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(singninKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
          

        var jwtSecurityToken = new JwtSecurityToken(
            issuer:"http://www.yasineren.com",
            audience:"mysecuritykey",
            claims:claims,
            expires:DateTime.Now.AddDays(15),
            notBefore:DateTime.Now,
            signingCredentials:credentials
        );
        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
           
       
        return token;
    }
}