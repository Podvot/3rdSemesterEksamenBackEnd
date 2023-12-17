using Microsoft.EntityFrameworkCore;
using Models.MenuItems;
using Models.Recipes;

namespace Data.Repository.MenuItem;

public class MenuItemRecipeRepository : IMenuItemRecipeRepository
{
    
    private readonly KaffeshopContext _context;
    
    public MenuItemRecipeRepository(KaffeshopContext context)
    {
        _context = context;
    }

    public void AddRecipe(Guid menuRecipeId, Recipe recipe)
    {
        var menuRecipe = GetMenuRecipe(menuRecipeId);
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
                   .Include(x => x.AttachRecipe)
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    public bool MenuRecipeExists(Guid id)
    {
        return _context.MenuRecipes.Any(x => x.Id == id);
    }    
}