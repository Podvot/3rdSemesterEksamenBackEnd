using Models;

namespace Business.Service;

public interface IRecipeService
{
    IList<Recipe> GetRecipes();
    Recipe GetRecipe(Guid id);
    Recipe CreateRecipe(Recipe recipe);
    bool RecipeExists(Guid id);
    void DeleteRecipe(Guid id);
}