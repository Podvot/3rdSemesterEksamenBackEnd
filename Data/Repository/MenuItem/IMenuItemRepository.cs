using Models;
using Models.MenuItems;

namespace Data.Repository.MenuItem;

public interface IMenuItemRepository
{
    IList<Models.MenuItems.MenuItem> GetMenuItems();
    Models.MenuItems.MenuItem GetMenuItem(Guid id);
    Models.MenuItems.MenuItem CreateMenuItem(Models.MenuItems.MenuItem menuItem);
    bool MenuItemExists(Guid id);
    Models.MenuItems.MenuItem UpdateMenuItem(Guid id, Models.MenuItems.MenuItem menuItem);
    void DeleteMenuItem(Guid id);
}