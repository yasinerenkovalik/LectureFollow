using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Persistence.Context;

namespace Persistence.Repository;

public class UserRepository:Repository<User>, IUserRepository
{
   
    private readonly OracleContext _context;
    private readonly IConfiguration _configuration;

    public UserRepository(OracleContext context,IConfiguration configuration) : base(context)
    {
        _context = context;
        _configuration = configuration;
    }
    
    public string? Login(string email, string password)
    {
      var login=  _context.Set<User>().Where(n => n.Email == email && n.Password == password).FirstOrDefault();
      if (login.Active==false || login==null  )
      {
          return null;
      } 
      var result= Jwt(login.Id);

      return result;
    }

    public string? Jwt(int id)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.NameId,id.ToString()),
        };
         
        var singninKey = _configuration["jwt:SingingKey"];
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(singninKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
          

        var jwtSecurityToken = new JwtSecurityToken(
            issuer: _configuration["jwt:Issure"],
            audience: _configuration["jwt:Audience"],
            claims:claims,
            expires:DateTime.Now.AddDays(15),
            notBefore:DateTime.Now,
            signingCredentials:credentials
        );
        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
           
       
        return token;
    }
}