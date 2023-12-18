using System.ComponentModel.DataAnnotations.Schema;
using Models.Ingredients;
using Models.MenuItems;

namespace Models.Recipes;

public class RecipeIngredientRecord
{
    [Column(TypeName =  "uniqueidentifier")]
    public Guid Id { get; set; }
    
    [Column(TypeName =  "uniqueidentifier")]
    public Guid IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
    
    [Column(TypeName = "uniqueidentifier")]
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    public DateTime RecipeIngredientOn { get; set; }
}