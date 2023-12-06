using Models;

namespace Data.Repository;

public interface IMenuItemRepository
{
    IList<MenuItem> GetMenuItems();
    MenuItem GetMenuItem(Guid id);
    MenuItem CreateMenuItem(MenuItem menuItem);
    bool MenuItemExists(Guid id);
    MenuItem UpdateMenuItem(Guid id, MenuItem menuItem);
    void DeleteMenuItem(Guid id);
    void AddRecipe(Guid menuItemId, Recipe recipe);
}