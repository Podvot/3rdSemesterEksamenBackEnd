using Models.MenuItems;
using Models.Recipes;

namespace Data.Repository.MenuItemRepository;

public interface IMenuItemRecipeRepository
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    MenuRecipe GetMenuRecipe(Guid id);
    MenuRecipe CreateMenuRecipe(MenuRecipe menuRecipe);
    IList<MenuRecipe> GetMenuRecipes();
    bool MenuRecipeExists(Guid id);
    void DeleteMenuRecipe(Guid id);

}