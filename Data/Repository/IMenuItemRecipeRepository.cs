using Models;
namespace Data.Repository;

public interface IMenuItemRecipeRepository
{
    void AddRecipe(Guid menuItemId, Recipe recipe);
    MenuItem GetMenuItem(Guid id);
    bool MenuItemExists(Guid id);

}