using Data.Repository;
using Models;

namespace Business.Service;

public class RecipeService : IRecipeService
{
    private IRecipeRepository _recipeRepository;
    
    public RecipeService(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public IList<Recipe> GetRecipes()
    {
        return _recipeRepository.GetRecipes();
    }

    public Recipe? GetRecipe(Guid id)
    {
        return _recipeRepository.GetRecipe(id);
    }

    public Recipe CreateRecipe(Recipe recipe)
    {
        return _recipeRepository.CreateRecipe(recipe);
    }

    public bool RecipeExists(Guid id)
    {
        return _recipeRepository.RecipeExists(id);
    }

    public Recipe? UpdateRecipe(Guid id, Recipe recipe)
    {
        return _recipeRepository.UpdateRecipe(id, recipe);
    }
    
    public void AddIngredient(Guid recipeId, Ingredient ingredient)
    {
        _recipeRepository.AddIngredient(recipeId, ingredient);
    }

    public void DeleteRecipe(Guid id)
    {
        _recipeRepository.DeleteRecipe(id);
    }
}