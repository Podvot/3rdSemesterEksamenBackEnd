using Models;

namespace Business.Service;

public interface IMenuItemRecipeService
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    bool MenuItemRecipeExists(Guid id);
    IList<MenuItem> GetMenuItems();
    MenuItem? GetMenuItem(Guid id);
}