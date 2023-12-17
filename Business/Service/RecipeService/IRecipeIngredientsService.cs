using Models;
using Models.Ingredients;
using Models.Recipes;

namespace Business.Service.RecipeService;

public interface IRecipeIngredientsService
{
    void AddIngredient(Guid recipeIngredientId, Ingredient ingredient);
    IList<RecipeIngredients> GetRecipeIngredients();
    RecipeIngredients CreateRecipeIngredient(RecipeIngredients recipeIngredients);
    RecipeIngredients GetRecipeIngredient(Guid id);  
    bool RecipeIngredientExists(Guid id);
    void DeleteRecipeIngredient(Guid id);

}