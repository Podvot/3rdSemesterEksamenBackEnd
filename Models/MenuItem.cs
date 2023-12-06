using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class MenuItem
{
    [Column(TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Double? Price { get; set; }
    
    public List<Recipe> Recipes { get; set; }
  
}