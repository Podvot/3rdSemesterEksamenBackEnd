using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class MenuItemRepository : IMenuItemRepository
{
    private readonly LibraryContext _context;
    
    public MenuItemRepository(LibraryContext context)
    {
        _context = context;
    }
    
    public IList<MenuItem> GetMenuItems()
    {
        return _context
            .MenuItems
            .Include(x => x.AddedIngredients)
            .ToList();
    }

    public MenuItem GetMenuItem(Guid id)
    {
        return _context
                   .MenuItems
                   .Include(x => x.AddedIngredients)
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

    public void AddIngredient(Guid menuItemId, Ingredient ingredient)
    {
        var menuItem = GetMenuItem(menuItemId);
        menuItem.AddedIngredients.Add(ingredient);
        _context.SaveChanges();
    }
    
    public void DeleteMenuItem(Guid id)
    {
        var menuItem = GetMenuItem(id);

        foreach (var ingredient in menuItem.AddedIngredients)
        {
            ingredient.MenuItemId = null;
        }
        
        _context.MenuItems.Remove(menuItem);
        _context.SaveChanges();
    }
}