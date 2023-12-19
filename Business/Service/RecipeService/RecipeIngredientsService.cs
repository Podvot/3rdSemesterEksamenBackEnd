using Data.Repository.RecipeRepository;
using Models.Ingredients;
using Models.Recipes;

namespace Business.Service.RecipeService;

public class RecipeIngredientsService : IRecipeIngredientsService
{
    private IRecipeIngredientRepository _recipeIngredientRepository;
    
    public IList<RecipeIngredients> GetRecipeIngredients()
    {
        return _recipeIngredientRepository.GetRecipeIngredients();
    }
    
    public void AddIngredient(Guid recipeIngredientId, Ingredient ingredient)
    { 
        _recipeIngredientRepository.AddIngredient(recipeIngredientId, ingredient);

    }
    
    public RecipeIngredients? GetRecipeIngredient(Guid id)
    {
        return _recipeIngredientRepository.GetRecipeIngredient(id);
    }

    public RecipeIngredients CreateRecipeIngredient(RecipeIngredients recipeIngredients)
    {
        return _recipeIngredientRepository.CreateRecipeIngredient(recipeIngredients);
    }

    public bool RecipeIngredientExists(Guid id)
    {
        return _recipeIngredientRepository.RecipeIngredientExists(id);
    }

    public void DeleteRecipeIngredient(Guid id)
    {
        _recipeIngredientRepository.DeleteRecipeIngredient(id);
    }
}