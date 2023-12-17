using Models.Ingredients;
using Models.Recipes;

namespace Data.Repository.RecipeRepository;

public interface IRecipeIngredientRepository
{
    
    void AddIngredient(Guid recipeIngredientsId, Ingredient ingredient);
    RecipeIngredients GetRecipeIngredient(Guid id);
    RecipeIngredients CreateRecipeIngredient(RecipeIngredients recipeIngredients);
    IList<RecipeIngredients> GetRecipeIngredients();
    bool RecipeIngredientExists(Guid id);
    void DeleteRecipeIngredient(Guid id);
    
}