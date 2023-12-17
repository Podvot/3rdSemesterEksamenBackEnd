using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Ingredients;

public class Ingredient
{
    [Column(TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Available { get; set; }
    
    public Guid RecipeIngredientId { get; set; }
    
}