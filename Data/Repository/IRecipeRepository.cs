using Models;

namespace Data.Repository;

public interface IRecipeRepository
{
    IList<Recipe> GetRecipes();
    Recipe GetRecipe(Guid id);
    Recipe CreateRecipe(Recipe recipe);
    bool RecipeExists(Guid id);
    void DeleteRecipe(Guid id);
    
}