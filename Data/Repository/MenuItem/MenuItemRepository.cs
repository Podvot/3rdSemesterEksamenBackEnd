using Microsoft.EntityFrameworkCore;
using Models.MenuItems;

namespace Data.Repository.MenuItem;

public class MenuItemRepository : IMenuItemRepository
{
    private readonly KaffeshopContext _context;
    
    public MenuItemRepository(KaffeshopContext context)
    {
        _context = context;
    }
    
    public IList<Models.MenuItems.MenuItem> GetMenuItems()
    {
        return _context.MenuItems
            .ToList();
    }

    public Models.MenuItems.MenuItem GetMenuItem(Guid id)
    {
        return _context
                   .MenuItems
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();
    }

    public Models.MenuItems.MenuItem CreateMenuItem(Models.MenuItems.MenuItem menuItem)
    {
        _context.MenuItems.Add(menuItem);
        _context.SaveChanges();
        return menuItem;
    }

    public bool MenuItemExists(Guid id)
    {
        return _context.MenuItems.Any(x => x.Id == id);
    }

    public Models.MenuItems.MenuItem UpdateMenuItem(Guid id, Models.MenuItems.MenuItem menuItem)
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
    
}