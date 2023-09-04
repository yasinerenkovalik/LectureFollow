using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context;

public class OracleContext:DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=Lecture;Pooling=true;Connection Lifetime=0;");
    }//burası her zmana değişecek
    
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<StudentLecture> StudentLectures { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

}