using Microsoft.EntityFrameworkCore;

namespace Persistence.Context;

public class OracleContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseOracle(
            "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=postgres;Pooling=true;Connection Lifetime=0;");
    }
}