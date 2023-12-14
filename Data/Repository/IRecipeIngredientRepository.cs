using Models;

namespace Data.Repository;

public interface IRecipeIngredientRepository
{
    
    void AddIngredient(Guid recipeId, Ingredient ingredient);
    Recipe GetRecipe(Guid id);
    bool RecipeExists(Guid id);
    
}