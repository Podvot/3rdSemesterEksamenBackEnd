using Models;
namespace Data.Repository;

public interface IMenuItemRecipeRepository
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    IList<MenuItem> GetMenuItems();
    MenuItem GetMenuItem(Guid id);
    bool MenuItemRecipeExists(Guid id);

}