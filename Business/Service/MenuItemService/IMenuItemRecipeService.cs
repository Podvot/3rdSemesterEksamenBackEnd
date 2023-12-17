using Models.MenuItems;
using Models.Recipes;

namespace Business.Service.MenuItemService;

public interface IMenuItemRecipeService
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    bool MenuRecipeExists(Guid id);
    MenuRecipe? GetMenuRecipe(Guid id);
    IList<MenuRecipe> GetMenuRecipes();

}