using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Recipe
{
    
    [Column(TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Seasonal { get; set; }
    public IList<Ingredient> AddedIngredients { get; set; } = new List<Ingredient>();
    public Guid? MenuItemId { get; set; }

}