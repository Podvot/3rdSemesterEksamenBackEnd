using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class RecipeRecord
{
    [Column(TypeName =  "uniqueidentifier")]
    public Guid Id { get; set; }
    
    [Column(TypeName =  "uniqueidentifier")]
    public Guid IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
    
    [Column(TypeName =  "uniqueidentifier")]
    public Guid MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; }
    
    [Column(TypeName = "uniqueidentifier")]
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    public DateTime MenuItemOn { get; set; }
}