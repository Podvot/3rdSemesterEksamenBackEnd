using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class MenuItemRepository : IMenuItemRepository
{
    private readonly KaffeshopContext _context;
    
    public MenuItemRepository(KaffeshopContext context)
    {
        _context = context;
    }
    
    public IList<MenuItem> GetMenuItems()
    {
        return _context
            .MenuItems
            .ToList();
    }

    public MenuItem GetMenuItem(Guid id)
    {
        return _context
                   .MenuItems
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();
    }

    public MenuItem CreateMenuItem(MenuItem menuItem)
    {
        _context.MenuItems.Add(menuItem);
        _context.SaveChanges();
        return menuItem;
    }

    public bool MenuItemExists(Guid id)
    {
        return _context.MenuItems.Any(x => x.Id == id);
    }

    public MenuItem UpdateMenuItem(Guid id, MenuItem menuItem)
    {
        var menuItemToUpdate = GetMenuItem(id);
        menuItemToUpdate.Name = menuItemToUpdate.Name;
        _context.SaveChanges();
        return menuItemToUpdate;
    }
    
    public void DeleteMenuItem(Guid id)
    {
        var menuItem = GetMenuItem(id);
        
        _context.MenuItems.Remove(menuItem);
        _context.SaveChanges();
    }
    
    public void AddRecipe(Guid menuItemId, Recipe recipe)
    {
        var menuItem = GetMenuItem(menuItemId);
        menuItem.AddedRecipe.Add(recipe);
        _context.SaveChanges();
    }
}