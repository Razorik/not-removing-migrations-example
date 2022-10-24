using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App;

public enum Flag
{
    FirstFlag,
    
    SecondFlag,
    
    ThirdFlag
}

[Table("example_entities")]
public class ExampleEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("flags")]
    public Flag[] Flags { get; set; } = default!;
}