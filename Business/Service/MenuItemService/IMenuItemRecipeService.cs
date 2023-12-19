using Models.MenuItems;
using Models.Recipes;

namespace Business.Service.MenuItemService;

public interface IMenuItemRecipeService
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    IList<MenuRecipe> GetMenuRecipes();
    MenuRecipe CreateMenuRecipe(MenuRecipe menuRecipe);
    MenuRecipe GetMenuRecipe(Guid id);  
    bool MenuRecipeExists(Guid id);
    void DeleteMenuRecipe(Guid id);
}