using Models;
using Models.Recipes;

namespace Business.Service.RecipeService;

public interface IRecipeService
{
    Recipe GetRecipe(Guid id);
    IList<Recipe> GetRecipes();
    Recipe CreateRecipe(Recipe recipe);
    bool RecipeExists(Guid id);
    void DeleteRecipe(Guid id);
}