
namespace Models.Recipes;

public class CreateRecipeIngredientDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    
    public bool Seasonal { get; set; }
    
    public bool Available { get; set; }

}