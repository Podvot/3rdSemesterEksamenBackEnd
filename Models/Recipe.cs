using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Recipe
{
    [Key]
    public Guid Id { get; set; }
    
    public String Name { get; set; }
    
    public bool Seasonal { get; set; }
    
    public bool Available { get; set; }
    
    [ForeignKey("Id")]
    public List<Guid> Ingredients { get; set; }
    
}