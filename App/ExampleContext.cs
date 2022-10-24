using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App;

public class ExampleContext : DbContext
{
    public DbSet<ExampleEntity> ExampleEntities { get; set; } = default!;

    // public readonly ValueComparer<Flag[]> FlagArrayValueComparer = new((c1, c2) => c1.SequenceEqual(c2),
    //     c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
    //     c => c.ToArray());

    public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<ExampleEntity>()
        //     .Property(e => e.Flags)
        //     .HasDefaultValue(Array.Empty<Flag>())
        //     .HasPostgresArrayConversion<Flag, string>(new EnumToStringConverter<Flag>())
        //     .Metadata.SetValueComparer(FlagArrayValueComparer);
    }
}