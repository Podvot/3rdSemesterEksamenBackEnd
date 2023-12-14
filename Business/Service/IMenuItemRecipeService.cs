using Models;

namespace Business.Service;

public interface IMenuItemRecipeService
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    bool MenuItemExists(Guid id);
    MenuItem? GetMenuItem(Guid id);
}