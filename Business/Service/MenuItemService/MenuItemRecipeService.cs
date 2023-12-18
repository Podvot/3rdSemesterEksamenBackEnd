using Data.Repository.MenuItemRepository;
using Models.MenuItems;
using Models.Recipes;

namespace Business.Service.MenuItemService;

public class MenuItemRecipeService :IMenuItemRecipeService
{

    private IMenuItemRecipeRepository _menuItemRecipeRepository;

    public IList<MenuRecipe> GetMenuRecipes()
    {
        return _menuItemRecipeRepository.GetMenuRecipes();
    }
    
    public void AddRecipe(Guid menuRecipeId, Recipe recipe)
    {
        _menuItemRecipeRepository.AddRecipe(menuRecipeId, recipe);
    }

    public MenuRecipe? GetMenuRecipe(Guid id)
    {
        return _menuItemRecipeRepository.GetMenuRecipe(id);
    }
    public bool MenuRecipeExists(Guid id)
    {
        return _menuItemRecipeRepository.MenuRecipeExists(id);
    }   
}