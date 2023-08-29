using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context;

public class OracleContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=postgres;Pooling=true;Connection Lifetime=0;");
    }//burası her zmana değişecek

    public DbSet<Officer>Ofisser { get; set; }
    public DbSet<Student>Students { get; set; }
    public DbSet<Teacher>Teachers { get; set; }
}