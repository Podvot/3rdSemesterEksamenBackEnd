using Models;

namespace Business.Service;

public interface IRecipeIngredientsService
{
    void AddIngredient(Guid recipeId, Guid ingredient);
    IList<Recipe> GetRecipes();
    Recipe GetRecipe(Guid id);  
    bool RecipeExists(Guid id);

}