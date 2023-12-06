using Models;

namespace Business.Service;

public interface IMenuItemService
{
    IList<MenuItem> GetMenuItems();
    MenuItem? GetMenuItem(Guid id);
    MenuItem CreateMenuItem(MenuItem menuItem);
    bool MenuItemExists(Guid id);
    MenuItem? UpdateMenuItem(Guid id, MenuItem menuItem);
    void DeleteMenuItem(Guid id);
}