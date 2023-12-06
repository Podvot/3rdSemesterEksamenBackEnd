using Data.Repository;
using Models;

namespace Business.Service;

public class MenuItemRecipeService :IMenuItemRecipeService
{

    private IMenuItemRecipeRepository _menuItemRecipeRepository;

    
    public void AddRecipe(Guid menuItemId, Recipe recipe)
    {
        _menuItemRecipeRepository.AddRecipe(menuItemId, recipe);
    }
    
    public IList<MenuItem> GetMenuItems()
    {
        return _menuItemRecipeRepository.GetMenuItems();
    }

    public MenuItem? GetMenuItem(Guid id)
    {
        return _menuItemRecipeRepository.GetMenuItem(id);
    }
    public bool MenuItemRecipeExists(Guid id)
    {
        return _menuItemRecipeRepository.MenuItemRecipeExists(id);
    }    
}