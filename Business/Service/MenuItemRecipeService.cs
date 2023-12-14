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

    public MenuItem? GetMenuItem(Guid id)
    {
        return _menuItemRecipeRepository.GetMenuItem(id);
    }
    public bool MenuItemExists(Guid id)
    {
        return _menuItemRecipeRepository.MenuItemExists(id);
    }   
}