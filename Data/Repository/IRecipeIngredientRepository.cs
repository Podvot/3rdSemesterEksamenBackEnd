using Models;

namespace Data.Repository;

public interface IRecipeIngredientRepository
{
    
    void AddIngredient(Guid recipeId, Guid ingredient);
    IList<Recipe> GetRecipes();
    Recipe GetRecipe(Guid id);
    bool RecipeIngredientExists(Guid id);
    
}