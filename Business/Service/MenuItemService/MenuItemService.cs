using Data.Repository.MenuItem;
using Models.MenuItems;

namespace Business.Service.MenuItemService;

public class MenuItemService : IMenuItemService
{
    private IMenuItemRepository _menuItemRepository;
    
    public MenuItemService(IMenuItemRepository menuItemRepository)
    {
        _menuItemRepository = menuItemRepository;
    }

    public IList<MenuItem> GetMenuItems()
    {
        return _menuItemRepository.GetMenuItems();
    }

    public MenuItem? GetMenuItem(Guid id)
    {
        return _menuItemRepository.GetMenuItem(id);
    }

    public MenuItem CreateMenuItem(MenuItem menuItem)
    {
        return _menuItemRepository.CreateMenuItem(menuItem);
    }

    public bool MenuItemExists(Guid id)
    {
        return _menuItemRepository.MenuItemExists(id);
    }

    public MenuItem? UpdateMenuItem(Guid id, MenuItem menuItem)
    {
        return _menuItemRepository.UpdateMenuItem(id, menuItem);
    }

    public void DeleteMenuItem(Guid id)
    {
        _menuItemRepository.DeleteMenuItem(id);
    }
}