using Microsoft.EntityFrameworkCore;
using Models.MenuItems;
using Models.Recipes;

namespace Data.Repository.MenuItemRepository;

public class MenuItemRecipeRepository : IMenuItemRecipeRepository
{
    
    private readonly KaffeshopContext _context;

    public MenuItemRecipeRepository(KaffeshopContext context)
    {
        _context = context;
    }
    
    public void AddRecipe(Guid menuItemId, Recipe recipe)
    {
        var menuRecipe = GetMenuRecipe(menuItemId);
        menuRecipe.AttachRecipe.Add(recipe);
        _context.SaveChanges();
    }

    public IList<MenuRecipe> GetMenuRecipes()
    { 
        return _context.MenuRecipes
            .Include(x => x.AttachRecipe)
            .ToList();
    }
    
    public MenuRecipe GetMenuRecipe(Guid id)
    {
        return _context
                   .MenuRecipes
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    
    public MenuRecipe CreateMenuRecipe(MenuRecipe menuRecipe)
    {
        _context.MenuRecipes.Add(menuRecipe);
        _context.SaveChanges();
        return menuRecipe;
    }
    
    public bool MenuRecipeExists(Guid id)
    {
        return _context.MenuRecipes.Any(x => x.Id == id);
    }
    
    public void DeleteMenuRecipe(Guid id)
    {
        var menuRecipe = GetMenuRecipe(id);
        
        _context.MenuRecipes.Remove(menuRecipe);
        _context.SaveChanges();
    }
}