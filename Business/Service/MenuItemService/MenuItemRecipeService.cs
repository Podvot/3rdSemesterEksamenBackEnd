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
    
    public void AddRecipe(Guid menuItemId, Recipe recipe)
    { 
        _menuItemRecipeRepository.AddRecipe(menuItemId, recipe);
    }

    public MenuRecipe GetMenuRecipe(Guid id)
    {
        return _menuItemRecipeRepository.GetMenuRecipe(id);
    }
    
    public MenuRecipe CreateMenuRecipe(MenuRecipe menuRecipe)
    {
        return _menuItemRecipeRepository.CreateMenuRecipe(menuRecipe);
    }

    public bool MenuRecipeExists(Guid id)
    {
        return _menuItemRecipeRepository.MenuRecipeExists(id);
    }
    
    public void DeleteMenuRecipe(Guid id)
    {
        _menuItemRecipeRepository.DeleteMenuRecipe(id);
    }
}