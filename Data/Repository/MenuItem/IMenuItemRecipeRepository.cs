using Models.MenuItems;
using Models.Recipes;

namespace Data.Repository.MenuItem;

public interface IMenuItemRecipeRepository
{
    void AddRecipe(Guid menuRecipeId, Recipe recipe);
    IList<Models.MenuItems.MenuRecipe> GetMenuRecipes();
    Models.MenuItems.MenuRecipe GetMenuRecipe(Guid id);
    bool MenuRecipeExists(Guid id);

}