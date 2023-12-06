using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class MenuItem
{
    [Column(TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int? Price { get; set; }
    public Guid AddedRecipe { get; set; }

}