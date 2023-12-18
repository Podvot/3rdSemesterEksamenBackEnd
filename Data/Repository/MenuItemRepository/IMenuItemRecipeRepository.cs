using Models.MenuItems;
using Models.Recipes;

namespace Data.Repository.MenuItemRepository;

public interface IMenuItemRecipeRepository
{
    void AddRecipe(Guid menuRecipeId, Recipe recipe);
    IList<MenuRecipe> GetMenuRecipes();
    MenuRecipe GetMenuRecipe(Guid id);
    bool MenuRecipeExists(Guid id);

}