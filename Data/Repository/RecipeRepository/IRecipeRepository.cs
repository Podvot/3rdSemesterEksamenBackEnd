using Models.Recipes;

namespace Data.Repository.RecipeRepository;

public interface IRecipeRepository
{
    Recipe GetRecipe(Guid id);
    IList<Recipe> GetRecipes();
    Recipe CreateRecipe(Recipe recipe);
    bool RecipeExists(Guid id);
    void DeleteRecipe(Guid id);
    
}