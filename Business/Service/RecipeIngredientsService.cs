using Data.Repository;
using Models;

namespace Business.Service;

public class RecipeIngredientsService : IRecipeIngredientsService
{
    private IRecipeIngredientRepository _recipeIngredientRepository;
    
    public void AddIngredient(Guid recipeId, Guid ingredient)
    { 
        _recipeIngredientRepository.AddIngredient(recipeId, ingredient);
    }

    public IList<Recipe> GetRecipes()
    {
        return _recipeIngredientRepository.GetRecipes();
    }

    public Recipe GetRecipe(Guid id)
    {
        return _recipeIngredientRepository.GetRecipe(id);
    }
    
    public bool RecipeExists(Guid id)
    {
        return _recipeIngredientRepository.RecipeIngredientExists(id);
    }
    
}