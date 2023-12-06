using Models;

namespace Business.Service;

public interface IRecipeService
{
    IList<Recipe> GetRecipes();
    Recipe GetRecipe(Guid id);
    Recipe CreateRecipe(Recipe recipe);
    bool RecipeExists(Guid id);
    Recipe UpdateRecipe(Guid id, Recipe recipe);
    void DeleteRecipe(Guid id);
    void AddIngredient(Guid recipeId, Ingredient ingredient);
}