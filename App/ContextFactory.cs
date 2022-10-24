using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace App;

public interface IContextFactory
{
    ExampleContext GetContext();
}

public class ContextFactory : IContextFactory, IDesignTimeDbContextFactory<ExampleContext>
{
    public ExampleContext GetContext() => new(GetOptions());

    /// <summary>
    /// Create context for local migrations
    /// https://docs.microsoft.com/ru-ru/ef/core/miscellaneous/cli/dbcontext-creation
    /// </summary>
    public ExampleContext CreateDbContext(string[] args) => GetContext();

    private DbContextOptions<ExampleContext> GetOptions()
    {
        var optionsBuilder = new DbContextOptionsBuilder<ExampleContext>();

        return optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=example;Username=example;Password=example;")
            .Options;
    }
}