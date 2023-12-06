using Models;

namespace Business.Service;

public interface IMenuItemService
{
    IList<MenuItem> GetMenuItems();
    MenuItem? GetMenuItem(Guid id);
    MenuItem CreateMenuItem(MenuItem menuItem);
    bool MenuItemExists(Guid id);
    MenuItem? UpdateMenuItem(Guid id, MenuItem menuItem);
    void AddRecipe(Guid menuItemId, Guid recipeId);
    void DeleteMenuItem(Guid id);
}