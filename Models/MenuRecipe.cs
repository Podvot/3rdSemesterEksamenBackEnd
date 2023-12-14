using Microsoft.EntityFrameworkCore;

namespace Models;

public class MenuRecipe
{

    public Guid MenuItemId { get; set; }

    public Guid? RecipeId { get; set; }
    
    public MenuItem MenuItem { get; set; }
    
}