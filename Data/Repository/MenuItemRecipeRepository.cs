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
        var menuItem = _context.MenuItems.FirstOrDefault(r => (r.Id == menuItemId));
    
        if (menuItem == null)
        {
            menuItem = new MenuItem
            {
                Id = menuItemId
            };
            _context.MenuItems.Add(menuItem);
        }
    
        menuItem.Recipes.Add(recipe);
        _context.SaveChanges();
    }

    public IList<MenuItem> GetMenuItems()
    {
        return _context.MenuItems
            .Include(x => x.Recipes)
            .ToList();
    }

    public MenuItem GetMenuItem(Guid id)
    {
        return _context
                   .MenuItems
                   .Include(x => x.Recipes)
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    public bool MenuItemRecipeExists(Guid id)
    {
        return _context.MenuItems.Any(x => x.Id == id);
    }    
}