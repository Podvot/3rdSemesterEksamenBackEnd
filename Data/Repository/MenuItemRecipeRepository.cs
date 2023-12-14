using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class MenuItemRecipeRepository : IMenuItemRecipeRepository
{
    
    private readonly KaffeshopContext _context;
    
    public MenuItemRecipeRepository(KaffeshopContext context)
    {
        _context = context;
    }

    public void AddRecipe(Guid menuItemId, Recipe recipe)
    {
        var menuItem = GetMenuItem(menuItemId);
        menuItem.AttachRecipe.Add(recipe);
        _context.SaveChanges();
    }

    public MenuItem GetMenuItem(Guid id)
    {
        return _context
                   .MenuItems
                   .Include(x => x.AttachRecipe)
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    public bool MenuItemExists(Guid id)
    {
        return _context.MenuItems.Any(x => x.Id == id);
    }    
}