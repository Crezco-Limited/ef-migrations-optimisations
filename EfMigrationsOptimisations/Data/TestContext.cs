using Microsoft.EntityFrameworkCore;

namespace EfMigrationsOptimisations.Data;

public class TestContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Shoe> Shoes { get; set; }
}