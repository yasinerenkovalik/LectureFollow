using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Persistence;

public static class JwtRegistiration
{
    public static void AddJwtServices(this IServiceCollection services)
    {
        var signinKey = "bubenimsigninkeyim";
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signinKey));

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "http://www.yasineren.com",
                    ValidAudience = "mysecuritykey",
                    IssuerSigningKey = securityKey
                };
            });
    }
}