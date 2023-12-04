using Data.Repository;
using Models;

namespace Business.Service;

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
    
    public void AddIngredient(Guid menuItemId, Ingredient ingredient)
    {
        _menuItemRepository.AddIngredient(menuItemId, ingredient);
    }

    public void DeleteMenuItem(Guid id)
    {
        _menuItemRepository.DeleteMenuItem(id);
    }
}