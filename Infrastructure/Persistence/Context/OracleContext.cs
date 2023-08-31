using Domain;
using Domain.AppSetting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context;

public class OracleContext:DbContext
{
   
  
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        

       
        optionsBuilder.UseNpgsql(
            "");
    }//burası her zmana değişecek

  
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    
}