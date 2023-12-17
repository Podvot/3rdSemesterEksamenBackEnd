using Models.MenuItems;

namespace Business.Service.MenuItemService;

public interface IMenuItemService
{
    IList<MenuItem> GetMenuItems();
    MenuItem? GetMenuItem(Guid id);
    MenuItem? UpdateMenuItem(Guid id, MenuItem menuItem);
    bool MenuItemExists(Guid id);
    void DeleteMenuItem(Guid id);
    MenuItem CreateMenuItem(MenuItem menuItem);

}