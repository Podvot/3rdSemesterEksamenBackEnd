using Models;

namespace Business.Service;

public interface IRecipeIngredientsService
{
    void AddIngredient(Guid recipeId, Ingredient ingredient);
    Recipe GetRecipe(Guid id);  
    bool RecipeExists(Guid id);

}