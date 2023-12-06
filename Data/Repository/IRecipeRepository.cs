using Models;

namespace Data.Repository;

public interface IRecipeRepository
{
    IList<Recipe> GetRecipes();
    Recipe GetRecipe(Guid id);
    Recipe CreateRecipe(Recipe recipe);
    bool RecipeExists(Guid id);
    Recipe UpdateRecipe(Guid id, Recipe recipe);
    void DeleteRecipe(Guid id);
    void AddIngredient(Guid recipeId, Ingredient ingredient);
    
}