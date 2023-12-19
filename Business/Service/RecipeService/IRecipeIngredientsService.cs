using Models.Ingredients;
using Models.Recipes;

namespace Business.Service.RecipeService;

public interface IRecipeIngredientsService
{
    void AddIngredient(Guid recipeIngredientId, Ingredient ingredient);
    RecipeIngredients? GetRecipeIngredient(Guid id);
    IList<RecipeIngredients> GetRecipeIngredients();
    RecipeIngredients CreateRecipeIngredient(RecipeIngredients recipeIngredients);
    bool RecipeIngredientExists(Guid id);
    void DeleteRecipeIngredient(Guid id);

}